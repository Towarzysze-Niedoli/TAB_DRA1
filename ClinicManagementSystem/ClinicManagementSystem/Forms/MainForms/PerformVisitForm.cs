﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClinicManagementSystem.Forms.SideForms;
using ClinicManagementSystem.Forms.EventArguments;
using ClinicManagementSystem.Entities.Models;
using ClinicManagementSystem.Services;
using Microsoft.Extensions.DependencyInjection;
using ClinicManagementSystem.Forms.CustomElements;
using System.Linq;
using ClinicManagementSystem.Entities.Enums;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Validation;

namespace ClinicManagementSystem.Forms.MainForms
{
    public partial class PerformVisitForm : Form
    {
        public delegate void ControlButtonClickedEventHandler(object source, VisitsButtonClickedArgs args);
        public event ControlButtonClickedEventHandler ControlButtonClicked;

        public delegate void ClosingButtonClickedEventHandler(object source, PageControllingButtonClickedArgs args);
        public event ClosingButtonClickedEventHandler ClosingButtonClicked;

        private PerformVisitFormMode _mode;
        private IPatientService _patientService;
        private IAppointmentService _appointmentService;
        private IExaminationService _examinationService;
        private VisitsListForm _previousVisitsListForm;
        private PersonInfoForm _patientInfoForm;
        private PerformVisitSideFormsSet _currentVisitSet;
        private PerformVisitSideFormsSet _previousVisitSet;

        private bool _patientInfoShown = false;
        private Appointment _appointment;
        private IEnumerable<Examination> _examinations;
        private IList<Appointment> _previousAppointments;

        public PerformVisitForm(IServiceProvider provider, Appointment currentAppointment)
        {
            _patientService = provider.GetService<IPatientService>();
            _appointmentService = provider.GetService<IAppointmentService>();
            _examinationService = provider.GetService<IExaminationService>();

            InitializeComponent();

            _patientInfoForm = new PersonInfoForm();
            _appointment = currentAppointment;
            if(_appointment != null  && _appointment.Patient != null)
            {
                _patientInfoForm.InitializeValues(_appointment.Patient, _appointmentService.GetLastAppointmentDateForPatient(_appointment.Patient));
            }

            _previousAppointments = _appointmentService
                .GetAppointments(null, null, null, _appointment.Patient)
                .Where(app => app.Id != currentAppointment.Id && DateTime.Compare(app.ScheduledDate, currentAppointment.ScheduledDate) <= 0) // bez aktualnej wizyty, do dnia dzisiejszego
                .ToList();
            _previousVisitsListForm = new VisitsListForm();
            _previousVisitsListForm.PopulateList(_previousAppointments);
            _previousVisitsListForm.ElementClicked += FillSelectedVisitInformation;

            _examinations = _examinationService.GetExaminationsByType(ExaminationType.Laboratory);

            _currentVisitSet = new PerformVisitSideFormsSet(new VisitTextsForm(), new PhysicalForm(), new OrderLabForm(_examinations, _addExamination));
            SubscribeToCurrentVisitForms();

            _previousVisitSet = new PerformVisitSideFormsSet(new VisitTextsForm(), new PhysicalForm(), new OrderLabForm(Enumerable.Empty<LaboratoryExam>(), null)); // PR: null zeby wylaczyc mozliwosc dodawania badan w trzybie przegladania poprzednich
            _previousVisitSet.SetDisabled();

            _mode = PerformVisitFormMode.Interview;
            LoadLeftSideForm();
            LoadRightSideForm();

            // PR: patch issue #16: Interview/diagnosis text box bug
            OnControlButtonClicked(_mode);
        }

        private void _addExamination(string code, string examinationName, ExaminationType examinationType)
        {
            Examination examination = new Examination()
            {
                Code = code,
                ExaminationName = examinationName,
                ExamType = examinationType
            };

            ICollection<ValidationResult> validationResults = new List<ValidationResult>();
            if (!Validator.TryValidateObject(examination, new ValidationContext(examination), validationResults, true))
            {
                // obj not valid
                MessageBox.Show(string.Join('\n', validationResults.Select(r => r.ErrorMessage)), "Validation error");
                return;
            }

            if(_examinationService.GetExaminationByCode(code) == null)
            {
                try
                {
                    _examinationService.InsertExamination(examination);
                    MessageBox.Show("Examination has been successfully added.", "Add New Examination");
                }
                catch (DbEntityValidationException) // TODO change
                {
                    MessageBox.Show("Insert error.", "Add New Examination");
                }
            }
            else
            {
                MessageBox.Show("Examination already exists.", "Add New Examination");
            }
           
            //_examinations = _examinations.Append(examination);

            _currentVisitSet.OrderLabForm.PopulateList(_examinations);
            //_previousVisitSet.OrderLabForm.PopulateList(_examinations);

            _currentVisitSet.OrderLabForm.ClearTextBoxes();
        }

        private void InterviewButton_Click(object sender, EventArgs e)
        {
            if (_mode != PerformVisitFormMode.Interview)
            {
                UnloadRightSideForm();
                _mode = PerformVisitFormMode.Interview;
                LoadRightSideForm();
                OnControlButtonClicked(_mode);
            }
        }

        private void PhysicalButton_Click(object sender, EventArgs e)
        {
            if (_mode != PerformVisitFormMode.Physical)
            {
                UnloadRightSideForm();
                _mode = PerformVisitFormMode.Physical;
                LoadRightSideForm();
            }
        }

        private void LabButton_Click(object sender, EventArgs e)
        {
            if(_mode != PerformVisitFormMode.Laboratory)
               {
                UnloadRightSideForm();
                _mode = PerformVisitFormMode.Laboratory;
                LoadRightSideForm();
            }
        }

        private void DiagnosisButton_Click(object sender, EventArgs e)
        {
            if (_mode != PerformVisitFormMode.Diagnosis)
            {
                UnloadRightSideForm();
                _mode = PerformVisitFormMode.Diagnosis;
                LoadRightSideForm();
                OnControlButtonClicked(_mode);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            _appointment.CompletionDate = DateTime.Now;
            _appointment.AppointmentStatus = AppointmentStatus.Cancelled;
            _appointmentService.UpdateAppointment(_appointment);

            OnClosingButtonClicked();
        }

        private void ConcludeButton_Click(object sender, EventArgs e)
        {
            _appointment.CompletionDate = DateTime.Now;
            _appointment.AppointmentStatus = AppointmentStatus.Accepted;
            _appointment.Description = _currentVisitSet.VisitTextsForm.InterviewText;
            _appointment.Diagnosis = _currentVisitSet.VisitTextsForm.DiagnosisText;

            // lab exams:
            IList<OrderLabListElement> labListElements = _currentVisitSet.OrderLabForm.GetSelectedLabListElements();
            List<LaboratoryExam> laboratoryExams = labListElements.Select(e => new LaboratoryExam()
            {
                Appointment = _appointment,
                ReferralDate = DateTime.Now,
                Examination = e.Examination
            }).ToList();
            /* PR: nie wiem, czy:
             * 1. EF tworzy pusta liste czy nie,
             * 2. czy jest opcja, ze na tej liscie juz cos jest (nie powinno teoretycznie),
             * ale robie w ten sposob zeby sie nigdy nie wywrocilo ani zeby nie odlaczylo / usunelo jakis danych
             */
            if (_appointment.LaboratoryExams == null)
                _appointment.LaboratoryExams = laboratoryExams;
            else
                _appointment.LaboratoryExams.AddRange(laboratoryExams);


            // physical exams:
            IDictionary<Examination, string> physicalExamsTexts = new Dictionary<Examination, string>()
            {
                { Examination.TemperatureExamination, _currentVisitSet.PhysicalForm.TemperatureText },
                { Examination.BloodPressureExamination, _currentVisitSet.PhysicalForm.BloodPressureText },
                { Examination.SugarLevelExamination, _currentVisitSet.PhysicalForm.SugarLevelText }
            };
            List<PhysicalExam> physicalExams = new List<PhysicalExam>(physicalExamsTexts.Count);
            foreach (KeyValuePair<Examination, string> kvp in physicalExamsTexts)
            {
                if (!string.IsNullOrWhiteSpace(kvp.Value))
                    physicalExams.Add(new PhysicalExam()
                    {
                        Appointment = _appointment,
                        Examination = _examinationService.GetExaminationByCode(kvp.Key.Code) ?? kvp.Key, // PR: wez z bazy jesli istnieje, dodaj do bazy jesli nie
                        Result = kvp.Value.Trim()
                    });
                    
            }

            // PR: jak wyzej
            if (_appointment.PhysicalExams == null)
                _appointment.PhysicalExams = physicalExams;
            else
                _appointment.PhysicalExams.AddRange(physicalExams);

            // save:
            try
            {
                _appointmentService.UpdateAppointment(_appointment);
                MessageBox.Show("Visit has been updated.", "Update Visit");
                OnClosingButtonClicked();
            }
            catch (DbEntityValidationException) // TODO change
            {
                MessageBox.Show("Update error.", "Update Visit");
            }
        }

        private void PreviousVisitsButton_Click(object sender, EventArgs e)
        {
            UnloadRightSideForm();
            LoadLeftSideForm();
            _mode = PerformVisitFormMode.Interview;
            LoadRightSideForm();
        }


        private void OnControlButtonClicked(PerformVisitFormMode mode)
        {
            if(ControlButtonClicked !=null)
            {
                ControlButtonClicked.Invoke(this, new VisitsButtonClickedArgs(mode));
            }
        }

        private void LoadVisitsTextsForm()
        {
            if (_patientInfoShown)
            {
                this.VisitPartPanel.Controls.Add(_currentVisitSet.VisitTextsForm);
                _currentVisitSet.VisitTextsForm.Show();
            }
            else
            {
                this.VisitPartPanel.Controls.Add(_previousVisitSet.VisitTextsForm);
                _previousVisitSet.VisitTextsForm.Show();
            }
        }

        private void UnloadVisitTextsForm()
        {
            if (_patientInfoShown)
            {
                this.VisitPartPanel.Controls.Remove(_currentVisitSet.VisitTextsForm);
                _currentVisitSet.VisitTextsForm.Hide();
            }
            else
            {
                this.VisitPartPanel.Controls.Remove(_previousVisitSet.VisitTextsForm);
                _previousVisitSet.VisitTextsForm.Hide();
            }
        }

        private void LoadOrderLabForm()
        {
            if (_patientInfoShown)
            {
                this.VisitPartPanel.Controls.Add(_currentVisitSet.OrderLabForm);
                _currentVisitSet.OrderLabForm.Show();
            }
            else
            {
                this.VisitPartPanel.Controls.Add(_previousVisitSet.OrderLabForm);
                _previousVisitSet.OrderLabForm.Show();
            }
        }

        private void UnloadOrderLabForm()
        {
            if (_patientInfoShown)
            {
                this.VisitPartPanel.Controls.Remove(_currentVisitSet.OrderLabForm);
                _currentVisitSet.OrderLabForm.Hide();
            }
            else
            {
                this.VisitPartPanel.Controls.Remove(_previousVisitSet.OrderLabForm);
                _previousVisitSet.OrderLabForm.Hide();
            }
        }

        private void LoadPhysicalForm()
        {
            if (_patientInfoShown)
            {
                this.VisitPartPanel.Controls.Add(_currentVisitSet.PhysicalForm);
                _currentVisitSet.PhysicalForm.Show();
            }
            else
            {
                this.VisitPartPanel.Controls.Add(_previousVisitSet.PhysicalForm);
                _previousVisitSet.PhysicalForm.Show();
            }
        }

        private void UnloadPhysicalForm()
        {
            if (_patientInfoShown)
            {
                this.VisitPartPanel.Controls.Remove(_currentVisitSet.PhysicalForm);
                _currentVisitSet.PhysicalForm.Hide();
            }
            else
            {
                this.VisitPartPanel.Controls.Remove(_previousVisitSet.PhysicalForm);
                _previousVisitSet.PhysicalForm.Hide();
            }
        }

        private void LoadPatientInfomationForm()
        {
            PatientPanel.Controls.Add(_patientInfoForm);
            _patientInfoForm.Show();
        }

        private void UnloadPatientInfoForm()
        {
            if(_patientInfoForm!=null)
            {
                PatientPanel.Controls.Remove(_patientInfoForm);
                _patientInfoForm.Hide();
            }
        }

        private void UnloadPreviousVisitsForm()
        {
            if (_previousVisitsListForm != null)
            {
                PatientPanel.Controls.Remove(_previousVisitsListForm);
                _previousVisitsListForm.Hide();
            }
        }

        private void SubscribeToCurrentVisitForms()
        {
            ControlButtonClicked += _currentVisitSet.VisitTextsForm.OnControlButtonClicked;
        }

        private void UnsubsribeFromCurrentVisitForms()
        {
            ControlButtonClicked -= _currentVisitSet.VisitTextsForm.OnControlButtonClicked;
        }

        private void SubscribeToPreviousVisitForms()
        {
            ControlButtonClicked += _previousVisitSet.VisitTextsForm.OnControlButtonClicked;
        }

        private void UnsubscribeToPreviousVisitForms()
        {
            ControlButtonClicked -= _previousVisitSet.VisitTextsForm.OnControlButtonClicked;
        }

        private void LoadVisitsListForm()
        {
            PatientPanel.Controls.Add(_previousVisitsListForm);
            _previousVisitsListForm.Show();
        }

        private void LoadLeftSideForm()
        {
            if(!_patientInfoShown)
            {
                UnsubscribeToPreviousVisitForms();
                SubscribeToCurrentVisitForms();
                UnloadPreviousVisitsForm();
                LoadPatientInfomationForm();
                _patientInfoShown = true;
            }
            else
            {
                UnsubsribeFromCurrentVisitForms();
                SubscribeToPreviousVisitForms();
                UnloadPatientInfoForm();
                LoadVisitsListForm();
                _patientInfoShown = false;
            }
        }

        private void FillSelectedVisitInformation(object sender, ListElementClickedArgs args)
        {
            UnloadRightSideForm();

            Appointment selectedAppointment = _previousAppointments[args.Index];

            _previousVisitSet.VisitTextsForm.FillTextFields(selectedAppointment.Description, selectedAppointment.Diagnosis);
            if (selectedAppointment.LaboratoryExams != null)
                _previousVisitSet.OrderLabForm.PopulateList(selectedAppointment.LaboratoryExams);
            else
                _previousVisitSet.OrderLabForm.PopulateList(Enumerable.Empty<Examination>());
            _previousVisitSet.OrderLabForm.SetDisabled();

            if (selectedAppointment.PhysicalExams != null)
            {
                PhysicalExam bloodPressureExam = selectedAppointment.PhysicalExams.FirstOrDefault(pe => pe.Examination.Code == Examination.BloodPressureExamination.Code),
                        sugarLevelExam = selectedAppointment.PhysicalExams.FirstOrDefault(pe => pe.Examination.Code == Examination.SugarLevelExamination.Code),
                        temperatureExam = selectedAppointment.PhysicalExams.FirstOrDefault(pe => pe.Examination.Code == Examination.TemperatureExamination.Code);
                _previousVisitSet.PhysicalForm.FillFields(
                    bloodPressureExam != null ? bloodPressureExam.Result : "",
                    sugarLevelExam != null ? sugarLevelExam.Result : "",
                    temperatureExam != null ? temperatureExam.Result : ""
                );
            }
            else
            {
                _previousVisitSet.PhysicalForm.FillFields("", "", "");
            }

            LoadRightSideForm();
        }

        private void LoadRightSideForm()
        {
            switch(_mode)
            {
                case PerformVisitFormMode.Physical:
                    LoadPhysicalForm();
                    break;
                case PerformVisitFormMode.Interview:
                case PerformVisitFormMode.Diagnosis:
                    LoadVisitsTextsForm();
                    break;
                default:
                    LoadOrderLabForm();
                    break;
            }
        }

        private void UnloadRightSideForm()
        {
            switch(_mode)
            {
                case PerformVisitFormMode.Physical:
                    UnloadPhysicalForm();
                    break;
                case PerformVisitFormMode.Diagnosis:
                case PerformVisitFormMode.Interview:
                    UnloadVisitTextsForm();
                    break;
                default:
                    UnloadOrderLabForm();
                    break;
            }
        }

        private void OnClosingButtonClicked()
        {
            if (ClosingButtonClicked != null)
            {
                ClosingButtonClicked.Invoke(this, new PageControllingButtonClickedArgs(MainFormType.VisitMainForm, UserLevel.Doctor, null));
            }
        }
    }
}
