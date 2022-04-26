using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClinicManagementSystem.Forms.SideForms
{
    public partial class LaboratoryTestResults : Form
    {
        public LaboratoryTestResults()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            this.TopMost = true;
            this.TopLevel = false;
        }
    }
}
