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
using Microsoft.Extensions.DependencyInjection;
using ClinicManagementSystem.Entities.Models;
using ClinicManagementSystem.Entities.Enums;
using System.Data.Entity.Validation;
using ClinicManagementSystem.Auth.Services;

namespace ClinicManagementSystem.Forms.MainForms
{
    public partial class NewVisitForm : Form
    {
        private ListForm _doctorsList;
        private PersonInfoForm _patientInfo;
        private IPatientService _patientService;
        private IDoctorService _doctorService;
        private IAppointmentService _appointmentService;
        private IAuthorizationService _authorizationService;
        private List<(Specialization, string)> _specialization;
        IEnumerable<Doctor> doctors;
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
            doctors = _doctorService.GetDoctors();
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

        private void DisplayDoctors(IEnumerable<Doctor> doctors)
        {
            var elements = new List<ListElement>();
            int index = 0;

            foreach(Doctor doctor in doctors)
            {
                string doctorName = doctor.FirstName != null ? doctor.FirstName + " " + doctor.LastName : " ";
                var el = new DoctorListElement(index++,
                doctorName,
                ((Specialization)doctor.Specialization).ToString(),
                "Thu - 15.03.2022 - 8:00"); //tymczasowe
                elements.Add(el); 
            }
            _doctorsList.PopulateList(elements);
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
            string[] name = SearchPatientTextBox.Text.Split(' ');
            if(name.Length == 2)
            {
                Patient patient = _patientService.GetPatientByName(name[0], name[1]);
                if (patient == null)
                    return;
                _patientInfo.InitializeValues(patient.FirstName, patient.LastName, patient.PersonalIdentityNumber, patient.PhoneNumber, patient.Address.City, patient.Address.ZipCode, patient.Address.Street, patient.Address.HomeNumber, patient.Email, _appointmentService.GetLastAppointmentDateForPacient(patient));
                
                _patientInfo.Show();
                FillPatientTextFields(patient.FirstName, patient.LastName);
                _chosenPatient = patient;
            }
        }

        private void NewVisitButton_Click(object sender, EventArgs e)
        {
            if(_chosenPatient != null || _chosenDoctor != null)
            {
                Appointment newAppointment = new Appointment
                {
                    Doctor = _chosenDoctor,
                    Patient = _chosenPatient,
                    RegistrationDate = DateTime.Now,
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
                ClearData();
            }
            else
            {
                MessageBox.Show("Complete the missing data!", "Add New Visit");
            }     
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
            int index = 0;
            foreach(var doctor in doctors)
            {
                if(args.Index == index)
                {
                    DoctorNameTextBox.Text = doctor.FirstName;
                    DoctorSurnameTextBox.Text = doctor.LastName;
                    _chosenDoctor = doctor;
                    //todo pobranie daty i czasu wizyty
                    break;
                }
                else
                {
                    index++;
                }
            }   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int specIndex = this.SpecializationComboBox.SelectedIndex;
            if(specIndex == 0)
            {
                doctors = _doctorService.GetDoctors();
                DisplayDoctors(doctors);
            }
            else
            {
                doctors = _doctorService.GetDoctorBySpecialization(specIndex);
                DisplayDoctors(doctors);
            }
            _doctorsList.ResetIndex();
        }

        private void ClearData()
        {
            DoctorNameTextBox.Clear();
            DoctorSurnameTextBox.Clear();
            PatientNameTextBox.Clear();
            PatientSurnameTextBox.Clear();
        }
    }
}
