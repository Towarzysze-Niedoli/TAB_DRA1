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

namespace ClinicManagementSystem.Forms.MainForms
{
    public partial class MainWindow : Form
    {
        private LaboratoryForm _laboratoryForm;
        private ManagerForm _managerForm;
        private VisitsMainForm _visitsMainForm;
        private NewVisitForm _newVisitForm;
        private PerformVisitForm _performVisitForm;

        private LoginForm _loginForm;
        private SideMenu _sideMenuForm;

        private UserLevel _level;

        private MainFormType _activeMainForm;
        public MainWindow(UserLevel level)
        {
            _level = level;
            _activeMainForm = MainFormType.Main;
            InitializeComponent();
            ShowLoginForm();
            this.LogoutButton.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowLoginForm()
        {
            _loginForm = new LoginForm();
            _loginForm.ButtonClicked += LoginButtonClicked;
            InitializeForm(_loginForm, FormType.SideForm);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            UnloadMainForm();
            _activeMainForm = MainFormType.Main;
            if(_sideMenuForm!=null)
            {
                _sideMenuForm.ButtonClicked -= LoadMainForm;
            }
            this.LogoBox.Show();
            this.LogoText.Show();
            this.LogoutButton.Hide();
            this.SideUpperPanel.Controls.Remove(_loginForm);
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
            _visitsMainForm = new VisitsMainForm(_level);
            _visitsMainForm.ButtonClicked += LoadMainForm;
            _activeMainForm = MainFormType.VisitMainForm;
            InitializeForm(_visitsMainForm, FormType.MainForm);
        }

        private void ShowPerformVisitForm()
        {
            UnloadMainForm();
            _performVisitForm = new PerformVisitForm();
            _activeMainForm = MainFormType.PerformVisit;
            InitializeForm(_performVisitForm, FormType.MainForm);
        }

        private void ShowLaboratoryForm()
        {
            UnloadMainForm();
            _laboratoryForm = new LaboratoryForm();
            _activeMainForm = MainFormType.Laboratory;
            InitializeForm(_laboratoryForm, FormType.MainForm);
        }

        private void ShowNewVisitForm()
        {
            UnloadMainForm();
            _newVisitForm = new NewVisitForm();
            _activeMainForm = MainFormType.NewVisit;
            InitializeForm(_newVisitForm, FormType.MainForm);
        }


        private void ShowManagerDoctorForm()
        {
            UnloadMainForm();
            _managerForm = new ManagerForm(1);
            _activeMainForm = MainFormType.ManagerDoctors;
            InitializeForm(_managerForm, FormType.MainForm);
        }

        private void ShowManagerPatientForm()
        {
            UnloadMainForm();
            _managerForm = new ManagerForm(0);
            _activeMainForm = MainFormType.ManagerPatients;
            InitializeForm(_managerForm, FormType.MainForm);
        }

        private void ShowManagerLabForm()
        {
            UnloadMainForm();
            _managerForm = new ManagerForm(2);
            _activeMainForm = MainFormType.ManagerLaboratory;
            InitializeForm(_managerForm, FormType.MainForm);
        }

        private void ShowReceptionistForm()
        {
            UnloadMainForm();
            _managerForm = new ManagerForm(3);
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
            if (args.UserLevel == UserLevel.Manager)
            {
                if (args.WindowType == MainFormType.ManagerLaboratory)
                {
                    ShowManagerLabForm();
                }
                else if (args.WindowType == MainFormType.ManagerDoctors)
                {
                    ShowManagerDoctorForm();
                }
                else if (args.WindowType == MainFormType.ManagerReceptionist)
                {
                    ShowReceptionistForm();
                }
                else
                {
                    ShowManagerPatientForm();
                }
            }
            else if (args.UserLevel == UserLevel.Doctor)
            {
                if (args.WindowType == MainFormType.VisitMainForm)
                {
                    ShowVisitMainForm();
                }
                else if (args.WindowType == MainFormType.PerformVisit)
                {
                    ShowPerformVisitForm();
                }
            }
            else if (args.UserLevel == UserLevel.HeadOfLab)
            {
                if (args.WindowType == MainFormType.Laboratory)
                {
                    ShowLaboratoryForm();
                }
            }
            else if (args.UserLevel == UserLevel.Laborant)//these two are gonna need some work because we dont differentiate between form modes
            {
                if (args.WindowType == MainFormType.Laboratory)
                {
                    ShowLaboratoryForm();
                }
            }
            else if(args.UserLevel==UserLevel.Receptionist)
            {
                if (args.WindowType == MainFormType.VisitMainForm)
                {
                    ShowVisitMainForm();
                }
                else if(args.WindowType == MainFormType.ManagerPatients)
                {
                    ShowManagerPatientForm();
                }
                else if(args.WindowType == MainFormType.NewVisit)
                {
                    ShowNewVisitForm();
                }
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
                    _newVisitForm.Hide();
                    break;
                case MainFormType.PerformVisit:
                    this.MainPanel.Controls.Remove(_performVisitForm);
                    _performVisitForm.Hide();
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
    }
}
