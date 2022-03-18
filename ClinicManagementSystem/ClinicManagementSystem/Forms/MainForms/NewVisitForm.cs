﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClinicManagementSystem.Forms.SideForms;

namespace ClinicManagementSystem.Forms.MainForms
{
    public partial class NewVisitForm : Form
    {
        ListForm DoctorsList;
        public NewVisitForm()
        {
            InitializeComponent();
            InitializeList();
        }

        void InitializeList()
        {
            DoctorsList = new ListForm();
            this.DoctorsListPanel.Controls.Add(DoctorsList);
            DoctorsList.Show();
        }

        private void SearchPatientButton_Click(object sender, EventArgs e)
        {

        }

        private void NewVisitButton_Click(object sender, EventArgs e)
        {

        }

        private void NewPatientButton_Click(object sender, EventArgs e)
        {

        }
    }
}
