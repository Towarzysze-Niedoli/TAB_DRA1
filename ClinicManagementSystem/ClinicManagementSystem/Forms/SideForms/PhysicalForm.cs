using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClinicManagementSystem.Forms.SideForms
{
    public partial class PhysicalForm : Form
    {
        public string BloodPressureText { get => PressureTextBox.Text; }
        public string SugarLevelText { get => SugarLevelTextBox.Text; }
        public string TemperatureText { get => TemperatureTextBox.Text; }

        public PhysicalForm()
        {
            InitializeComponent();
            SetDocking();
        }

        public void FillFields(string bloodPressureText, string sugarLevelText, string temperatureText)
        {
            PressureTextBox.Text = bloodPressureText;
            SugarLevelTextBox.Text = sugarLevelText;
            TemperatureTextBox.Text = temperatureText;
        }

        private void SetDocking()
        {
            Dock = DockStyle.Fill;
            this.TopMost = true;
            this.TopLevel = false;
        }

        public void SetDisabled()
        {
            this.PressureTextBox.Enabled = false;
            this.SugarLevelTextBox.Enabled = false;
            this.TemperatureTextBox.Enabled = false;
        }
    }
}
