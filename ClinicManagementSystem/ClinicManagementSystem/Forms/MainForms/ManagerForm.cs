using ClinicManagementSystem.Entities.Models;
using ClinicManagementSystem.Entities.Enums;
using ClinicManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Data.Entity.Validation;

namespace ClinicManagementSystem.Forms.MainForms
{
    public partial class ManagerForm : Form
    {
        private MainFormType _formType;
        private IPatientService _patientService;
        private IDoctorService _doctorService;
        private IReceptionistService _receptionistService;
        private ILaboratoryTechnicianService _technicianService;
        private ILaboratoryManagerService _managerService;
        private List<(Specialization, string)> _specialization;

        public ManagerForm(MainFormType formType, IPatientService patientService, IDoctorService doctorService, IReceptionistService receptionistService, ILaboratoryTechnicianService technicianService, ILaboratoryManagerService managerService)
        {
            
            this._formType = formType;
            InitializeComponent();
            InitializeSpecializationCombobox();
            SetSearchOnEnterClick();
            ShowCorrectElements();
            _patientService = patientService;
            _doctorService = doctorService;
            _receptionistService = receptionistService;
            _technicianService = technicianService;
            _managerService = managerService;
        }

        private void InitializeSpecializationCombobox()
        {
            _specialization = new List<(Specialization, string)>
            {
                (Specialization.None, "<Select Specialization>"),
                (Specialization.Internist, "Internist"),
                (Specialization.Radiologist, "Radiologist"),
                (Specialization.Neurologist, "Neurologist"),
                (Specialization.Gynecologist, "Gynecologist"),
                (Specialization.Anesthesiologist, "Anesthesiologist"),
                (Specialization.Pediatrician, "Pediatrician"),
                (Specialization.EmergencyPhysician, "Emergency Physician")
            };

            _specialization.ForEach(((Specialization, string) tuple) => {
                SpecializationComboBox.Items.Add(tuple.Item2);
            });
            SpecializationComboBox.SelectedIndex = 0;
        }
        private void SetSearchOnEnterClick()
        {
            SearchUserTextBox.KeyDown += (sender, args) =>
            { // search on enter click
                if (args.KeyCode == Keys.Enter || args.KeyCode == Keys.Return)
                    SearchUserButton_Click(sender, args);
            };
        }
        private void HidePesel()
        {
            PESELOrLicenseNumberTextBox.Hide();
            labelPesel.Hide();
        }

        private void HideBtns()
        {
            UpdateButton.Hide();
            DeleteButton.Hide();
        }

        private void HideForDoctor()
        {
            LabTechicianRadioButton.Hide();
            LabManagerRadioButton.Hide();
        }

        private void HideForLab()
        {
            DoctoralLabel.Hide();
            SpecializationComboBox.Hide();
        }


        private void HidePassword()
        {
            PasswordLabel.Hide();
            PasswordTextBox.Hide();
        }

        private void Receptionist()
        {
            HidePesel();
            HideForLab();
            HideForDoctor();
            HideBtns();
            SetUserCategories("Receptionist");
        }

        private void Doctor()
        {
            this.PESELOrLicenseNumberTextBox.PlaceholderText = "License Number";
            this.labelPesel.Text = "Licence Number";
            HideForDoctor();
            HideBtns();
            SetUserCategories("Doctor");
        }

        private void Lab()
        {
            HidePesel();
            HideForLab();
            HideBtns();
            SetUserCategories("Lab Worker");
        }

        private void Patient()
        {
            HidePassword();
            HideForDoctor();
            HideForLab();
            HideBtns();
            SetUserCategories("Patient");
        }

        private void SetUserCategories(string user)
        {
            SearchUserTextBox.PlaceholderText = "Search " + user + " for Update";
            PasswordTextBox.PlaceholderText = user + "'s Password";
            AddButton.Text = "Add " + user;
            UpdateButton.Text = "Update " + user;
            DeleteButton.Text = "Delete " + user;
        }

        private void ShowCorrectElements()
        {
            switch (_formType)
            {
                case MainFormType.ManagerDoctors:
                    Doctor();
                    break;
                case MainFormType.ManagerLaboratory:
                    Lab();
                    break;
                case MainFormType.ManagerReceptionist:
                    Receptionist();
                    break;
                case MainFormType.ManagerPatients:
                    Patient();
                    break;
                default:
                    break;
            }
        }

        private void SearchUserButton_Click(object sender, EventArgs e)
        {
            if (SearchUserTextBox.Text != "")
            {
                string[] name = SearchUserTextBox.Text.Split(' ');
                if(name.Length > 1)
                {

                    switch (_formType)
                    {
                        case MainFormType.ManagerDoctors:
                            FindDoctor(name);
                            break;
                        case MainFormType.ManagerLaboratory:
                            FindLab(name);
                            break;
                        case MainFormType.ManagerReceptionist:
                            FindReceptionist(name);
                            break;
                        case MainFormType.ManagerPatients:
                            FindPatient(name);
                            break;
                        default:
                            break;
                    }
                  
                }
              }
        }

        

        private void FindDoctor(string[] name)
        {
            Doctor doctor = _doctorService.GetDoctorByName(name[0], name[1]);
            if(doctor != null)
            {
                SearchUserTextBox.Clear();
                UpdateButton.Show();
                DeleteButton.Show();
                PESELOrLicenseNumberTextBox.Text = doctor.LicenseNumber;
                PhoneTextBox.Text = doctor.PhoneNumber;
                UserNameTextBox.Text = doctor.FirstName;
                UserSurnameTextBox.Text = doctor.LastName;
                EMailTextBox.Text = doctor.Email;
                PasswordTextBox.Text = ""; // todo from auth services; PR: chyba nie chcecie pokazywac hasla uzytkownika... poza tym sa w postaci hasha i nie da sie ich odczytac

                if (doctor.Address != null)
                {
                    CityTextBox.Text = doctor.Address.City;
                    StreetTextBox.Text = doctor.Address.Street;
                    ZIPCodeTextBox.Text = doctor.Address.ZipCode;
                    NumberTextBox.Text = doctor.Address.HomeNumber;
                }
            }       
        }
        private void FindLab(string[] name)
        {
            if (!LabManagerRadioButton.Checked && !LabTechicianRadioButton.Checked)
            {
                MessageBox.Show("Select the type of worker!", "Find Laboratory Worker");
            }
            else
            {
                if (LabManagerRadioButton.Checked)
                {
                    FindLaboratoryManager(name);
                }
                else if (LabTechicianRadioButton.Checked)
                {
                    FindLaboratoryTechnician(name);
                }
            }
        }

        private void FindReceptionist(string[] name)
        {
            Receptionist receptionist = _receptionistService.GetReceptionistByName(name[0], name[1]);
            if(receptionist != null)
            {
                SearchUserTextBox.Clear();
                UpdateButton.Show();
                DeleteButton.Show();
                PhoneTextBox.Text = receptionist.PhoneNumber;
                UserNameTextBox.Text = receptionist.FirstName;
                UserSurnameTextBox.Text = receptionist.LastName;
                EMailTextBox.Text = receptionist.Email;
                PasswordTextBox.Text = ""; // todo from auth service; PR: chyba nie chcecie pokazywac hasla uzytkownika... poza tym sa w postaci hasha i nie da sie ich odczytac

                if (receptionist.Address != null)
                {
                    CityTextBox.Text = receptionist.Address.City;
                    StreetTextBox.Text = receptionist.Address.Street;
                    ZIPCodeTextBox.Text = receptionist.Address.ZipCode;
                    NumberTextBox.Text = receptionist.Address.HomeNumber;
                }               
                
            }    
        }
        private void FindPatient(string[] name)
        {
            Patient patient = _patientService.GetPatientByName(name[0], name[1]);
            if(patient != null)
            {
                SearchUserTextBox.Clear();
                UpdateButton.Show();
                DeleteButton.Show();
                PESELOrLicenseNumberTextBox.Text = patient.PersonalIdentityNumber;
                PhoneTextBox.Text = patient.PhoneNumber;
                UserNameTextBox.Text = patient.FirstName;
                UserSurnameTextBox.Text = patient.LastName;
                EMailTextBox.Text = patient.Email;
                PasswordTextBox.Text = ""; // todo from auth services; PR: chyba nie chcecie pokazywac hasla uzytkownika... poza tym sa w postaci hasha i nie da sie ich odczytac

                if (patient.Address != null)
                {
                    CityTextBox.Text = patient.Address.City;
                    StreetTextBox.Text = patient.Address.Street;
                    ZIPCodeTextBox.Text = patient.Address.ZipCode;
                    NumberTextBox.Text = patient.Address.HomeNumber;
                }
            }           
        }

        private void FindLaboratoryManager(string[] name)
        {
            LaboratoryManager laboratoryManager = _managerService.GetLaboratoryManagerByName(name[0], name[1]);
            if (laboratoryManager != null)
            {
                SearchUserTextBox.Clear();
                UpdateButton.Show();
                DeleteButton.Show();
                PhoneTextBox.Text = laboratoryManager.PhoneNumber;
                UserNameTextBox.Text = laboratoryManager.FirstName;
                UserSurnameTextBox.Text = laboratoryManager.LastName;
                EMailTextBox.Text = laboratoryManager.Email;
                PasswordTextBox.Text = ""; // todo from auth services; PR: chyba nie chcecie pokazywac hasla uzytkownika... poza tym sa w postaci hasha i nie da sie ich odczytac

                if (laboratoryManager.Address != null)
                {
                    CityTextBox.Text = laboratoryManager.Address.City;
                    StreetTextBox.Text = laboratoryManager.Address.Street;
                    ZIPCodeTextBox.Text = laboratoryManager.Address.ZipCode;
                    NumberTextBox.Text = laboratoryManager.Address.HomeNumber;
                }
            }
        }

        private void FindLaboratoryTechnician(string[] name)
        {
            LaboratoryTechnician laboratoryTechnician = _technicianService.GetLaboratoryTechnicianByName(name[0], name[1]);
            if (laboratoryTechnician != null)
            {
                SearchUserTextBox.Clear();
                UpdateButton.Show();
                DeleteButton.Show();
                PhoneTextBox.Text = laboratoryTechnician.PhoneNumber;
                UserNameTextBox.Text = laboratoryTechnician.FirstName;
                UserSurnameTextBox.Text = laboratoryTechnician.LastName;
                EMailTextBox.Text = laboratoryTechnician.Email;
                PasswordTextBox.Text = ""; // todo from auth services; PR: chyba nie chcecie pokazywac hasla uzytkownika... poza tym sa w postaci hasha i nie da sie ich odczytac

                if (laboratoryTechnician.Address != null)
                {
                    CityTextBox.Text = laboratoryTechnician.Address.City;
                    StreetTextBox.Text = laboratoryTechnician.Address.Street;
                    ZIPCodeTextBox.Text = laboratoryTechnician.Address.ZipCode;
                    NumberTextBox.Text = laboratoryTechnician.Address.HomeNumber;
                }
            }
        }

        private void ClearData()
        {
            PESELOrLicenseNumberTextBox.Clear();
            PhoneTextBox.Clear();
            UserNameTextBox.Clear();
            UserSurnameTextBox.Clear();
            CityTextBox.Clear();
            StreetTextBox.Clear();
            ZIPCodeTextBox.Clear();
            NumberTextBox.Clear();
            EMailTextBox.Clear();
            PasswordTextBox.Clear();
            SpecializationComboBox.SelectedIndex = 0;
            LabManagerRadioButton.Checked = false;
            LabTechicianRadioButton.Checked = false;
        }

        

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            switch (_formType)
            {
                case MainFormType.ManagerPatients:
                    //DeletePatient();
                    break;
                case MainFormType.ManagerDoctors:
                    //DeleteDoctor();
                    break;
                case MainFormType.ManagerLaboratory:
                    //DeleteLaboratoryWorker();
                    break;
                case MainFormType.ManagerReceptionist:
                    //DeleteReceptionist();
                    break;
                default:
                    break;
            }
        }

        
        

    } 
}
