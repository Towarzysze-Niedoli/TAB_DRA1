using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ClinicManagementSystem.Forms.MainForms
{
    partial class ManagerForm
    {
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            switch (_formType)
            {
                case MainFormType.ManagerPatients:
                    DeletePatient();
                    break;
                case MainFormType.ManagerDoctors:
                    DisableDoctorAccount();
                    break;
                case MainFormType.ManagerLaboratory:
                    DisableLabWorkerAccount();
                    break;
                case MainFormType.ManagerReceptionist:
                    DisableReceptionistAccount();
                    break;
                default:
                    break;
            }
        }

        private void DeletePatient()
        {
            if (ValidatePatient(out Patient patientToUDelete, out string[] errors, true))
            {
                try
                {
                    _patientService.DeletePatient(patientToUDelete.Id);
                    MessageBox.Show("Patient has been deleted.", "Delete Patient");
                    ClearData();
                }
                catch (Exception e) // TODO change ?
                {
                    MessageBox.Show("Deletion error: " + e.Message, "Delete Patient");
                }               
            }
            else
            {
                MessageBox.Show(errors[0], errors[1]);
            }
        }

        private void DisableDoctorAccount()
        {
            if (ValidateDoctor(out Doctor doctorToDisable, out string[] errors, out string password, true))  
            {
                ApplicationUser userToDisable = _applicationUserService.GetAccountStatus(doctorToDisable.Email);
                if (userToDisable != null && userToDisable.IsDisabled)
                {
                    MessageBox.Show("Doctor account is already disabled.", "Doctor Account Deactivate");
                }
                else if (userToDisable !=null)
                {
                    try
                    {
                        _doctorService.DisableDoctorAccount(doctorToDisable.Id);
                        MessageBox.Show("Doctor account has been disabled", "Doctor Account Deactivate");
                        ClearData();
                    }
                    catch (Exception e) // TODO change ?
                    {
                        MessageBox.Show("Deactivate error: " + e.Message, "Doctor Account Deactivate");
                    }
                }              
            }
            else
            {
                MessageBox.Show(errors[0], errors[1]);
            }
        }

        private void DisableLabWorkerAccount()
        {
            // common:
            if (!ValidatePersonWithAccountCommons(out Address newAddress, out string email, out string phone, out string password, out string[] errors, true))
            {
                MessageBox.Show(errors[0], errors[1]);
                return;
            }

            if (LabManagerRadioButton.Checked)
            {
                DisableLabManagerAccount(newAddress, password, email, phone);
            }
            else if (LabTechicianRadioButton.Checked)
            {
                DisableLabTechnicianAccount(newAddress, password, email, phone);
            }
            else
            {
                MessageBox.Show("Select the type of worker!", "Disable Laboratory Worker Account");
            }
        }

        private void DisableLabManagerAccount(Address newAddress, string password, string email, string phone)
        {
            if (ValidateLaboratoryManager(out LaboratoryManager managerToDisable, out string[] errors, newAddress, email, phone, true))
            {
                ApplicationUser userToDisable = _applicationUserService.GetAccountStatus(managerToDisable.Email);
                if (userToDisable != null && userToDisable.IsDisabled)
                {
                    MessageBox.Show("Laboratory Manager account is already disabled.", "Laboratory Manager Account Deactivate");
                }
                else if (userToDisable != null)
                {
                    try
                    {
                        _managerService.DisableLaboratoryManagerAccount(managerToDisable.Id);
                        MessageBox.Show("Laboratory Manager account has been disabled", "Laboratory Manager Account Deactivate");
                        ClearData();
                    }
                    catch (Exception e) // TODO change ?
                    {
                        MessageBox.Show("Deactivate error: " + e.Message, "Laboratory Manager Account Deactivate");
                    }
                }
            }
            else
            {
                MessageBox.Show(errors[0], errors[1]);
            }
        }

        private void DisableLabTechnicianAccount(Address newAddress, string password, string email, string phone)
        {
            if (ValidateLaboratoryTechnician(out LaboratoryTechnician technicianToDisable, out string[] errors, newAddress, email, phone, true))
            {
                ApplicationUser userToDisable = _applicationUserService.GetAccountStatus(technicianToDisable.Email);
                if (userToDisable != null && userToDisable.IsDisabled)
                {
                    MessageBox.Show("Laboratory Technician account is already disabled.", "Laboratory Technician Account Deactivate");
                }
                else if (userToDisable != null)
                {
                    try
                    {
                        _technicianService.DisableLaboratoryTechnicianAccount(technicianToDisable.Id);
                        MessageBox.Show("Laboratory Technician account has been disabled", "Laboratory Technician Account Deactivate");
                        ClearData();
                    }
                    catch (Exception e) // TODO change ?
                    {
                        MessageBox.Show("Deactivate error: " + e.Message, "Laboratory Technician Account Deactivate");
                    }
                }
            }
            else
            {
                MessageBox.Show(errors[0], errors[1]);
            }
        }

        private void DisableReceptionistAccount()
        {
            if (ValidateReceptionist(out Receptionist receptionistToDisable, out string[] errors, out string password, true))
            {
                ApplicationUser userToDisable = _applicationUserService.GetAccountStatus(receptionistToDisable.Email);
                if (userToDisable != null && userToDisable.IsDisabled)
                {
                    MessageBox.Show("Receptionist account is already disabled.", "Receptionist Account Deactivate");
                }
                else if (userToDisable != null)
                {
                    try
                    {
                        _receptionistService.DisableReceptionistAccount(receptionistToDisable.Id);
                        MessageBox.Show("Receptionist account has been disabled", "Receptionist Account Deactivate");
                        ClearData();
                    }
                    catch (Exception e) // TODO change ?
                    {
                        MessageBox.Show("Deactivate error: " + e.Message, "Receptionist Account Deactivate");
                    }
                }
            }
            else
            {
                MessageBox.Show(errors[0], errors[1]);
            }
        }
    }
}
