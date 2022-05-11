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
        public PhysicalForm()
        {
            InitializeComponent();
            SetDocking();
        }

        private void SetDocking()
        {
            Dock = DockStyle.Fill;
            this.TopMost = true;
            this.TopLevel = false;
        }

        public void SetDisabled()
        {
            this.PreasureTextBox.Enabled = false;
            this.SugerLevelTextBox.Enabled = false;
            this.TemperatureTextBox.Enabled = false;
        }
    }
}
