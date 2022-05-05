﻿using System;
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
    public partial class PerformVisitForm : Form
    {
        public delegate void ControlButtonClickedEventHandler(object source, VisitsButtonClickedArgs args);
        public event ControlButtonClickedEventHandler ControlButtonClicked;

        private PerformVisitFormMode _mode;

        private DoctorListForm _previusVisitsListForm;
        private PersonInfoForm _patientInfoForm;
        private PerformVisitSideFormsSet _currentVisitSet;
        private PerformVisitSideFormsSet _previusVisitSet;

        private bool _patientInfoShown = false;

        public PerformVisitForm()
        {
            InitializeComponent();

            _previusVisitsListForm = new DoctorListForm();
            _previusVisitsListForm.ElementClicked += FillSelectedVisitInformation;

            _patientInfoForm = new PersonInfoForm();

            _currentVisitSet = new PerformVisitSideFormsSet(new VisitTextsForm(), new PhysicalForm(), new OrderLabForm());
            SubscribeToCurrentVisitForms();

            _previusVisitSet = new PerformVisitSideFormsSet(new VisitTextsForm(), new PhysicalForm(), new OrderLabForm());
            _previusVisitSet.SetDisabled();

            _mode = PerformVisitFormMode.Interview;
            LoadLeftSideForm();
            LoadRightSideForm();
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

        }

        private void ConcludeButton_Click(object sender, EventArgs e)
        {

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
                this.VisitPartPanel.Controls.Add(_previusVisitSet.VisitTextsForm);
                _previusVisitSet.VisitTextsForm.Show();
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
                this.VisitPartPanel.Controls.Remove(_previusVisitSet.VisitTextsForm);
                _previusVisitSet.VisitTextsForm.Hide();
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
                this.VisitPartPanel.Controls.Add(_previusVisitSet.OrderLabForm);
                _previusVisitSet.OrderLabForm.Show();
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
                this.VisitPartPanel.Controls.Remove(_previusVisitSet.OrderLabForm);
                _previusVisitSet.OrderLabForm.Hide();
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
                this.VisitPartPanel.Controls.Add(_previusVisitSet.PhysicalForm);
                _previusVisitSet.PhysicalForm.Show();
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
                this.VisitPartPanel.Controls.Remove(_previusVisitSet.PhysicalForm);
                _previusVisitSet.PhysicalForm.Hide();
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
            if (_previusVisitsListForm != null)
            {
                PatientPanel.Controls.Remove(_previusVisitsListForm);
                _previusVisitsListForm.Hide();
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
            ControlButtonClicked += _previusVisitSet.VisitTextsForm.OnControlButtonClicked;
        }

        private void UnsubscribeToPreviousVisitForms()
        {
            ControlButtonClicked -= _previusVisitSet.VisitTextsForm.OnControlButtonClicked;
        }

        private void LoadVisitsListForm()
        {
            PatientPanel.Controls.Add(_previusVisitsListForm);
            _previusVisitsListForm.Show();
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
    }
}