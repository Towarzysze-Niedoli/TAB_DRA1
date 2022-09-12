using ClinicManagementSystem.Entities.Enums;
using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClinicManagementSystem.Forms.MainForms
{
    partial class ManagerForm
    {
        private ICollection<ValidationResult> ValidateAddress(out Address newAddress)
        {
            newAddress = string.IsNullOrWhiteSpace(CityTextBox.Text) ? null : new Address
            {
                City = CityTextBox.Text,
                Street = StreetTextBox.Text,
                HomeNumber = NumberTextBox.Text,
                ZipCode = ZIPCodeTextBox.Text
            };

            ICollection<ValidationResult> validationResults = new List<ValidationResult>();
            if (newAddress != null && !Validator.TryValidateObject(newAddress, new ValidationContext(newAddress), validationResults, true))
            {
                // obj not valid
                return validationResults;
            }
            return null;
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

        private bool ValidatePersonWithAccountCommons(out Address newAddress, out string email, out string phone, out string password, out string[] errors, bool isEditing = false)
        {
            newAddress = null;
            email = null;
            phone = null;
            password = null;

            ICollection<ValidationResult> results = ValidateAddress(out newAddress);
            if (results != null)
            {
                errors = new string[] { string.Join('\n', results.Select(r => r.ErrorMessage)), "Validation error" };
                return false;
            }
            if ((!isEditing || !string.IsNullOrWhiteSpace(PasswordTextBox.Text)) && !ValidatePassword(out password, out results))
            {
                errors = new string[] { string.Join('\n', results.Select(r => r.ErrorMessage)), "Validation error" };
                return false;
            }
            
            if (!EmailOrPhoneExists(out email, out phone))
            {
                errors = new string[] { "Email address or phone number is required", "Missing field" };
                return false;
            }

            errors = null;
            return true;
        }

        // -------------------------------------------------------------------------------------------------

        private bool ValidatePatient(out Patient newPatient, out string[] errors, bool editExisting = false)
        {
            newPatient = null;
            ICollection<ValidationResult> results = ValidateAddress(out Address newAddress);
            if (results != null)
            {
                errors = new string[] { string.Join('\n', results.Select(r => r.ErrorMessage)), "Validation error" };
                return false;
            }

            newPatient = new Patient()
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
                errors = new string[] { string.Join('\n', results.Select(r => r.ErrorMessage)), "Validation error" };
                return false;
            }

            Patient existingPatient = _patientService.GetPatientByPersonalIdentityNumber(PESELOrLicenseNumberTextBox.Text);
            if (editExisting)
            {
                if (existingPatient == null)
                {
                    errors = new string[] { "No patient with given Personal Identity Number found", "Error" };
                    return false;
                }

                existingPatient.Address = newPatient.Address;
                existingPatient.PhoneNumber = newPatient.PhoneNumber;
                existingPatient.FirstName = newPatient.FirstName;
                existingPatient.LastName = newPatient.LastName;
                existingPatient.Email = newPatient.Email;

                newPatient = existingPatient;
            }
            else // !editExisting
            {
                if (existingPatient != null)
                {
                    errors = new string[] { "Patient already exists", "Add New Patient" };
                    return false;
                }
            }

            errors = null;
            return true;
        }

        private bool ValidateDoctor(out Doctor newDoctor, out string[] errors, out string password, bool editExisting = false)
        {
            newDoctor = null;

            // common:
            if (!ValidatePersonWithAccountCommons(out Address newAddress, out string email, out string phone, out password, out errors, editExisting))
                return false;

            // class specific:
            Specialization spec = _specialization.Find(x => x.Item2 == SpecializationComboBox.SelectedItem.ToString()).Item1;
            if (spec == Specialization.None)
            {
                errors = new string[] { "Select specialization", "Add New Doctor" };
                return false;
            }

            // object itself:
            newDoctor = new Doctor
            {
                LicenseNumber = PESELOrLicenseNumberTextBox.Text,
                FirstName = UserNameTextBox.Text,
                LastName = UserSurnameTextBox.Text,
                Email = email,
                PhoneNumber = phone,
                Specialization = spec,
                Address = newAddress
            };

            if (!ValidateObject(newDoctor, out ICollection<ValidationResult> results))
            {
                errors = new string[] { string.Join('\n', results.Select(r => r.ErrorMessage)), "Validation error" };
                return false;
            }

            // return object preparation:
            Doctor existingDoctor = _doctorService.GetDoctorByLicenceNumber(PESELOrLicenseNumberTextBox.Text);
            if (editExisting)
            {
                if (existingDoctor == null)
                {
                    errors = new string[] { "No doctor with given License Number found", "Error" };
                    return false;
                }
                newDoctor.Id = existingDoctor.Id;
            }
            else // !editExisting
            {
                if (existingDoctor != null)
                {
                    errors = new string[] { "Doctor already exists", "Add New Doctor" };
                    return false;
                }
            }

            return true;
        }

        private bool ValidateReceptionist(out Receptionist newReceptionist, out string[] errors, out string password, bool editExisting = false)
        {
            newReceptionist = null;

            // common:
            if (!ValidatePersonWithAccountCommons(out Address newAddress, out string email, out string phone, out password, out errors, editExisting))
                return false;

            // object itself:
            newReceptionist = new Receptionist
            {
                FirstName = UserNameTextBox.Text,
                LastName = UserSurnameTextBox.Text,
                Email = email,
                PhoneNumber = phone,
                Address = newAddress
            };

            if (!ValidateObject(newReceptionist, out ICollection<ValidationResult> results))
            {
                errors = new string[] { string.Join('\n', results.Select(r => r.ErrorMessage)), "Validation error" };
                return false;
            }

            // return object preparation:
            // ---------- ! TODO co jak zmieni nazwisko? np. sie ozeni? ! ----------
            Receptionist existingReceptionist = _receptionistService.GetReceptionistByName(UserNameTextBox.Text, UserSurnameTextBox.Text);
            if (editExisting)
            {
                if (existingReceptionist == null)
                {
                    errors = new string[] { "No receptionist with given first and last name found", "Error" };
                    return false;
                }
                newReceptionist.Id = existingReceptionist.Id;
            }
            else // !editExisting
            {
                if (existingReceptionist != null)
                {
                    errors = new string[] { "Receptionists already exists", "Add New Receptionist" };
                    return false;
                }
            }

            return true;
        }

        private bool ValidateLaboratoryTechnician(out LaboratoryTechnician newLaboratoryTechnician, out string[] errors, Address newAddress, string email, string phone, bool editExisting = false)
        {
            newLaboratoryTechnician = new LaboratoryTechnician
            {
                FirstName = UserNameTextBox.Text,
                LastName = UserSurnameTextBox.Text,
                Email = email,
                PhoneNumber = phone,
                Address = newAddress
            };
            
            if (!ValidateObject(newLaboratoryTechnician, out ICollection<ValidationResult> results))
            {
                errors = new string[] { string.Join('\n', results.Select(r => r.ErrorMessage)), "Validation error" };
                return false;
            }

            // ---------- ! TODO co jak zmieni nazwisko? np. sie ozeni? ! ----------
            LaboratoryTechnician existingTechnician = _technicianService.GetLaboratoryTechnicianByName(UserNameTextBox.Text, UserSurnameTextBox.Text);
            if (editExisting)
            {
                if (existingTechnician == null)
                {
                    errors = new string[] { "No technician with given first and last name found", "Error" };
                    return false;
                }
                newLaboratoryTechnician.Id = existingTechnician.Id;
            }
            else // !editExisting
            {
                if (existingTechnician != null)
                {
                    errors = new string[] { "Laboratory Technician already exists.", "Add New Laboratory Technician" };
                    return false;
                }
            }

            errors = null;
            return true;
        }

        private bool ValidateLaboratoryManager(out LaboratoryManager newLaboratoryManager, out string[] errors, Address newAddress, string email, string phone, bool editExisting = false)
        {
            newLaboratoryManager = new LaboratoryManager
            {
                FirstName = UserNameTextBox.Text,
                LastName = UserSurnameTextBox.Text,
                Email = email,
                PhoneNumber = phone,
                Address = newAddress
            };

            if (!ValidateObject(newLaboratoryManager, out ICollection<ValidationResult> results))
            {
                errors = new string[] { string.Join('\n', results.Select(r => r.ErrorMessage)), "Validation error" };
                return false;
            }

            // ---------- ! TODO co jak zmieni nazwisko? np. sie ozeni? ! ----------
            LaboratoryManager existingManager = _managerService.GetLaboratoryManagerByName(UserNameTextBox.Text, UserSurnameTextBox.Text);
            if (editExisting)
            {
                if (existingManager == null)
                {
                    errors = new string[] { "No manager with given first and last name found", "Error" };
                    return false;
                }
                newLaboratoryManager.Id = existingManager.Id;
            }
            else // !editExisting
            {
                if (existingManager != null)
                {
                    errors = new string[] { "Laboratory Manager already exists.", "Add New Laboratory Manager" };
                    return false;
                }
            }

            errors = null;
            return true;
        }
    }
}
