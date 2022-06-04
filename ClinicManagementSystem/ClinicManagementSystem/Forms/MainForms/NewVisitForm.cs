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
            SearchPatientTextBox.KeyDown += (sender, args) => { // search on enter click
                if (args.KeyCode == Keys.Enter || args.KeyCode == Keys.Return)
                    SearchPatientButton_Click(sender, args);
            };
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

        private void FillDoctorTextFields(object source, ListElementClickedArgs args)
        {
            //@todo get info from model and put it into text fields
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
