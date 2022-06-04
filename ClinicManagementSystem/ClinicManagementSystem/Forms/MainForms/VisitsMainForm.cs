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
    public partial class VisitsMainForm : Form
    {
        public delegate void NextPageButtonClicked(object source, PageControllingButtonClickedArgs args);

        public event NextPageButtonClicked ButtonClicked;

        private ListForm _visitsListForm;

        private UserLevel _level;

        public VisitsMainForm(UserLevel level)
        {
            InitializeComponent();
            SearchPatientTextBox.KeyDown += (sender, args) => { // search on enter click
                if (args.KeyCode == Keys.Enter || args.KeyCode == Keys.Return)
                    SearchPatientButton_Click(sender, args);
            };

            _level = level;
            SetVisibility();
            _visitsListForm = new VisitsListForm();
            _visitsListForm.ElementClicked += FillVisitTextFields;
            this.VisitsListPanel.Controls.Add(_visitsListForm);

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
    }
}
