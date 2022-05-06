using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClinicManagementSystem.Forms.SideForms
{
    public partial class SideMenu : Form
    {
        private Action _openVisitsForm;

        private Action _openLaboratoryForm;

        private Action _openManagerDoctorForm;

        private Action _openManagerPatientForm;

        private Action _openManagerLabForm;

        private Action _openManagerReceptionistForm;

        private SideMenuTab _currentTab;

        private UserLevel _userLevel;
        public SideMenu(UserLevel level, Action openVisitForms, Action  openLaboratoryForm, Action openManagerDoctorForms,
            Action openManagerPatientForms, Action openManagerLabForms, Action openManagerReceptionistForms)
        {
            InitializeComponent();

            _userLevel = level;
            SetComponentsVisiblity();
            _openVisitsForm += openVisitForms;
            _openLaboratoryForm = openLaboratoryForm;
            _openManagerDoctorForm += openManagerDoctorForms;
            _openManagerPatientForm += openManagerPatientForms;
            _openManagerLabForm += openManagerLabForms;
            _openManagerReceptionistForm += openManagerReceptionistForms;
        }

        private void SetComponentsVisiblity()
        {
            if(_userLevel == UserLevel.Manager)
            {
                this.VisitsButton.Show();
                this.MedicsButton.Show();
                this.PatiensButton.Show();
                this.LaboratoryButton.Show();
                this.ManagementButton.Show();
            }
            else if(_userLevel == UserLevel.Doctor)
            {
                this.VisitsButton.Show();
                this.PatiensButton.Show();
                this.MedicsButton.Hide();
                this.LaboratoryButton.Hide();
                this.ManagementButton.Hide();
            }
            else if(_userLevel == UserLevel.Laborant || _userLevel == UserLevel.HeadOfLab)
            {
                this.LaboratoryButton.Show();
                this.VisitsButton.Hide();
                this.ManagementButton.Hide();
                this.MedicsButton.Hide();
                this.PatiensButton.Hide();
            }
            else
            {
                this.VisitsButton.Show();
                this.MedicsButton.Show();
                this.PatiensButton.Show();
                this.LaboratoryButton.Show();
                this.ManagementButton.Hide();
            }
        }

        private void VisitsButton_Click(object sender, EventArgs e)
        {
            SetTabsColors(SideMenuTab.Visits);
            _openVisitsForm.Invoke();
        }

        private void MedicsButton_Click(object sender, EventArgs e)
        {
            _openManagerDoctorForm.Invoke();
            SetTabsColors(SideMenuTab.Medics);
        }

        private void PatiensButton_Click(object sender, EventArgs e)
        {
            _openManagerPatientForm.Invoke();

            SetTabsColors(SideMenuTab.Patients);
        }

        private void LaboratoryButton_Click(object sender, EventArgs e)
        {
            if (_userLevel == UserLevel.Manager)
            {
                _openManagerLabForm.Invoke();
            }
            else if (_userLevel == UserLevel.Laborant || _userLevel == UserLevel.HeadOfLab)
            {
                _openLaboratoryForm.Invoke();
            }
            SetTabsColors(SideMenuTab.Laboratory);
        }

        private void ManagementButton_Click(object sender, EventArgs e)
        {
            _openManagerReceptionistForm.Invoke();
            SetTabsColors(SideMenuTab.Management);
        }

        private void SetTabsColors(SideMenuTab nextTab)
        {
            SetTabInactive();
            _currentTab = nextTab;
            SetTabActive();
        }
        
        private void SetTabActive()
        {
            switch (_currentTab)
            {
                case SideMenuTab.Visits:
                    this.VisitsButton.BackColor = Color.FromArgb(73, 88, 103);
                    break;
                case SideMenuTab.Patients:
                    this.PatiensButton.BackColor = Color.FromArgb(73, 88, 103);
                    break;
                case SideMenuTab.Medics:
                    this.MedicsButton.BackColor = Color.FromArgb(73, 88, 103);
                    break;
                case SideMenuTab.Laboratory:
                    this.LaboratoryButton.BackColor = Color.FromArgb(73, 88, 103);
                    break;
                default:
                    this.ManagementButton.BackColor = Color.FromArgb(73, 88, 103);
                    break;
            }
        }

        private void SetTabInactive()
        {
            switch (_currentTab)
            {
                case SideMenuTab.Visits:
                    this.VisitsButton.BackColor = Color.FromArgb(189, 213, 234);
                    break;
                case SideMenuTab.Patients:
                    this.PatiensButton.BackColor = Color.FromArgb(189, 213, 234);
                    break;
                case SideMenuTab.Medics:
                    this.MedicsButton.BackColor = Color.FromArgb(189, 213, 234);
                    break;
                case SideMenuTab.Laboratory:
                    this.LaboratoryButton.BackColor = Color.FromArgb(189, 213, 234);
                    break;
                default:
                    this.ManagementButton.BackColor = Color.FromArgb(189, 213, 234);
                    break;
            }
        }
    }
}
