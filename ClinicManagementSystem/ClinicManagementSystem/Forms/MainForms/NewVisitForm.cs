using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClinicManagementSystem.Forms.SideForms;
using ClinicManagementSystem.Forms.EventArguments;

namespace ClinicManagementSystem.Forms.MainForms
{
    public partial class NewVisitForm : Form
    {
        private ListForm _doctorsList;
        private PersonInfoForm _patientInfo;
        public NewVisitForm()
        {
            InitializeComponent();
            InitializeList();
        }

        void InitializeList()
        {
            _doctorsList = new DoctorListForm();
            _doctorsList.ElementClicked += FillDoctorTextFields;
            this.DoctorsListPanel.Controls.Add(_doctorsList);

            _patientInfo = new PersonInfoForm();
            this.PatientPanel.Controls.Add(_patientInfo);
            
            _doctorsList.Show();
            _patientInfo.Show();
        }

        private void SearchPatientButton_Click(object sender, EventArgs e)
        {

        }

        private void NewVisitButton_Click(object sender, EventArgs e)
        {

        }

        private void NewPatientButton_Click(object sender, EventArgs e)
        {

        }

        private void FillDoctorTextFields(object source, ListElementClickedDoctorArgs args)
        {
            string[] nameAndSurname = args.Name.Split(' ');
            string[] dateTime = args.Date.Split('-');
            this.DoctorNameTextBox.Text = nameAndSurname[0];
            this.DoctorSurnameTextBox.Text = nameAndSurname[1];
            this.VisitDateTextBox.Text = dateTime[0] + dateTime[1];
            this.VisitTimeTextBox.Text = dateTime[2];
        }
    }
}
