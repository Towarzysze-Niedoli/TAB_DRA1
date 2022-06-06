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

namespace ClinicManagementSystem.Forms.MainForms
{
    public partial class NewVisitForm : Form
    {
        private ListForm _doctorsList;
        private PersonInfoForm _patientInfo;
        private IPatientService _patientService;
        private IAppointmentService _appointmentService;

        public NewVisitForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            SearchPatientTextBox.KeyDown += (sender, args) =>
            { // search on enter click
                if (args.KeyCode == Keys.Enter || args.KeyCode == Keys.Return)
                    SearchPatientButton_Click(sender, args);
            };
            InitializeList();
            _patientService = serviceProvider.GetService<IPatientService>();
            _appointmentService = serviceProvider.GetService<IAppointmentService>();
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
                _patientInfo.InitializeValues(patient.PersonalIdentityNumber, patient.PhoneNumber, patient.Address.City, patient.Address.ZipCode, patient.Address.Street, patient.Address.HomeNumber, patient.Email ,DateTime.Now);
                // TODO - last vist - change in model in patient or service method?
                _patientInfo.Show();
            }
        }

        private void NewVisitButton_Click(object sender, EventArgs e)
        {

        }

        private void NewPatientButton_Click(object sender, EventArgs e)
        {

        }

        private void FillDoctorTextFields(object source, ListElementClickedArgs args)
        {
            //@todo get info from model and put it into text fields
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
