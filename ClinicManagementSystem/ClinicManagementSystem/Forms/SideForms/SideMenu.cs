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
        public SideMenu(UserLevel level, Action openVisitForms, Action openLaboratoryForms, Action openManagerDoctorForms, Action openManagerPatientForms, Action openManagerLabForms, Action openManagerReceptionistForms)
        {
            InitializeComponent();
            SetComponentsVisiblity(level);
            _openVisitsForm += openVisitForms;
            _openLaboratoryForm += openLaboratoryForms;
            _openManagerDoctorForm += openManagerDoctorForms;
            _openManagerPatientForm += openManagerPatientForms;
            _openManagerLabForm += openManagerLabForms;
            _openManagerReceptionistForm += openManagerReceptionistForms;
        }

        private void SetComponentsVisiblity(UserLevel level)
        {
            if(level == UserLevel.Manager)
            {
                this.VisitsButton.Show();
                this.MedicsButton.Show();
                this.PatiensButton.Show();
                this.LaboratoryButton.Show();
                this.ReceptionistButton.Show();
            }
            else if(level == UserLevel.Doctor)
            {
                this.VisitsButton.Show();
                this.PatiensButton.Show();
                this.MedicsButton.Hide();
                this.LaboratoryButton.Hide();
                this.ReceptionistButton.Hide();
            }
            else if(level == UserLevel.Laborant || level == UserLevel.HeadOfLab)
            {
                this.LaboratoryButton.Show();
                this.VisitsButton.Hide();
                this.ReceptionistButton.Hide();
                this.MedicsButton.Hide();
                this.PatiensButton.Hide();
            }
            else
            {
                this.VisitsButton.Show();
                this.MedicsButton.Show();
                this.PatiensButton.Show();
                this.LaboratoryButton.Show();
                this.ReceptionistButton.Hide();
            }
        }

        private void VisitsButton_Click(object sender, EventArgs e)
        {
            SetTabsColors(SideMenuTab.Visits);
            _openVisitsForm.Invoke();
        }

        private void MedicsButton_Click(object sender, EventArgs e)
        {
            SetTabsColors(SideMenuTab.Medics);
            _openManagerDoctorForm.Invoke();
        }

        private void PatiensButton_Click(object sender, EventArgs e)
        {
            SetTabsColors(SideMenuTab.Patients);
            _openManagerPatientForm.Invoke();
        }

        private void LaboratoryButton_Click(object sender, EventArgs e)
        {
            SetTabsColors(SideMenuTab.Laboratory);
            _openLaboratoryForm.Invoke();
            //_openManagerLabForm.Invoke();
        }

        private void ReceptionistButton_Click(object sender, EventArgs e)
        {
            SetTabsColors(SideMenuTab.Management);
            _openManagerReceptionistForm.Invoke();
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
                    this.ReceptionistButton.BackColor = Color.FromArgb(73, 88, 103);
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
                    this.ReceptionistButton.BackColor = Color.FromArgb(189, 213, 234);
                    break;
            }
        }
    }
}
