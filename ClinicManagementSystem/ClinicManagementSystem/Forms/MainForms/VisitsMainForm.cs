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
using System.Linq;
using ClinicManagementSystem.Auth.Services;

namespace ClinicManagementSystem.Forms.MainForms
{
    public partial class VisitsMainForm : Form
    {
        public delegate void NextPageButtonClicked(object source, PageControllingButtonClickedArgs args);
        public event NextPageButtonClicked ButtonClicked;

        private VisitsListForm _visitsListForm;

        private UserLevel _level;
        private IAppointmentService _service;
        private IPatientService _patientService;
        private IAuthorizationService _authorizationService;
        //private IDoctorService _doctorService;
        private IList<Appointment> _appointments;

        private Doctor _loggedDoctor;
        Appointment _currentAppointment;
        private List<(AppointmentStatus?, string)> _appointmentStatus;

        public VisitsMainForm(UserLevel level, IAppointmentService appointmentService, IPatientService patientService, IAuthorizationService authorizationService)
        {
            InitializeComponent();
            InitializeVisitStatusCombobox();
            SetSearchOnEnterClick();

            _level = level;
            _service = appointmentService;
            _patientService = patientService;
            _authorizationService = authorizationService;
            _loggedDoctor = authorizationService.GetCurrentlyLoggedPerson<Doctor>(); // jesli nie jestesmy doktorem, tylko np. recepcjonistka, to dostaniemy null
            //_doctorService = doctorService;
            SetVisibility();
            _visitsListForm = new VisitsListForm();

            _appointments = _service.GetAppointments(AppointmentStatus.Pending, null, _loggedDoctor);
            DisplayAppointments(_appointments);

            _visitsListForm.ElementClicked += OnVisitsListFormElementClicked;
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
                (null, "All"),
                (AppointmentStatus.Pending, "Pending"),
                (AppointmentStatus.Accepted, "Accepted"),
                (AppointmentStatus.Cancelled, "Cancelled")
            };

            _appointmentStatus.ForEach(((AppointmentStatus?, string) tuple) => {
                VisitStatusComboBox.Items.Add(tuple.Item2);
            });
            VisitStatusComboBox.SelectedIndex = 1; // PR: domyslnie lekarz widzi wizyty, ktore ma przeprowadzic
        }

        private void DisplayAppointments(IList<Appointment> appointments)
        {
            _visitsListForm.PopulateList(appointments);
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
            FilterAndDisplay();
        }

        void FilterAndDisplay()
        {
            if (_service == null)
                return;
            string[] name = SearchPatientTextBox.Text.Split(' ');
            DateTime? date = null;
            if (ConsiderDateCheckBox.Checked)
                date = VisitDatePicker.Value.Date;
            if (name.Length > 1)
            {
                IEnumerable<Patient> searchedPatients = _patientService.GetPatientsByName(name[0], name[1]); // PR: przygotowuje pod sytuacje, gdzie dwoch pacjentow ma te same imie i nazwisko albo zmieimy wyszukiwanie na bardziej elastyczne
                if (searchedPatients.Count() == 0)
                {
                    MessageBox.Show("No patient found, showing for all patients", "Warning");
                    _appointments = _service.GetAppointments(_appointmentStatus[VisitStatusComboBox.SelectedIndex].Item1, date, _loggedDoctor);
                }
                else
                {
                    _appointments = searchedPatients
                        .Select(p => _service.GetAppointmentsAsEnumerable(_appointmentStatus[VisitStatusComboBox.SelectedIndex].Item1, date, _loggedDoctor, p))
                        .Aggregate((total, next) => total.Concat(next))
                        .ToList();

                    //_appointments = searchedPatients
                    //    .Select(p => _service.GetAppointments(_appointmentStatus[VisitStatusComboBox.SelectedIndex].Item1, _loggedDoctor).ToList())
                    //    .Aggregate((total, next) => { total.AddRange(next); return total; });
                }
            }
            else
                _appointments = _service.GetAppointments(_appointmentStatus[VisitStatusComboBox.SelectedIndex].Item1, date, _loggedDoctor);


            DisplayAppointments(_appointments);
        }

        private void OnVisitsListFormElementClicked(object sender, ListElementClickedArgs args)
        {
            PerformVisitButton.Enabled = true;
            FillVisitTextFields(sender, args);
        }


        private void FillVisitTextFields(object sender, ListElementClickedArgs args)
        {
            int index = 0;
            _currentAppointment = _appointments.First(a => args.Index == index++);
            if (_currentAppointment == null)
                throw new InvalidOperationException();

            PatientNameTextBox.Text = _currentAppointment.Patient.FirstName;
            PatientSurnameTextBox.Text = _currentAppointment.Patient.LastName;
            DoctorNameTextBox.Text = _currentAppointment.Doctor.FirstName;
            DoctorSurnameTextBox.Text = _currentAppointment.Doctor.LastName;
            VisitDateTextBox.Text = _currentAppointment.ScheduledDate.Date.ToShortDateString();
            VisitTimeTextBox.Text = _currentAppointment.ScheduledDate.ToString("t");
        }

        private void ClearVisitTextFields()
        {
            TextBox[] textBoxes = new TextBox[] { PatientNameTextBox, PatientSurnameTextBox, DoctorNameTextBox, DoctorSurnameTextBox, VisitDateTextBox, VisitTimeTextBox };
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Clear();
            }
            _currentAppointment = null;
        }

        private void PerformVisitButton_Click(object sender, EventArgs e)
        {
            if (_currentAppointment == null)
            {
                MessageBox.Show("Select an appointment", "Error");
                return;
            }

            _service.CurrentAppointment = _currentAppointment;
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

        private void VisitStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterAndDisplay();
            Deselect();
        }

        private void Deselect()
        {
            ClearVisitTextFields();
            //throw new NotImplementedException(); // PR: ma odznaczac aktualnie zaznaczona wizyte
        }

        private void VisitDatePicker_ValueChanged(object sender, EventArgs e)
        {
            FilterAndDisplay();
        }

        private void ConsiderDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FilterAndDisplay();
        }
    }
}
