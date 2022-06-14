using ClinicManagementSystem.Entities.Enums;
using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClinicManagementSystem.Forms.MainForms
{
    partial class ManagerForm
    {
        private void AddButton_Click(object sender, EventArgs e)
        {
            switch (_formType)
            {
                case MainFormType.ManagerPatients:
                    this.AddPatient();
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

        private bool ValidatePassword(out string password, out ICollection<ValidationResult> results)
        {
            password = PasswordTextBox.Text;
            ValidationContext context = new ValidationContext(new ApplicationUser()) { MemberName = "Password" };
            results = new List<ValidationResult>();
            return Validator.TryValidateProperty(password, context, results);
        }

        private bool ValidateObject(object obj, out ICollection<ValidationResult> results)
        {
            results = new List<ValidationResult>();
            return Validator.TryValidateObject(obj, new ValidationContext(obj), results, true);
        }

        private bool EmailOrPhoneExists(out string email, out string phoneNumber)
        {
            email = string.IsNullOrWhiteSpace(EMailTextBox.Text) ? null : EMailTextBox.Text;
            phoneNumber = string.IsNullOrWhiteSpace(PhoneTextBox.Text) ? null : PhoneTextBox.Text;
            return email != null || phoneNumber != null;
        }

        private void AddPatient()
        {
            ICollection<ValidationResult> results = ValidateAddress(out Address newAddress);
            if (results != null)
            {
                MessageBox.Show(string.Join('\n', results.Select(r => r.ErrorMessage)), "Validation error");
                return;
            }

            Patient existingPatient = _patientService.GetPatientByPersonalIdentityNumber(PESELOrLicenseNumberTextBox.Text);
            if (existingPatient != null)
            {
                MessageBox.Show("Patient already exists.", "Add New Patient");
                return;
            }

            Patient newPatient = new Patient()
            {
                Address = newAddress,
                FirstName = UserNameTextBox.Text,
                LastName = UserSurnameTextBox.Text,
                PersonalIdentityNumber = PESELOrLicenseNumberTextBox.Text,
                Email = string.IsNullOrWhiteSpace(EMailTextBox.Text) ? null : EMailTextBox.Text,
                PhoneNumber = string.IsNullOrWhiteSpace(PhoneTextBox.Text) ? null : PhoneTextBox.Text
            };

            if (!ValidateObject(newPatient, out results))
            {
                // obj not valid
                MessageBox.Show(string.Join('\n', results.Select(r => r.ErrorMessage)), "Validation error");
                return;
            }

            try
            {
                _patientService.InsertPatient(newPatient);
                MessageBox.Show("New patient has been succesfully added.", "Add New Patient");
            }
            catch (Exception e) // TODO change ?
            {
                MessageBox.Show("Insert error: " + e.Message, "Add New Patient");
            }
            ClearData();
        }

        private void AddDoctor()
        {
            ICollection<ValidationResult> results = ValidateAddress(out Address newAddress);
            if (results != null)
            {
                MessageBox.Show(string.Join('\n', results.Select(r => r.ErrorMessage)), "Validation error");
                return;
            }

            Specialization spec = _specialization.Find(x => x.Item2 == SpecializationComboBox.SelectedItem.ToString()).Item1;
            if (spec == Specialization.None)
            {
                MessageBox.Show("Select specialization", "Add New Doctor");
                return;
            }

            if (!EmailOrPhoneExists(out string email, out string phone))
            {
                MessageBox.Show("Email address or phone number is required", "Missing field");
                return;
            }

            Doctor newDoctor = new Doctor
            {
                LicenseNumber = PESELOrLicenseNumberTextBox.Text,
                FirstName = UserNameTextBox.Text,
                LastName = UserSurnameTextBox.Text,
                Email = email,
                PhoneNumber = phone,
                Specialization = spec,
                Address = newAddress
            };

            if (!ValidateObject(newDoctor, out results))
            {
                MessageBox.Show(string.Join('\n', results.Select(r => r.ErrorMessage)), "Validation error");
                return;
            }

            if (!ValidatePassword(out string password, out results))
            {
                MessageBox.Show(string.Join('\n', results.Select(r => r.ErrorMessage)), "Validation error");
                return;
            }

            Doctor existingDoctor = _doctorService.GetDoctorByLicenceNumber(PESELOrLicenseNumberTextBox.Text);
            if (existingDoctor != null)
            {
                MessageBox.Show("Doctor already exists.", "Add New Doctor");
                return;
            }

            try
            {
                _doctorService.InsertDoctor(newDoctor, password);
                MessageBox.Show("New doctor has been succesfully added.", "Add New Doctor");
            }
            catch (Exception e) // TODO change ?
            {
                MessageBox.Show("Insert error: " + e.Message, "Add New Doctor");
            }
            ClearData();
        }

        private void AddReceptionist()
        {
            ICollection<ValidationResult> results = ValidateAddress(out Address newAddress);
            if (results != null)
            {
                MessageBox.Show(string.Join('\n', results.Select(r => r.ErrorMessage)), "Validation error");
                return;
            }

            if (!EmailOrPhoneExists(out string email, out string phone))
            {
                MessageBox.Show("Email address or phone number is required", "Missing field");
                return;
            }

            Receptionist newReceptionist = new Receptionist
            {
                FirstName = UserNameTextBox.Text,
                LastName = UserSurnameTextBox.Text,
                Email = email,
                PhoneNumber = phone,
                Address = newAddress
            };

            if (!ValidateObject(newReceptionist, out results))
            {
                MessageBox.Show(string.Join('\n', results.Select(r => r.ErrorMessage)), "Validation error");
                return;
            }

            if (!ValidatePassword(out string password, out results))
            {
                MessageBox.Show(string.Join('\n', results.Select(r => r.ErrorMessage)), "Validation error");
                return;
            }


            Receptionist existingReceptionist = _receptionistService.GetReceptionistByName(UserNameTextBox.Text, UserSurnameTextBox.Text);

            if (existingReceptionist != null)
            {
                MessageBox.Show("Receptionists already exists.", "Add New Receptionist");
                return;
            }

            try
            {
                _receptionistService.InsertReceptionist(newReceptionist, PasswordTextBox.Text);
                MessageBox.Show("New receptionist has been succesfully added.", "Add New Receptionist");
            }
            catch (Exception e) // TODO change ?
            {
                MessageBox.Show("Insert error: " + e.Message, "Add New Receptionist");
            }
            ClearData();
        }

        private void AddLaboratoryWorker()
        {
            ICollection<ValidationResult> results = ValidateAddress(out Address newAddress);
            if (results != null)
            {
                MessageBox.Show(string.Join('\n', results.Select(r => r.ErrorMessage)), "Validation error");
                return;
            }
            if (!ValidatePassword(out string password, out results))
            {
                MessageBox.Show(string.Join('\n', results.Select(r => r.ErrorMessage)), "Validation error");
                return;
            }
            if (!EmailOrPhoneExists(out string email, out string phone))
            {
                MessageBox.Show("Email address or phone number is required", "Missing field");
                return;
            }

            if (LabManagerRadioButton.Checked)
            {
                AddLaboratoryManager(newAddress, password, email, phone);
            }
            else if (LabTechicianRadioButton.Checked)
            {
                AddLaboratoryTechnician(newAddress, password, email, phone);
            }
            else
            {
                MessageBox.Show("Select the type of laboratory worker", "Add New Laboratory Worker");
            }
            
        }

        private void AddLaboratoryTechnician(Address newAddress, string password, string email, string phone)
        {
            LaboratoryTechnician newLaboratoryTechnician = new LaboratoryTechnician
            {
                FirstName = UserNameTextBox.Text,
                LastName = UserSurnameTextBox.Text,
                Email = email,
                PhoneNumber = phone,
                Address = newAddress
            };

            if (!ValidateObject(newLaboratoryTechnician, out ICollection<ValidationResult> results))
            {
                MessageBox.Show(string.Join('\n', results.Select(r => r.ErrorMessage)), "Validation error");
                return;
            }

            LaboratoryTechnician existingTechnician = _technicianService.GetLaboratoryTechnicianByName(UserNameTextBox.Text, UserSurnameTextBox.Text);

            if (existingTechnician != null)
            {
                MessageBox.Show("Laboratory Technician already exists.", "Add New Laboratory Technician");
                return;
            }
            try
            {
                _technicianService.InsertLaboratoryTechnician(newLaboratoryTechnician, PasswordTextBox.Text);
                MessageBox.Show("New laboratory technician has been succesfully added.", "Add New Laboratory Technician");
            }
            catch (Exception e)
            {
                MessageBox.Show("Insert error: " + e.Message, "Add New Laboratory Technician");
            }
            ClearData();

        }

        private void AddLaboratoryManager(Address newAddress, string password, string email, string phone)
        {
            LaboratoryManager newLaboratoryManager = new LaboratoryManager
            {
                FirstName = UserNameTextBox.Text,
                LastName = UserSurnameTextBox.Text,
                Email = email,
                PhoneNumber = phone,
                Address = newAddress
            };

            if (!ValidateObject(newLaboratoryManager, out ICollection<ValidationResult> results))
            {
                MessageBox.Show(string.Join('\n', results.Select(r => r.ErrorMessage)), "Validation error");
                return;
            }

            LaboratoryManager existingManager = _managerService.GetLaboratoryManagerByName(UserNameTextBox.Text, UserSurnameTextBox.Text);

            if (existingManager != null)
            {
                MessageBox.Show("Laboratory Manager already exists.", "Add New Laboratory Manager");
                return;
            }
             
            try
            {
                _managerService.InsertLaboratoryManager(newLaboratoryManager, PasswordTextBox.Text);
                MessageBox.Show("New laboratory manager has been succesfully added.", "Add New Laboratory Manager");
            }
            catch (Exception e) 
            { 
                MessageBox.Show("Insert error: " + e.Message, "Add New Laboratory Manager"); 
            }
            ClearData();
        }

    }
}
