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
using ClinicManagementSystem.Forms.CustomElements;
using ClinicManagementSystem.Entities.Models;
using ClinicManagementSystem.Services.impl;

namespace ClinicManagementSystem.Forms.MainForms
{
    public partial class VisitsMainForm : Form
    {
        public delegate void NextPageButtonClicked(object source, PageControllingButtonClickedArgs args);

        public event NextPageButtonClicked ButtonClicked;

        private ListForm _visitsListForm;

        private UserLevel _level;
        private IAppointmentService _service;
        private IPatientService _patientService;
        private IDoctorService _doctorService;

        public VisitsMainForm(UserLevel level, IAppointmentService appointmentService, IPatientService patientService, IDoctorService doctorService)
        {
            InitializeComponent();
            SearchPatientTextBox.KeyDown += (sender, args) => { // search on enter click
                if (args.KeyCode == Keys.Enter || args.KeyCode == Keys.Return)
                    SearchPatientButton_Click(sender, args);
            };

            _level = level;
            _service = appointmentService;
            _patientService = patientService;
            _doctorService = doctorService;
            SetVisibility();
            _visitsListForm = new VisitsListForm();

            var appointments = _service.GetAppointments();
            DisplayAppointments(appointments);

            _visitsListForm.ElementClicked += FillVisitTextFields;
            this.VisitsListPanel.Controls.Add(_visitsListForm);

        }
        private void DisplayAppointments(IEnumerable<Appointment> appointments)
        {
            var elements = new List<ListElement>();
            int index = 0;
            foreach (Appointment appointment in appointments)
            {
                string patientName = appointment.Patient != null ? appointment.Patient.FirstName + ' ' + appointment.Patient.LastName : "";
                var el = new VisitListElement(index++,
                    patientName,
                    $"{appointment.Doctor.FirstName} {appointment.Doctor.LastName}",
                    appointment.RegistrationDate.ToString());
                elements.Add(el);
            }
            _visitsListForm.PopulateList(elements);
            _visitsListForm.Show();

        }
        private void NewVisitButton_Click(object sender, EventArgs e)
        {
            ButtonClicked.Invoke(this, new PageControllingButtonClickedArgs(MainFormType.NewVisit, _level));
        }

        private void CancelVisitButton_Click(object sender, EventArgs e)
        {
            
        }

        private void SearchPatientButton_Click(object sender, EventArgs e)
        {

        }

        private void FillVisitTextFields(object sender, ListElementClickedArgs args)
        {
            //@todo get info from model and put it into text fields
        }

        private void PerformVisitButton_Click(object sender, EventArgs e)
        {
            ButtonClicked.Invoke(this, new PageControllingButtonClickedArgs(MainFormType.PerformVisit, _level));
        }

        private void SetVisibility()
        {
            if(_level==UserLevel.Doctor)
            {
                this.NewVisitButton.Hide();
            }
            else if(_level == UserLevel.Receptionist)
            {
                this.PerformVisitButton.Hide();
            }
        }

        private void SearchPatientButton_Click_1(object sender, EventArgs e)
        {
            string [] name = SearchPatientTextBox.Text.Split(' ');
            if (name.Length > 1)
            {
                Patient searchedPatient = _patientService.GetPatientByName(name[0], name[1]);
                var appointments = _service.GetAcceptedAppointmentsForPatient(searchedPatient);
                DisplayAppointments(appointments);
            }
            else
            {
                // TODO something
            }
        }

    }
}
