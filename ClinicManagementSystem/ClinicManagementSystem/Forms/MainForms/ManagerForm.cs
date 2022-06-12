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
using Microsoft.EntityFrameworkCore;

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
            PESELTextBox.Hide();
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


        private void HideLogin()
        {
            LoginLabel.Hide();
            LoginTextBox.Hide();
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
            this.PESELTextBox.PlaceholderText = "Licence Number";
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
            HideLogin();
            HideForDoctor();
            HideForLab();
            HideBtns();
            SetUserCategories("Patient");
        }

        private void SetUserCategories(string user)
        {
            SearchUserTextBox.PlaceholderText = "Search " + user + " for Update";
            LoginTextBox.PlaceholderText = user + "'s Login";
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
                PESELTextBox.Text = doctor.LicenseNumber; // TODO change label to license nr
                PhoneTextBox.Text = doctor.PhoneNumber;
                UserNameTextBox.Text = doctor.FirstName;
                UserSurnameTextBox.Text = doctor.LastName;
                EMailTextBox.Text = doctor.Email;
                PasswordTextBox.Text = ""; // todo from auth services

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
                PasswordTextBox.Text = ""; // todo from auth service

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
                PESELTextBox.Text = patient.PersonalIdentityNumber;
                PhoneTextBox.Text = patient.PhoneNumber;
                UserNameTextBox.Text = patient.FirstName;
                UserSurnameTextBox.Text = patient.LastName;
                EMailTextBox.Text = patient.Email;
                PasswordTextBox.Text = ""; // todo from auth services

                if(patient.Address != null)
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
                PasswordTextBox.Text = ""; // todo from auth services

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
                PasswordTextBox.Text = ""; // todo from auth services

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
            PESELTextBox.Clear();
            PhoneTextBox.Clear();
            UserNameTextBox.Clear();
            UserSurnameTextBox.Clear();
            CityTextBox.Clear();
            StreetTextBox.Clear();
            ZIPCodeTextBox.Clear();
            NumberTextBox.Clear();
            EMailTextBox.Clear();
            PasswordTextBox.Clear();
            LoginTextBox.Clear();
            SpecializationComboBox.SelectedIndex = 0;
            LabManagerRadioButton.Checked = false;
            LabTechicianRadioButton.Checked = false;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            switch (_formType)
            {
                case MainFormType.ManagerPatients:
                    UpdatePatient();
                    break;
                case MainFormType.ManagerDoctors:
                    UpdateDoctor();
                    break;
                case MainFormType.ManagerLaboratory:
                    UpdateLaboratoryWorker();
                    break;
                case MainFormType.ManagerReceptionist:
                    UpdateReceptionist();
                    break;
                default:
                    break;
            }
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            switch (_formType)
            {
                case MainFormType.ManagerPatients:
                    AddPatient();
                    break;
                case MainFormType.ManagerDoctors:
                    AddDoctor();
                    break;
                case MainFormType.ManagerLaboratory:
                    AddLaboratoryWorker();
                    break;
                case MainFormType.ManagerReceptionist:
                    AddReceptionist();
                    break;
                default:
                    break;
            }
        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {

        }
        private void UpdateDoctor()
        {
            Doctor doctorToUpdate = _doctorService.GetDoctorByLicenceNumber(PESELTextBox.Text);

            Specialization spec = _specialization.Find(x => x.Item2 == SpecializationComboBox.SelectedItem.ToString()).Item1;
            if (spec == Specialization.None || PasswordTextBox.Text == "" || LoginTextBox.Text == "")
            {
                MessageBox.Show("Complete the missing data!", "Update Doctor Data");
            }
            else
            {
                doctorToUpdate.Address.City = CityTextBox.Text;
                doctorToUpdate.Address.Street = StreetTextBox.Text;
                doctorToUpdate.Address.HomeNumber = NumberTextBox.Text;
                doctorToUpdate.Address.ZipCode = ZIPCodeTextBox.Text;
                doctorToUpdate.PhoneNumber = PhoneTextBox.Text;
                doctorToUpdate.FirstName = UserNameTextBox.Text;
                doctorToUpdate.LastName = UserSurnameTextBox.Text;
                doctorToUpdate.Email = EMailTextBox.Text;
                doctorToUpdate.Specialization = spec;

                _doctorService.UpdateDoctor(doctorToUpdate, PasswordTextBox.Text);
                MessageBox.Show("Doctor data has been succesfully updated.", "Update Doctor Data");
                ClearData();
            }
        }

        private void UpdateReceptionist()
        {
            Receptionist receptionistToUpdate = _receptionistService.GetReceptionistByName(UserNameTextBox.Text, UserSurnameTextBox.Text);

            if ( PasswordTextBox.Text == "" || LoginTextBox.Text == "")
            {
                MessageBox.Show("Complete the missing data!", "Update Receptionist Data");
            }
            else
            {
                receptionistToUpdate.Address.City = CityTextBox.Text;
                receptionistToUpdate.Address.Street = StreetTextBox.Text;
                receptionistToUpdate.Address.HomeNumber = NumberTextBox.Text;
                receptionistToUpdate.Address.ZipCode = ZIPCodeTextBox.Text;
                receptionistToUpdate.PhoneNumber = PhoneTextBox.Text;
                receptionistToUpdate.FirstName = UserNameTextBox.Text;
                receptionistToUpdate.LastName = UserSurnameTextBox.Text;
                receptionistToUpdate.Email = EMailTextBox.Text;

                _receptionistService.UpdateReceptionist(receptionistToUpdate, PasswordTextBox.Text);
                MessageBox.Show("Receptionist data has been succesfully updated.", "Update Receptionist Data");
                ClearData();
            }
        }

        private void UpdateLaboratoryWorker()
        {
            if (!LabManagerRadioButton.Checked && !LabTechicianRadioButton.Checked)
            {
                MessageBox.Show("Select the type of worker!", "Update Laboratory Worker");
            }
            else
            {
                if (LabManagerRadioButton.Checked)
                {
                    UpdateLaboratoryManager();
                }
                else if (LabTechicianRadioButton.Checked)
                {
                    UpdateLaboratoryTechnician();
                }
            }
        }

        private void UpdateLaboratoryManager()
        {
            LaboratoryManager managerToUpdate = _managerService.GetLaboratoryManagerByName(UserNameTextBox.Text, UserSurnameTextBox.Text);

            if (PasswordTextBox.Text == "" || LoginTextBox.Text == "")
            {
                MessageBox.Show("Complete the missing data!", "Update Laboratory Manager");
            }
            else
            {
                managerToUpdate.Address.City = CityTextBox.Text;
                managerToUpdate.Address.Street = StreetTextBox.Text;
                managerToUpdate.Address.HomeNumber = NumberTextBox.Text;
                managerToUpdate.Address.ZipCode = ZIPCodeTextBox.Text;
                managerToUpdate.PhoneNumber = PhoneTextBox.Text;
                managerToUpdate.FirstName = UserNameTextBox.Text;
                managerToUpdate.LastName = UserSurnameTextBox.Text;
                managerToUpdate.Email = EMailTextBox.Text;

                _managerService.UpdateLaboratoryManager(managerToUpdate, PasswordTextBox.Text);
                MessageBox.Show("Laboratory manager data has been succesfully updated.", "Update Laboratory Manager");
                ClearData();
            }
        }

        private void UpdateLaboratoryTechnician()
        {
            LaboratoryTechnician technicianToUpdate = _technicianService.GetLaboratoryTechnicianByName(UserNameTextBox.Text, UserSurnameTextBox.Text);

            if (PasswordTextBox.Text == "" || LoginTextBox.Text == "")
            {
                MessageBox.Show("Complete the missing data!", "Update Laboratory Technician");
            }
            else
            {
                technicianToUpdate.Address.City = CityTextBox.Text;
                technicianToUpdate.Address.Street = StreetTextBox.Text;
                technicianToUpdate.Address.HomeNumber = NumberTextBox.Text;
                technicianToUpdate.Address.ZipCode = ZIPCodeTextBox.Text;
                technicianToUpdate.PhoneNumber = PhoneTextBox.Text;
                technicianToUpdate.FirstName = UserNameTextBox.Text;
                technicianToUpdate.LastName = UserSurnameTextBox.Text;
                technicianToUpdate.Email = EMailTextBox.Text;

                _technicianService.UpdateLaboratoryTechnician(technicianToUpdate, PasswordTextBox.Text);
                MessageBox.Show("Laboratory manager data has been succesfully updated.", "Update Laboratory Manager");
                ClearData();
            }
        }

        private void UpdatePatient()
        {
            Patient patientToUpdate = _patientService.GetPatientByPersonalIdentityNumber(PESELTextBox.Text);

            if(PESELTextBox.Text == "")
            {
                MessageBox.Show("Complete the missing data!", "Update Patient Data");
            }
            else
            {
                patientToUpdate.Address.City = CityTextBox.Text;
                patientToUpdate.Address.Street = StreetTextBox.Text;
                patientToUpdate.Address.HomeNumber = NumberTextBox.Text;
                patientToUpdate.Address.ZipCode = ZIPCodeTextBox.Text;
                patientToUpdate.PhoneNumber = PhoneTextBox.Text;
                patientToUpdate.FirstName = UserNameTextBox.Text;
                patientToUpdate.LastName = UserSurnameTextBox.Text;
                patientToUpdate.Email = EMailTextBox.Text;

                try
                {
                    _patientService.UpdatePatient(patientToUpdate);
                    MessageBox.Show("Patient data has been succesfully updated.", "Update Patient Data");
                    ClearData();
                }
                catch (DbUpdateException)
                {
                    MessageBox.Show("Update data error.", "Update Patient Data");
                }
            }
   
        }

        private void AddDoctor()
        {
            Doctor existingDoctor = _doctorService.GetDoctorByLicenceNumber(PESELTextBox.Text);  //zmienic nazwe na licence number
            if(existingDoctor == null)
            {
                Specialization spec = _specialization.Find(x => x.Item2 == SpecializationComboBox.SelectedItem.ToString()).Item1;
                if (spec == Specialization.None || PasswordTextBox.Text == "" || LoginTextBox.Text == "" || PESELTextBox.Text == "")
                {
                    MessageBox.Show("Complete the missing data!", "Add New Doctor");
                }
                else
                {
                    Address newAddress = new Address
                    {
                        City = CityTextBox.Text,
                        Street = StreetTextBox.Text,
                        HomeNumber = NumberTextBox.Text,
                        ZipCode = ZIPCodeTextBox.Text
                    };
                    Doctor newDoctor = new Doctor
                    {
                        LicenseNumber = PESELTextBox.Text,
                        PhoneNumber = PhoneTextBox.Text,
                        FirstName = UserNameTextBox.Text,
                        LastName = UserSurnameTextBox.Text,
                        Email = EMailTextBox.Text,
                        Specialization = spec,
                        Address = newAddress
                    };
                    try
                    {
                        _doctorService.InsertDoctor(newDoctor, PasswordTextBox.Text);
                        MessageBox.Show("New doctor has been succesfully added.", "Add New Doctor");
                    }
                    catch (DbUpdateException)
                    {
                        MessageBox.Show("Insert error.", "Add New Doctor");
                    }
                    ClearData();
                }
            }
            else
            {
                MessageBox.Show("Doctor already exists.", "Add New Doctor");
            }
           
        }

        private void AddReceptionist()
        {
            Receptionist existingReceptionist = _receptionistService.GetReceptionistByName(UserNameTextBox.Text, UserSurnameTextBox.Text);
            
            if (existingReceptionist == null)
            {
                if (PasswordTextBox.Text == "" || LoginTextBox.Text == "")
                {
                    MessageBox.Show("Complete the missing data!", "Add New Receptionist");
                }
                else
                {
                    Address newAddress = new Address
                    {
                        City = CityTextBox.Text,
                        Street = StreetTextBox.Text,
                        HomeNumber = NumberTextBox.Text,
                        ZipCode = ZIPCodeTextBox.Text
                    };
                    Receptionist newReceptionist = new Receptionist
                    {
                        PhoneNumber = PhoneTextBox.Text,
                        FirstName = UserNameTextBox.Text,
                        LastName = UserSurnameTextBox.Text,
                        Email = EMailTextBox.Text,
                        Address = newAddress
                    };
                    try
                    {
                        _receptionistService.InsertReceptionist(newReceptionist, PasswordTextBox.Text);
                        MessageBox.Show("New receptionist has been succesfully added.", "Add New Receptionist");
                    }
                    catch (DbUpdateException)
                    {
                        MessageBox.Show("Insert error.", "Add New Receptionist");
                    }
                    ClearData();
                }
            }
            else
            {
                MessageBox.Show("Receptionists already exists.", "Add New Receptionist");
            }        
        }

        private void AddLaboratoryWorker()
        {
            if (PasswordTextBox.Text == "" || LoginTextBox.Text == "" || (!LabManagerRadioButton.Checked && !LabTechicianRadioButton.Checked) || CheckEmptyInputs())
            {
                MessageBox.Show("Complete the missing data!", "Add New Laboratory Worker");
            }
            else
            {
                if (LabManagerRadioButton.Checked)
                {
                    AddLaboratoryManager();
                }
                else if (LabTechicianRadioButton.Checked)
                {
                    AddLaboratoryTechnician();
                }
            }
        }

        private void AddLaboratoryTechnician()
        {
            LaboratoryTechnician existingTechnician = _technicianService.GetLaboratoryTechnicianByName(UserNameTextBox.Text, UserSurnameTextBox.Text);

            if(existingTechnician == null)
            {
                Address newAddress = new Address
                {
                    City = CityTextBox.Text,
                    Street = StreetTextBox.Text,
                    HomeNumber = NumberTextBox.Text,
                    ZipCode = ZIPCodeTextBox.Text
                };
                LaboratoryTechnician newLaboratoryTechnician = new LaboratoryTechnician
                {
                    PhoneNumber = PhoneTextBox.Text,
                    FirstName = UserNameTextBox.Text,
                    LastName = UserSurnameTextBox.Text,
                    Email = EMailTextBox.Text,
                    Address = newAddress
                };
                try
                {
                    _technicianService.InsertLaboratoryTechnician(newLaboratoryTechnician, PasswordTextBox.Text);
                    MessageBox.Show("New laboratory technician has been succesfully added.", "Add New Laboratory Technician");
                }
                catch (DbUpdateException)
                {
                    MessageBox.Show("Insert error.", "Add New Laboratory Technician");
                }
                ClearData();
            }
            else
            {
                MessageBox.Show("Laboratory Technician already exists.", "Add New Laboratory Technician");
            }
            
        }

        private void AddLaboratoryManager()
        {
            LaboratoryManager existingManager = _managerService.GetLaboratoryManagerByName(UserNameTextBox.Text, UserSurnameTextBox.Text);
              
            if(existingManager == null)
            {
                Address newAddress = new Address
                {
                    City = CityTextBox.Text,
                    Street = StreetTextBox.Text,
                    HomeNumber = NumberTextBox.Text,
                    ZipCode = ZIPCodeTextBox.Text
                };
                LaboratoryManager newLaboratoryManager = new LaboratoryManager
                {
                    PhoneNumber = PhoneTextBox.Text,
                    FirstName = UserNameTextBox.Text,
                    LastName = UserSurnameTextBox.Text,
                    Email = EMailTextBox.Text,
                    Address = newAddress
                };
                try
                {
                    _managerService.InsertLaboratoryManager(newLaboratoryManager, PasswordTextBox.Text);
                    MessageBox.Show("New laboratory manager has been succesfully added.", "Add New Laboratory Manager");
                }
                catch (DbUpdateException)
                {
                    MessageBox.Show("Insert error.", "Add New Laboratory Manager");
                }
                ClearData();
            }
            else
            {
                MessageBox.Show("Laboratory Manager already exists.", "Add New Laboratory Manager");
            }           
        }

        private void AddPatient()
        {
            Patient existingPatient = _patientService.GetPatientByPersonalIdentityNumber(PESELTextBox.Text);

            if(existingPatient ==null)
            {
                if (PESELTextBox.Text == "")
                {
                    Address newAddress = new Address
                    {
                        City = CityTextBox.Text,
                        Street = StreetTextBox.Text,
                        HomeNumber = NumberTextBox.Text,
                        ZipCode = ZIPCodeTextBox.Text
                    };
                    Patient newPatient = new Patient
                    {
                        PersonalIdentityNumber = PESELTextBox.Text,
                        PhoneNumber = PhoneTextBox.Text,
                        FirstName = UserNameTextBox.Text,
                        LastName = UserSurnameTextBox.Text,
                        Email = EMailTextBox.Text,
                        Address = newAddress
                    };
                    try
                    {
                        _patientService.InsertPatient(newPatient);
                        MessageBox.Show("New patient has been succesfully added.", "Add New Patient");
                    }
                    catch (DbUpdateException)
                    {
                        MessageBox.Show("Insert error.", "Add New Patient");
                    }
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Complete the missing data!", "Add New Patient");
                }
            }
            else
            {
                MessageBox.Show("Patient already exists.", "Add New Patient");
            }         
        }
        private bool CheckEmptyInputs()
        {
            if (CityTextBox.Text == "" || StreetTextBox.Text == "" || NumberTextBox.Text == "" || ZIPCodeTextBox.Text == ""  
                || PhoneTextBox.Text == "" || EMailTextBox.Text == "" || UserNameTextBox.Text == "" || UserSurnameTextBox.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }  
        }
    } 
}
