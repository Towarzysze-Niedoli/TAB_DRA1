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
    public partial class VisitsMainForm : Form
    {
        private Action _nextPageActiom;

        private ListForm _visitsListForm;
        public VisitsMainForm(Action nextPageAction)
        {
            InitializeComponent();

            _nextPageActiom += nextPageAction;

            _visitsListForm = new VisitsListForm();
            _visitsListForm.ElementClicked += FillVisitTextFields;
            this.VisitsListPanel.Controls.Add(_visitsListForm);

            _visitsListForm.Show();
        }

        private void NewVisitButton_Click(object sender, EventArgs e)
        {
            _nextPageActiom.Invoke();
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
            _nextPageActiom.Invoke();
        }
    }
}