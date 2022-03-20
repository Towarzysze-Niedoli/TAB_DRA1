﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicManagementSystem.Forms.SideForms;
using ClinicManagementSystem.Forms.MainForms;

namespace ClinicManagementSystem.Forms.MainForms
{
    public partial class MainWindow : Form
    {
        private Form _currentMainForm;
        private Form _currentSideForm;
        public MainWindow()
        {
            InitializeComponent();
            ShowLoginForm();
            this.LogoutButton.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowLoginForm()
        {
            _currentSideForm = new LoginForm(LoginButtonClicked);
            InitializeForm(_currentSideForm, FormType.SideForm);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.MainPanel.Controls.Remove(_currentMainForm);
            this.LogoBox.Show();
            this.LogoText.Show();
            this.LogoutButton.Hide();
            ShowLoginForm();
        }

        private void LoginButtonClicked()
        {
            this.LogoBox.Hide();
            this.LogoText.Hide();
            this.LogoutButton.Show();
            this.SideUpperPanel.Controls.Remove(_currentSideForm);
            ShowSideMenuForm(UserLevel.Manager);
        }

        private void ShowSideMenuForm(UserLevel level)
        {
            _currentSideForm = new SideMenu(level, ShowNewVisitForm, ShowLaboratoryForm);//tutaj
            InitializeForm(_currentSideForm, FormType.SideForm);
        }

        private void ShowNewVisitForm()
        {
            this.MainPanel.Controls.Remove(_currentMainForm);
            _currentMainForm = new NewVisitForm();
            InitializeForm(_currentMainForm, FormType.MainForm);
        }

        private void ShowLaboratoryForm()//tutaj
        {
            this.MainPanel.Controls.Remove(_currentMainForm);
            _currentMainForm = new LaboratoryForm();
            InitializeForm(_currentMainForm, FormType.MainForm);
        }

        private void InitializeForm(Form form, FormType type)
        {
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.TopMost = true;
            if (type == FormType.SideForm)
            {
                this.SideUpperPanel.Controls.Add(form);
            }
            else if(type == FormType.MainForm)
            {
                this.MainPanel.Controls.Add(form);
            }
            form.Show();
        }
    }
}
