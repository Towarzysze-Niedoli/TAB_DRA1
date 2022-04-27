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
        private VisitsTextFieldMode _mode;

        private string _interviewText;
        private string _physicalText;
        private string _labText;
        private string _diagnosisText;
        
        public VisitTextsForm()
        {
            InitializeComponent();
            SetDocking();
        }

        public VisitTextsForm(string interviewText, string physicalText, string labText, string diagnosisText)
        {
            InitializeComponent();
            _interviewText = interviewText;
            _physicalText = physicalText;
            _labText = labText;
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

        private void SaveCurrentTextField()
        {
            switch(_mode)
            {
                case VisitsTextFieldMode.Diagnosis:
                    _diagnosisText = TextBox.Text;
                    break;
                case VisitsTextFieldMode.Interview:
                    _interviewText = TextBox.Text;
                    break;
                case VisitsTextFieldMode.Laboratory:
                    _labText = TextBox.Text;
                    break;
                default:
                    _physicalText = TextBox.Text;
                    break;
            }
        }

        private void ChangeTextFieldText()
        {
            switch (_mode)
            {
                case VisitsTextFieldMode.Diagnosis:
                    TextBox.Text = _diagnosisText; 
                    break;
                case VisitsTextFieldMode.Interview:
                    TextBox.Text = _interviewText;
                    break;
                case VisitsTextFieldMode.Laboratory:
                    TextBox.Text = _labText;
                    break;
                default:
                    TextBox.Text = _physicalText;
                    break;
            }
        }

        private void SetDocking()
        {
            Dock = DockStyle.Fill;
            this.TopMost = true;
            this.TopLevel = false;
            _mode = VisitsTextFieldMode.Diagnosis;
        }
    }
}
