using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    public partial class SideMenu : Form
    {
        private Action _openVisitsForm;
        public SideMenu(UserLevel level, Action openVisitForms)
        {
            InitializeComponent();
            SetComponentsVisiblity(level);
            _openVisitsForm += openVisitForms;
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
            SetButtonsColors(0);
            _openVisitsForm.Invoke();
        }

        private void MedicsButton_Click(object sender, EventArgs e)
        {
            SetButtonsColors(1);
        }

        private void PatiensButton_Click(object sender, EventArgs e)
        {
            SetButtonsColors(2);
        }

        private void LaboratoryButton_Click(object sender, EventArgs e)
        {
            SetButtonsColors(3);
        }

        private void ManagementButton_Click(object sender, EventArgs e)
        {
            SetButtonsColors(4);
        }

        private void SetButtonsColors(int activeIndex)
        {
            switch (activeIndex)
            {
                case 0:
                    this.VisitsButton.BackColor = Color.FromArgb(73, 88, 103);
                    this.MedicsButton.BackColor = Color.FromArgb(189, 213, 234);
                    this.PatiensButton.BackColor = Color.FromArgb(189, 213, 234);
                    this.LaboratoryButton.BackColor = Color.FromArgb(189, 213, 234);
                    this.ManagementButton.BackColor = Color.FromArgb(189, 213, 234);
                    break;
                case 1:
                    this.VisitsButton.BackColor = Color.FromArgb(189, 213, 234);
                    this.MedicsButton.BackColor = Color.FromArgb(73, 88, 103);
                    this.PatiensButton.BackColor = Color.FromArgb(189, 213, 234);
                    this.LaboratoryButton.BackColor = Color.FromArgb(189, 213, 234);
                    this.ManagementButton.BackColor = Color.FromArgb(189, 213, 234);
                    break;
                case 2:
                    this.VisitsButton.BackColor = Color.FromArgb(189, 213, 234);
                    this.MedicsButton.BackColor = Color.FromArgb(189, 213, 234);
                    this.PatiensButton.BackColor = Color.FromArgb(73, 88, 103);
                    this.LaboratoryButton.BackColor = Color.FromArgb(189, 213, 234);
                    this.ManagementButton.BackColor = Color.FromArgb(189, 213, 234);
                    break;
                case 3:
                    this.VisitsButton.BackColor = Color.FromArgb(189, 213, 234);
                    this.MedicsButton.BackColor = Color.FromArgb(189, 213, 234);
                    this.PatiensButton.BackColor = Color.FromArgb(189, 213, 234);
                    this.LaboratoryButton.BackColor = Color.FromArgb(73, 88, 103);
                    this.ManagementButton.BackColor = Color.FromArgb(189, 213, 234);
                    break;
                default:
                    this.VisitsButton.BackColor = Color.FromArgb(189, 213, 234);
                    this.MedicsButton.BackColor = Color.FromArgb(189, 213, 234);
                    this.PatiensButton.BackColor = Color.FromArgb(189, 213, 234);
                    this.LaboratoryButton.BackColor = Color.FromArgb(189, 213, 234);
                    this.ManagementButton.BackColor = Color.FromArgb(73, 88, 103);
                    break;
            }
        } 
    }
}
