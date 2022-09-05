using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicManagementSystem.Forms.SideForms;
using ClinicManagementSystem.Forms.MainForms;
using ClinicManagementSystem.Forms.EventArguments;
using Microsoft.Extensions.DependencyInjection;
using ClinicManagementSystem.Services;
using ClinicManagementSystem.Auth.Services;
using ClinicManagementSystem.Entities;
using ClinicManagementSystem.Entities.Models;
using Microsoft.Extensions.Configuration;

namespace ClinicManagementSystem.Forms.MainForms
{
    public partial class MainWindow : Form
    {
        private int move;
        private int moveX;
        private int moveY;
        private bool mouseDownFlag = false;
        private LaboratoryForm _laboratoryForm;
        private ManagerForm _managerForm;
        private VisitsMainForm _visitsMainForm;
        private NewVisitForm _newVisitForm;
        private PerformVisitForm _performVisitForm;
        private Form _previousForm;
        private MainFormType? _previousFormType;

        private LoginForm _loginForm;
        private SideMenu _sideMenuForm;

        private IServiceProvider _provider;
        private UserLevel _level;
        private IConfigurationRoot _configuration;

        private MainFormType _activeMainForm;

        public MainWindow(IServiceProvider provider, UserLevel level, IConfigurationRoot configuration)
        {
            _provider = provider;
            _level = level;
            _configuration = configuration;
            _activeMainForm = MainFormType.Main;
            InitializeComponent();
            ShowLoginForm();
            this.LogoutButton.Hide();
            // dummy query to initialize connection
            ISystemContext systemContext = _provider.GetService<ISystemContext>();
            systemContext.DbConnectionInitialization = new Task(() => _ = systemContext.Set<ApplicationUser>().FirstOrDefault());
            systemContext.DbConnectionInitialization.Start();
        }


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownFlag = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //Check if Flag is True ??? if so then make form position same
            //as Cursor position
            if (mouseDownFlag == true)
            {
                this.Location = Cursor.Position;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDownFlag = false;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowLoginForm()
        {
            _loginForm = new LoginForm(_provider, this.Close);
            _loginForm.ButtonClicked += LoginButtonClicked;
            InitializeForm(_loginForm, FormType.SideForm);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            _provider.GetService<IAuthorizationService>().UserLogout();
            UnloadMainForm();
            _activeMainForm = MainFormType.Main;
            if(_sideMenuForm!=null)
            {
                _sideMenuForm.ButtonClicked -= LoadMainForm;
            }
            this.LogoBox.Show();
            this.LogoText.Show();
            this.LogoutButton.Hide();
            this.SideUpperPanel.Controls.Remove(_sideMenuForm);
            ShowLoginForm();
        }

        private void LoginButtonClicked(object sender, PageControllingButtonClickedArgs args)
        {
            _level = args.UserLevel;
            this.LogoBox.Hide();
            this.LogoText.Hide();
            this.LogoutButton.Show();
            this.SideUpperPanel.Controls.Remove(_loginForm);
            ShowSideMenuForm();
        }

        private void ShowSideMenuForm()
        {
            _sideMenuForm = new SideMenu(_level);
            _loginForm.ButtonClicked -= LoginButtonClicked;
            _sideMenuForm.ButtonClicked += LoadMainForm;
            InitializeForm(_sideMenuForm, FormType.SideForm);
        }

        private void ShowVisitMainForm()
        {
            UnloadMainForm();
            _visitsMainForm = new VisitsMainForm(_level, _provider.GetService<IAppointmentService>(), _provider.GetService<IPatientService>(), _provider.GetService<IAuthorizationService>());
            _visitsMainForm.ButtonClicked += LoadMainForm;
            _activeMainForm = MainFormType.VisitMainForm;
            InitializeForm(_visitsMainForm, FormType.MainForm);
        }

        private void ShowPerformVisitForm(Appointment currentAppointment)
        {
            UnloadMainForm();
            _performVisitForm = new PerformVisitForm(_provider, currentAppointment);
            _performVisitForm.ClosingButtonClicked += LoadMainForm;
            _activeMainForm = MainFormType.PerformVisit;
            InitializeForm(_performVisitForm, FormType.MainForm);
        }

        private void ShowLaboratoryForm()
        {
            UnloadMainForm();
            _laboratoryForm = new LaboratoryForm(_level, _provider.GetService<ILaboratoryExamService>());
            _activeMainForm = MainFormType.Laboratory;
            InitializeForm(_laboratoryForm, FormType.MainForm);
        }

        private void ShowNewVisitForm()
        {
            UnloadMainForm();
            _newVisitForm = new NewVisitForm(_provider);
            _newVisitForm.NewPatientButtonClicked += LoadMainForm;
            _activeMainForm = MainFormType.NewVisit;
            InitializeForm(_newVisitForm, FormType.MainForm);
        }

        private void ShowManagerDoctorForm()
        {
            UnloadMainForm();
            _managerForm = new ManagerForm(MainFormType.ManagerDoctors, _provider.GetService<IPatientService>(),
                _provider.GetService<IDoctorService>(), _provider.GetService<IReceptionistService>(), _provider.GetService<ILaboratoryTechnicianService>(),
                _provider.GetService<ILaboratoryManagerService>(),  _provider.GetService<IApplicationUserService>());
            _activeMainForm = MainFormType.ManagerDoctors;
            InitializeForm(_managerForm, FormType.MainForm);
        }

        private void ShowManagerPatientForm(Form previousForm = null, MainFormType? previousFormType = null)
        {
            _previousForm = previousForm;
            _previousFormType = previousFormType;
            UnloadMainForm();
            _managerForm = new ManagerForm(MainFormType.ManagerPatients, _provider.GetService<IPatientService>(),
                _provider.GetService<IDoctorService>(), _provider.GetService<IReceptionistService>(), _provider.GetService<ILaboratoryTechnicianService>(),
                _provider.GetService<ILaboratoryManagerService>(), _provider.GetService<IApplicationUserService>());
            _managerForm.GoBackButtonClicked += GoBackButtonClicked;
            _managerForm.SetGoBackButtonAvailability(previousForm != null);
            _activeMainForm = MainFormType.ManagerPatients;
            InitializeForm(_managerForm, FormType.MainForm);
        }

        private void ShowManagerLabForm()
        {
            UnloadMainForm();
            _managerForm = new ManagerForm(MainFormType.ManagerLaboratory, _provider.GetService<IPatientService>(),
                _provider.GetService<IDoctorService>(), _provider.GetService<IReceptionistService>(), _provider.GetService<ILaboratoryTechnicianService>(),
                _provider.GetService<ILaboratoryManagerService>(), _provider.GetService<IApplicationUserService>());
            _activeMainForm = MainFormType.ManagerLaboratory;
            InitializeForm(_managerForm, FormType.MainForm);
        }

        private void ShowReceptionistForm()
        {
            UnloadMainForm();
            _managerForm = new ManagerForm(MainFormType.ManagerReceptionist, _provider.GetService<IPatientService>(),
                _provider.GetService<IDoctorService>(), _provider.GetService<IReceptionistService>(), _provider.GetService<ILaboratoryTechnicianService>(),
                _provider.GetService<ILaboratoryManagerService>(), _provider.GetService<IApplicationUserService>());
            _activeMainForm = MainFormType.ManagerReceptionist;
            InitializeForm(_managerForm, FormType.MainForm);
        }

        private void InitializeForm(Form form, FormType type)
        {
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.TopMost = true;
            if (type == FormType.SideForm)
            {
                this.SideUpperPanel.Controls.Add(form);
            }
            else if(type == FormType.MainForm)
            {
                this.MainPanel.Controls.Add(form);
            }
            form.Show();
        }

        private void LoadMainForm(object sender, PageControllingButtonClickedArgs args)
        {
            switch (args.UserLevel)
            {
                case UserLevel.Manager:
                {
                    switch (args.WindowType)
                    {
                        case MainFormType.ManagerLaboratory:
                            ShowManagerLabForm();
                            break;
                        case MainFormType.ManagerDoctors:
                            ShowManagerDoctorForm();
                            break;
                        case MainFormType.ManagerReceptionist:
                            ShowReceptionistForm();
                            break;
                        default:
                            ShowManagerPatientForm();
                            break;
                    }
                    break;
                }

                case UserLevel.Doctor:
                {
                    switch (args.WindowType)
                    {
                        case MainFormType.PerformVisit:
                        {
                            if (args.AdditionalParams.Length == 0)
                                throw new ArgumentException("Insufficient parameters");
                            Appointment currentAppointment = args.AdditionalParams[0] as Appointment;
                            if (currentAppointment is null)
                                throw new ArgumentException("Argument is not a type of " + typeof(Appointment).ToString());
                            ShowPerformVisitForm(currentAppointment);
                            break;
                        }
                        case MainFormType.VisitMainForm:
                            ShowVisitMainForm();
                            break;
                        default:
                            break;
                    }
                    break;
                }

                case UserLevel.Laborant:
                case UserLevel.HeadOfLab:
                {
                    if (args.WindowType == MainFormType.Laboratory)
                        ShowLaboratoryForm();
                    break;
                }

                case UserLevel.Receptionist:
                {
                    switch (args.WindowType)
                    {
                        case MainFormType.ManagerPatients:
                        {
                            if (args.AdditionalParams != null && args.AdditionalParams.Length >= 2)
                                ShowManagerPatientForm(args.AdditionalParams[0] as Form, (MainFormType)Enum.ToObject(typeof(MainFormType), args.AdditionalParams[1]));
                            else
                                ShowManagerPatientForm();
                            break;
                        }
                        case MainFormType.NewVisit:
                            ShowNewVisitForm();
                            break;
                        case MainFormType.VisitMainForm:
                            ShowVisitMainForm();
                            break;
                        default:
                            break;
                    }                        
                    break;
                }

                case UserLevel.Undetermined:
                default:
                    break;
            }
        }
        private void UnloadMainForm()
        {
            switch(_activeMainForm)
            {
                case MainFormType.Laboratory:
                    this.MainPanel.Controls.Remove(_laboratoryForm);
                    _laboratoryForm.Hide();
                    break;
                case MainFormType.ManagerLaboratory:
                case MainFormType.ManagerDoctors:
                case MainFormType.ManagerReceptionist:
                case MainFormType.ManagerPatients:
                    this.MainPanel.Controls.Remove(_managerForm);
                    _managerForm.Hide();
                    break;
                case MainFormType.NewVisit:
                    this.MainPanel.Controls.Remove(_newVisitForm);
                    _newVisitForm.NewPatientButtonClicked -= LoadMainForm;
                    _newVisitForm.Hide();
                    break;
                case MainFormType.PerformVisit:
                    this.MainPanel.Controls.Remove(_performVisitForm);
                    _performVisitForm.Hide();
                    _performVisitForm.ClosingButtonClicked -= LoadMainForm;
                    break;
                case MainFormType.VisitMainForm:
                    this.MainPanel.Controls.Remove(_visitsMainForm);
                    _visitsMainForm.Hide();
                    _visitsMainForm.ButtonClicked -= LoadMainForm;
                    break;
                default:
                    break;
            }
        }


        private void GoBackButtonClicked()
        {
            if (_previousFormType == null || _previousForm == null)
                throw new InvalidOperationException("_previousFormType == null || _previousForm == null");

            UnloadMainForm();

            _newVisitForm = _previousFormType switch
            {
                MainFormType.NewVisit => _previousForm as NewVisitForm ?? throw new InvalidOperationException("_previousForm is not a NewVisitForm"),
                _ => throw new NotImplementedException(),
            };
            _newVisitForm.NewPatientButtonClicked += LoadMainForm;
            _activeMainForm = (MainFormType)_previousFormType;
            InitializeForm(_previousForm, FormType.MainForm);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            moveX = e.X;
            moveY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(move==1)
            {
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }
    }
}
