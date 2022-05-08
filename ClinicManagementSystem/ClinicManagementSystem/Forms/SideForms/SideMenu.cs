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
    public partial class SideMenu : Form
    {
        public delegate void NextPageButtonClicked(object source, PageControllingButtonClickedArgs args);

        public event NextPageButtonClicked ButtonClicked;

        private SideMenuTab _currentTab;

        private UserLevel _userLevel;
        public SideMenu(UserLevel level)
        {
            InitializeComponent();

            _userLevel = level;
            SetComponentsVisiblity();
        }

        private void SetComponentsVisiblity()
        {
            if(_userLevel == UserLevel.Manager)
            {
                this.VisitsButton.Hide();
                this.MedicsButton.Show();
                this.PatiensButton.Hide();
                this.LaboratoryButton.Show();
                this.ManagementButton.Show();
            }
            else if(_userLevel == UserLevel.Doctor)
            {
                this.VisitsButton.Show();
                this.PatiensButton.Hide();
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
                this.MedicsButton.Hide();
                this.PatiensButton.Show();
                this.LaboratoryButton.Hide();
                this.ManagementButton.Hide();
            }
        }

        private void VisitsButton_Click(object sender, EventArgs e)
        {
            SetTabsColors(SideMenuTab.Visits);
            if(_userLevel == UserLevel.Doctor || _userLevel == UserLevel.Receptionist)
            {
                this.ButtonClicked.Invoke(this, new PageControllingButtonClickedArgs(MainForms.MainFormType.VisitMainForm, _userLevel));
            }
        }

        private void MedicsButton_Click(object sender, EventArgs e)
        {
            SetTabsColors(SideMenuTab.Medics);
            if(_userLevel == UserLevel.Manager)
            {
                this.ButtonClicked.Invoke(this, new PageControllingButtonClickedArgs(MainForms.MainFormType.ManagerDoctors, _userLevel));
            }
        }

        private void PatiensButton_Click(object sender, EventArgs e)
        {
            SetTabsColors(SideMenuTab.Patients);
            if(_userLevel == UserLevel.Receptionist)
            {
                this.ButtonClicked.Invoke(this, new PageControllingButtonClickedArgs(MainForms.MainFormType.ManagerPatients, _userLevel));
            }
        }

        private void LaboratoryButton_Click(object sender, EventArgs e)
        {
            if (_userLevel == UserLevel.Manager)
            {
                this.ButtonClicked.Invoke(this, new PageControllingButtonClickedArgs(MainForms.MainFormType.ManagerLaboratory, _userLevel));
            }
            else if (_userLevel == UserLevel.Laborant || _userLevel == UserLevel.HeadOfLab)
            {
                this.ButtonClicked.Invoke(this, new PageControllingButtonClickedArgs(MainForms.MainFormType.Laboratory, _userLevel));
            }
            SetTabsColors(SideMenuTab.Laboratory);
        }

        private void ManagementButton_Click(object sender, EventArgs e)
        {
            this.ButtonClicked.Invoke(this, new PageControllingButtonClickedArgs(MainForms.MainFormType.ManagerReceptionist, _userLevel));
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
