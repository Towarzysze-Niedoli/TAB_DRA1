using ClinicManagementSystem.Entities.Enums;
using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ClinicManagementSystem.Forms.MainForms
{
    partial class ManagerForm
    {
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

        private void UpdateDoctor()
        {
            if (ValidateDoctor(out Doctor doctorToUpdate, out string[] errors, out string password, true))
            {
                try
                {
                    _doctorService.UpdateDoctor(doctorToUpdate, password);
                    MessageBox.Show("Doctor data has been succesfully updated", "Update Doctor Data");
                    ClearData();
                }
                catch (Exception e) // TODO change ?
                {
                    MessageBox.Show("Insert error: " + e.Message, "Update Patient Data");
                }
            }
            else
            {
                MessageBox.Show(errors[0], errors[1]);
            }
        }

        private void UpdateReceptionist()
        {
            if (ValidateReceptionist(out Receptionist receptionistToUpdate, out string[] errors, out string password, true))
            {
                try
                {
                    _receptionistService.UpdateReceptionist(receptionistToUpdate, password);
                    MessageBox.Show("Receptionist data has been succesfully updated", "Update Receptionist Data");
                    ClearData();
                }
                catch (Exception e) // TODO change ?
                {
                    MessageBox.Show("Insert error: " + e.Message, "Add New Receptionist");
                }
            }
            else
            {
                MessageBox.Show(errors[0], errors[1]);
            }
        }

        private void UpdateLaboratoryWorker()
        {
            // common:
            if (!ValidatePersonWithAccountCommons(out Address newAddress, out string email, out string phone, out string password, out string[] errors, true))
            {
                MessageBox.Show(errors[0], errors[1]);
                return;
            }

            if (LabManagerRadioButton.Checked)
            {
                UpdateLaboratoryManager(newAddress, password, email, phone);
            }
            else if (LabTechicianRadioButton.Checked)
            {
                UpdateLaboratoryTechnician(newAddress, password, email, phone);
            }
            else
            {
                MessageBox.Show("Select the type of worker!", "Update Laboratory Worker");
            }           
        }

        private void UpdateLaboratoryManager(Address newAddress, string password, string email, string phone)
        {
            if (ValidateLaboratoryManager(out LaboratoryManager managerToUpdate, out string[] errors, newAddress, email, phone, true))
            {
                try
                {
                    _managerService.UpdateLaboratoryManager(managerToUpdate, password);
                    MessageBox.Show("Laboratory manager data has been succesfully updated", "Update Laboratory Manager");
                    ClearData();
                }
                catch (Exception e) // TODO change ?
                {
                    MessageBox.Show("Insert error: " + e.Message, "Add New Laboratory Manager");
                }
            }
            else
            {
                MessageBox.Show(errors[0], errors[1]);
            }
        }

        private void UpdateLaboratoryTechnician(Address newAddress, string password, string email, string phone)
        {
            if (ValidateLaboratoryTechnician(out LaboratoryTechnician technicianToUpdate, out string[] errors, newAddress, email, phone, true))
            {
                try
                {
                    _technicianService.UpdateLaboratoryTechnician(technicianToUpdate, password);
                    MessageBox.Show("Laboratory manager data has been succesfully updated.", "Update Laboratory Manager");
                    ClearData();
                }
                catch (Exception e) // TODO change ?
                {
                    MessageBox.Show("Insert error: " + e.Message, "Add New Laboratory Technician");
                }
            }
            else
            {
                MessageBox.Show(errors[0], errors[1]);
            }
        }

        private void UpdatePatient()
        {
            if (ValidatePatient(out Patient patientToUpdate, out string[] errors, true))
            {
                try
                {
                    _patientService.UpdatePatient(patientToUpdate);
                    MessageBox.Show("Patient data has been succesfully updated", "Update Patient Data");
                    ClearData();
                }
                catch (Exception e) // TODO change ?
                {
                    MessageBox.Show("Insert error: " + e.Message, "Update Patient Data");
                }
            }
            else
            {
                MessageBox.Show(errors[0], errors[1]);
            }
        }


    }
}
