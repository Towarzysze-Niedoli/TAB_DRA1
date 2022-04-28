using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClinicManagementSystem.Forms.MainForms
{
    public partial class ManagerForm : Form
    {
        private int whichForm;
        public ManagerForm(int num)
        {
            this.whichForm = num;
            InitializeComponent();
            SpecializationComboBox.SelectedIndex = 0;
            ShowCorrectElements();
        }

        private void HideForDoctor()
        {
            LabTechicianRadioButton.Hide();
            LabManagerRadioButton.Hide();
            UpdateButton.Hide();
            DeleteButton.Hide();
        }

        private void HideForLab()
        {
            DoctoralLabel.Hide();
            SpecializationComboBox.Hide();
        }
        private void ShowCorrectElements()
        {
            switch(whichForm)
            {
                case 1:
                    HideForDoctor();
                    break;
                case 2:
                    HideForLab();
                    break;
                default:
                    HideForDoctor();
                    HideForLab();
                    break;
            }
        }

    }
}
