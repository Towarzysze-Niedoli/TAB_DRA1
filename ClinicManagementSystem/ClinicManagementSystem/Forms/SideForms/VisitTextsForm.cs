using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClinicManagementSystem.Forms.EventArguments;

namespace ClinicManagementSystem.Forms.SideForms
{
    public partial class VisitTextsForm : Form
    {
        private PerformVisitFormMode _mode;

        private string _interviewText;
        private string _diagnosisText;

        public string InterviewText {
            get {
                SaveCurrentTextField();
                return _interviewText;
            }
        }
        public string DiagnosisText
        {
            get
            {
                SaveCurrentTextField();
                return _diagnosisText;
            }
        }

        public VisitTextsForm()
        {
            InitializeComponent();
            SetDocking();
        }

        public VisitTextsForm(string interviewText, string diagnosisText)
        {
            InitializeComponent();
            _interviewText = interviewText;
            _diagnosisText = diagnosisText;

            SetDocking();
            ChangeTextFieldText();
        }

        public void OnControlButtonClicked(object source, VisitsButtonClickedArgs args)
        {
            SaveCurrentTextField();
            _mode = args.Mode;
            ChangeTextFieldText();
        }

        public void SetDisabled()
        {
            this.TextBox.Enabled = false;
        }

        private void SaveCurrentTextField()
        {
            if(_mode == PerformVisitFormMode.Diagnosis)
            {
                _diagnosisText = TextBox.Text;
            }
            else
            {
                _interviewText = TextBox.Text;
            }
        }

        private void ChangeTextFieldText()
        {
            if (_mode == PerformVisitFormMode.Diagnosis)
            {
                TextBox.Text = _diagnosisText;
            }
            else
            {
                TextBox.Text = _interviewText;
            }
        }

        private void SetDocking()
        {
            Dock = DockStyle.Fill;
            this.TopMost = true;
            this.TopLevel = false;
            _mode = PerformVisitFormMode.Diagnosis;
        }
    }
}
