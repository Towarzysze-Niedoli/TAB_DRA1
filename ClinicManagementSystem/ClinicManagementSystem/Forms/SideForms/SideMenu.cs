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

        private SideMenuTab _currentTab;
        public SideMenu(UserLevel level, Action openVisitForms, Action openLaboratoryForms)
        {
            InitializeComponent();
            SetComponentsVisiblity(level);
            _openVisitsForm += openVisitForms;
            _openLaboratoryForm += openLaboratoryForms;//tutaj
        }

        private void SetComponentsVisiblity(UserLevel level)
        {
            if(level == UserLevel.Manager)
            {
                this.VisitsButton.Show();
                this.MedicsButton.Show();
                this.PatiensButton.Show();
                this.LaboratoryButton.Show();
                this.ManagementButton.Show();
            }
            else if(level == UserLevel.Doctor)
            {
                this.VisitsButton.Show();
                this.PatiensButton.Show();
                this.MedicsButton.Hide();
                this.LaboratoryButton.Hide();
                this.ManagementButton.Hide();
            }
            else if(level == UserLevel.Laborant || level == UserLevel.HeadOfLab)
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
            SetTabsColors(SideMenuTab.Medics);
        }

        private void PatiensButton_Click(object sender, EventArgs e)
        {
            SetTabsColors(SideMenuTab.Patients);
        }

        private void LaboratoryButton_Click(object sender, EventArgs e)
        {
            SetTabsColors(SideMenuTab.Laboratory);
            _openLaboratoryForm.Invoke();
        }

        private void ManagementButton_Click(object sender, EventArgs e)
        {
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
