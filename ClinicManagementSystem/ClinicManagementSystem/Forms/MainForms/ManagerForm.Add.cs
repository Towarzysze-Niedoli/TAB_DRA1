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

        private void AddPatient()
        {
            if (ValidatePatient(out Patient newPatient, out string[] errors))
            {
                try
                {
                    _patientService.InsertPatient(newPatient);
                    MessageBox.Show("New patient has been succesfully added", "Add New Patient");
                    ClearData();
                }
                catch (Exception e) // TODO change ?
                {
                    MessageBox.Show("Insert error: " + e.Message, "Add New Patient");
                }
            }
            else
            {
                MessageBox.Show(errors[0], errors[1]);
            }
        }

        private void AddDoctor()
        {
            if (ValidateDoctor(out Doctor newDoctor, out string[] errors, out string password))
            {
                try
                {
                    _doctorService.InsertDoctor(newDoctor, password);
                    MessageBox.Show("New doctor has been succesfully added", "Add New Doctor");
                    ClearData();
                }
                catch (Exception e) // TODO change ?
                {
                    MessageBox.Show("Insert error: " + e.Message, "Add New Doctor");
                }
            }
            else
            {
                MessageBox.Show(errors[0], errors[1]);
            }
        }

        private void AddReceptionist()
        {
            if (ValidateReceptionist(out Receptionist newReceptionist, out string[] errors, out string password))
            {
                try
                {
                    _receptionistService.InsertReceptionist(newReceptionist, password);
                    MessageBox.Show("New receptionist has been succesfully added", "Add New Receptionist");
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

        private void AddLaboratoryWorker()
        {
            // common:
            if (!ValidatePersonWithAccountCommons(out Address newAddress, out string email, out string phone, out string password, out string[] errors))
            {
                MessageBox.Show(errors[0], errors[1]);
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
            if (ValidateLaboratoryTechnician(out LaboratoryTechnician newLaboratoryTechnician, out string[] errors, newAddress, email, phone))
            {
                try
                {
                    _technicianService.InsertLaboratoryTechnician(newLaboratoryTechnician, password);
                    MessageBox.Show("New laboratory technician has been succesfully added.", "Add New Laboratory Technician");
                    ClearData();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Insert error: " + e.Message, "Add New Laboratory Technician");
                }
            }
            else
            {
                MessageBox.Show(errors[0], errors[1]);
            }
        }

        private void AddLaboratoryManager(Address newAddress, string password, string email, string phone)
        {
            if (ValidateLaboratoryManager(out LaboratoryManager newLaboratoryManager, out string[] errors, newAddress, email, phone))
            {
                try
                {
                    _managerService.InsertLaboratoryManager(newLaboratoryManager, password);
                    MessageBox.Show("New laboratory manager has been succesfully added.", "Add New Laboratory Manager");
                    ClearData();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Insert error: " + e.Message, "Add New Laboratory Manager");
                }
            }
            else
            {
                MessageBox.Show(errors[0], errors[1]);
            }
        }



    }
}
