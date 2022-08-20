using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using ClinicManagementSystem.Forms.SideForms;
using ClinicManagementSystem.Forms.EventArguments;
using ClinicManagementSystem.Services;
using ClinicManagementSystem.Forms.CustomElements;
using Microsoft.Extensions.DependencyInjection;
using ClinicManagementSystem.Entities.Models;
using ClinicManagementSystem.Entities.Enums;
using System.Data.Entity.Validation;
using ClinicManagementSystem.Auth.Services;
using System.Text.RegularExpressions;

namespace ClinicManagementSystem.Forms.MainForms
{
    public partial class NewVisitForm : Form
    {
        private DoctorListForm _doctorsList;
        private PersonInfoForm _patientInfo;
        private IPatientService _patientService;
        private IDoctorService _doctorService;
        private IAppointmentService _appointmentService;
        private IAuthorizationService _authorizationService;
        private List<(Specialization, string)> _specialization;
        IList<Doctor> doctors;
        private Doctor _chosenDoctor;
        private Patient _chosenPatient;
        public NewVisitForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            InitializeSpecializationCombobox();
            SetSearchOnEnterClick();
            InitializeList();
            _patientService = serviceProvider.GetService<IPatientService>();
            _appointmentService = serviceProvider.GetService<IAppointmentService>();
            _doctorService = serviceProvider.GetService<IDoctorService>();
            _authorizationService = serviceProvider.GetService<IAuthorizationService>();
            doctors = _doctorService.GetDoctors().ToList();
            DisplayDoctors(doctors);
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
            _specialization = new List<(Specialization, string)>
            {
                (Specialization.None, "<Select Specialization>"),
                (Specialization.Internist, "Internist"),
                (Specialization.Radiologist, "Radiologist"),
                (Specialization.Neurologist, "Neurologist"),
                (Specialization.Gynecologist, "Gynecologist"),
                (Specialization.Anesthesiologist, "Anesthesiologist"),
                (Specialization.Pediatrician, "Pediatrician"),
                (Specialization.EmergencyPhysician, "Emergency Physician")   
            };

            _specialization.ForEach(((Specialization, string) tuple) => {
                SpecializationComboBox.Items.Add(tuple.Item2);
            });
            SpecializationComboBox.SelectedIndex = 0;
        }

        private void DisplayDoctors(IList<Doctor> doctors)
        {
            _doctorsList.PopulateList(doctors);
            _doctorsList.Show();
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
            // TODO poprawic wyszukiwanie - lista pacjentow, po peseli, numerze telefonu, etc...
            string[] name = SearchPatientTextBox.Text.Split(' ');
            if(name.Length == 2)
            {
                Patient patient = _patientService.GetPatientByName(name[0], name[1]);
                if (patient == null)
                {
                    MessageBox.Show("Patient not found", "Not found");
                    return;
                }
                _patientInfo.InitializeValues(patient, _appointmentService.GetLastAppointmentDateForPatient(patient));
                
                _patientInfo.Show();
                FillPatientTextFields(patient.FirstName, patient.LastName);
                _chosenPatient = patient;
            }
            else 
            {
                MessageBox.Show("Enter first and last name", "Incorrect input");
            }
        }

        private void NewVisitButton_Click(object sender, EventArgs e)
        {
            if(_chosenPatient != null || _chosenDoctor != null)
            {
                if (!IsTimeValid(VisitTimeTextBox.Text))
                {
                    MessageBox.Show("Invalid visit time!", "Add New Visit");
                    return;
                }
                    
                DateTime date = VisitDateTimePicker.Value;

                int[] time = VisitTimeTextBox.Text.Split(new char[] { ':', '.', '-' }).Select(s => int.Parse(s)).ToArray();
                
                DateTime scheduledDate = new DateTime(date.Year, date.Month, date.Day, time[0], time[1], 0);

                if(_appointmentService.IsDoctorAvailable(scheduledDate, _chosenDoctor))
                {
                    Appointment newAppointment = new Appointment
                    {
                        Doctor = _chosenDoctor,
                        Patient = _chosenPatient,
                        RegistrationDate = DateTime.Now,
                        ScheduledDate = scheduledDate,
                        Receptionist = _authorizationService.GetCurrentlyLoggedPerson<Receptionist>()
                    };
                    try
                    {
                        _appointmentService.InsertAppointment(newAppointment);
                        MessageBox.Show("New visit has been succesfully added.", "Add New Visit");
                    }
                    catch (DbEntityValidationException) // TODO change
                    {
                        MessageBox.Show("Insert error.", "Add New Visit");
                    }
                    _doctorsList.Deselect();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("The doctor is not available on the chosen date!", "Add New Visit");
                }                
            }
            else
            {
                MessageBox.Show("Complete the missing data!", "Add New Visit");
            }     
        }

        private void NewPatientButton_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void FillPatientTextFields(string firstName, string lastName)
        {
            this.PatientNameTextBox.Text = firstName;
            this.PatientSurnameTextBox.Text = lastName;
        }

        private void FillDoctorTextFields(object source, ListElementClickedArgs args)
        {
            int index = 0;
            foreach(var doctor in doctors)
            {
                if(args.Index == index)
                {
                    DoctorNameTextBox.Text = doctor.FirstName;
                    DoctorSurnameTextBox.Text = doctor.LastName;
                    _chosenDoctor = doctor;
                    break;
                }
                else
                {
                    index++;
                }
            }   
        }

        private void SearchDoctorButton_Click(object sender, EventArgs e)
        {
            int specIndex = this.SpecializationComboBox.SelectedIndex;
            if(specIndex == 0)
            {
                doctors = _doctorService.GetDoctors().ToList();
            }
            else
            {
                doctors = _doctorService.GetDoctorBySpecialization(specIndex).ToList();
            }
            DisplayDoctors(doctors);
        }

        private void ClearData()
        {
            DoctorNameTextBox.Clear();
            DoctorSurnameTextBox.Clear();
            PatientNameTextBox.Clear();
            PatientSurnameTextBox.Clear();
            VisitTimeTextBox.Clear();
        }

        private bool IsTimeValid(string time)
        => new Regex(@"^(?:0?[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$").IsMatch(time);
    }
}
