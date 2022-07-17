using ClinicManagementSystem.Forms.CustomElements;
using ClinicManagementSystem.Forms.EventArguments;
using ClinicManagementSystem.Forms.MainForms;
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


        protected void WriteLaboratoryResults(object source, LaboratoryListElementClickedArgs args)
        {
            TestName.Text = args.TestName;
            TestResults.Text = args.Results;
        }

        public void SetDisabled()
        {
            TestResults.Enabled = false;
        }
    }
}
