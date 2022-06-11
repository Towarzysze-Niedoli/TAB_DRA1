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
using ClinicManagementSystem.Entities.Enums;
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
        IEnumerable<Appointment> appointments;
        private List<(AppointmentStatus?, string)> _appointmentStatus;

        public VisitsMainForm(UserLevel level, IAppointmentService appointmentService, IPatientService patientService, IDoctorService doctorService)
        {
            InitializeComponent();
            InitializeVisitStatusCombobox();
            SetSearchOnEnterClick();

            _level = level;
            _service = appointmentService;
            _patientService = patientService;
            _doctorService = doctorService;
            SetVisibility();
            _visitsListForm = new VisitsListForm();

            appointments = _service.GetAppointments();
            DisplayAppointments(appointments);

            _visitsListForm.ElementClicked += FillVisitTextFields;
            this.VisitsListPanel.Controls.Add(_visitsListForm);

        }

        private void SetSearchOnEnterClick()
        {
            SearchPatientTextBox.KeyDown += (sender, args) => {
                if (args.KeyCode == Keys.Enter || args.KeyCode == Keys.Return)
                    SearchPatientButton_Click(sender, args);
            };
        }

        private void InitializeVisitStatusCombobox()
        {
            _appointmentStatus = new List<(AppointmentStatus?, string)>
            {
                (null, "<Select Appointment Status>"),
                (AppointmentStatus.Accepted, "Accepted"),
                (AppointmentStatus.Cancelled, "Cancelled"),
                (AppointmentStatus.Pending, "Pending"),
            };

            _appointmentStatus.ForEach(((AppointmentStatus?, string) tuple) => {
                VisitStatusComboBox.Items.Add(tuple.Item2);
            });
            VisitStatusComboBox.SelectedIndex = 0;
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
                    $"{appointment.RegistrationDate.Date.ToShortDateString()} {appointment.RegistrationDate.TimeOfDay.Hours.ToString() + ":" + appointment.RegistrationDate.TimeOfDay.Minutes.ToString()}");
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
            int index = 0;
            foreach(var a in appointments)
            {
                if(args.Index == index)
                {

                    PatientNameTextBox.Text = a.Patient.FirstName;
                    PatientSurnameTextBox.Text = a.Patient.LastName;
                    DoctorNameTextBox.Text = a.Doctor.FirstName;
                    DoctorSurnameTextBox.Text = a.Doctor.LastName;
                    VisitDateTextBox.Text = a.RegistrationDate.Date.ToShortDateString();
                    VisitTimeTextBox.Text = a.RegistrationDate.TimeOfDay.Hours.ToString() + ":" + a.RegistrationDate.TimeOfDay.Minutes.ToString();
                    break;
                }
                else
                {
                    index++;
                }
            }
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
                appointments = _service.GetAcceptedAppointmentsForPatient(searchedPatient);
                DisplayAppointments(appointments);
            }
            else
            {
                // TODO something
            }
        }

    }
}
