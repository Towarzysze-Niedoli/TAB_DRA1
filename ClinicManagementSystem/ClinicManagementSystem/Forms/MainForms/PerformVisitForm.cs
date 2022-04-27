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
    public partial class PerformVisitForm : Form
    {
        public delegate void ControlButtonClickedEventHandler(object source, VisitsButtonClickedArgs args);
        public event ControlButtonClickedEventHandler ControlButtonClicked;

        private DoctorListForm _previusVisitsListForm;
        private PersonInfoForm _patientInfoForm;
        private VisitTextsForm _visitTextsForm;

        private bool _patientInfoShown = false;

        public PerformVisitForm()
        {
            InitializeComponent();

            LoadNewVisitsTextsForm();
            LoadLeftSideForm();
        }

        private void InterviewButton_Click(object sender, EventArgs e)
        {
            OnControlButtonClicked(VisitsTextFieldMode.Interview);
        }

        private void PhysicalButton_Click(object sender, EventArgs e)
        {
            OnControlButtonClicked(VisitsTextFieldMode.Physical);
        }

        private void LabButton_Click(object sender, EventArgs e)
        {
            OnControlButtonClicked(VisitsTextFieldMode.Laboratory);
        }

        private void DiagnosisButton_Click(object sender, EventArgs e)
        {
            OnControlButtonClicked(VisitsTextFieldMode.Diagnosis);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

        }

        private void ConcludeButton_Click(object sender, EventArgs e)
        {

        }

        private void PreviousVisitsButton_Click(object sender, EventArgs e)
        {
            LoadLeftSideForm();
        }

        private void OnControlButtonClicked(VisitsTextFieldMode mode)
        {
            if(ControlButtonClicked !=null)
            {
                ControlButtonClicked.Invoke(this, new VisitsButtonClickedArgs(mode));
            }
        }

        private void LoadNewVisitsTextsForm()
        {
            _visitTextsForm = new VisitTextsForm();
            ControlButtonClicked = _visitTextsForm.OnControlButtonClicked;
            this.VisitPartPanel.Controls.Add(_visitTextsForm);
            _visitTextsForm.Show();
        }

        private void LoadPatientInfomationForm()
        {
            _patientInfoForm = new PersonInfoForm();
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


        private void LoadVisitsListForm()
        {
            _previusVisitsListForm = new DoctorListForm();
            _previusVisitsListForm.ElementClicked += FillSelectedVisitInformation;
            PatientPanel.Controls.Add(_previusVisitsListForm);
            _previusVisitsListForm.Show();
        }

        private void LoadLeftSideForm()
        {
            if(!_patientInfoShown)
            {
                UnloadPreviousVisitsForm();
                LoadPatientInfomationForm();
                _patientInfoShown = true;
            }
            else
            {
                UnloadPatientInfoForm();
                LoadVisitsListForm();
                _patientInfoShown = false;
            }
        }

        private void FillSelectedVisitInformation(object sender, ListElementClickedArgs args)
        {

        }
    }
}
