using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClinicManagementSystem.Forms.SideForms;
using ClinicManagementSystem.Forms.EventArguments;
using ClinicManagementSystem.Services;
using Microsoft.Extensions.DependencyInjection;
using ClinicManagementSystem.Entities.Models;
using ClinicManagementSystem.Entities.Enums;

namespace ClinicManagementSystem.Forms.MainForms
{
    public partial class NewVisitForm : Form
    {
        private ListForm _doctorsList;
        private PersonInfoForm _patientInfo;
        private IPatientService _patientService;
        private IAppointmentService _appointmentService;
        private List<(Specialization?, string)> _specialization;

        public NewVisitForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            InitializeSpecializationCombobox();
            SetSearchOnEnterClick();
            InitializeList();
            _patientService = serviceProvider.GetService<IPatientService>();
            _appointmentService = serviceProvider.GetService<IAppointmentService>();
        }

        private void SetSearchOnEnterClick()
        {
            SearchPatientTextBox.KeyDown += (sender, args) =>
            { // search on enter click
                if (args.KeyCode == Keys.Enter || args.KeyCode == Keys.Return)
                    SearchPatientButton_Click(sender, args);
            };
        }
        private void InitializeSpecializationCombobox()
        {
            _specialization = new List<(Specialization?, string)>
            {
                (null, "<Select Specialization>"),
                (Specialization.Anesthesiologist, "Anesthesiologist"),
                (Specialization.EmergencyPhysician, "Emergency Physician"),
                (Specialization.Gynecologist, "Gynecologist"),
                (Specialization.Internist, "Internist"),
                (Specialization.Neurologist, "Neurologist"),
                (Specialization.Pediatrician, "Pediatrician"),
                (Specialization.Radiologist, "Radiologist")
            };

            _specialization.ForEach(((Specialization?, string) tuple) => {
                SpecializationComboBox.Items.Add(tuple.Item2);
            });
            SpecializationComboBox.SelectedIndex = 0;
        }

        void InitializeList()
        {
            _doctorsList = new DoctorListForm();
            _doctorsList.ElementClicked += FillDoctorTextFields;
            this.DoctorsListPanel.Controls.Add(_doctorsList);

            _patientInfo = new PersonInfoForm();
            this.PatientPanel.Controls.Add(_patientInfo);
            
            _doctorsList.Show();
            //_patientInfo.Show();
        }

        private void SearchPatientButton_Click(object sender, EventArgs e)
        {
            string[] name = SearchPatientTextBox.Text.Split(' ');
            if(name.Length == 2)
            {
                Patient patient = _patientService.GetPatientByName(name[0], name[1]);
                _patientInfo.InitializeValues(patient.FirstName, patient.LastName, patient.PersonalIdentityNumber, patient.PhoneNumber, patient.Address.City, patient.Address.ZipCode, patient.Address.Street, patient.Address.HomeNumber, patient.Email ,DateTime.Now);
                // TODO - last vist - change in model in patient or service method?
                _patientInfo.Show();
                FillPatientTextFields(patient.FirstName, patient.LastName);
            }
        }

        private void NewVisitButton_Click(object sender, EventArgs e)
        {

        }

        private void NewPatientButton_Click(object sender, EventArgs e)
        {

        }

        private void FillPatientTextFields(string firstName, string lastName)
        {
            this.PatientNameTextBox.Text = firstName;
            this.PatientSurnameTextBox.Text = lastName;
        }

        private void FillDoctorTextFields(object source, ListElementClickedArgs args)
        {
            //@todo get info from model and put it into text fields
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //search doctor
            int specIndex = this.SpecializationComboBox.SelectedIndex;
            DateTime date = this.VisitDateTimePicker.Value;
        }
    }
}
