using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClinicManagementSystem.Forms.MainForms
{
    public partial class VisitsMainForm : Form
    {
        private Action _newVisitAction;
        public VisitsMainForm(Action newVisitAction)
        {
            InitializeComponent();
            _newVisitAction += newVisitAction;
        }

        private void NewVisitButton_Click(object sender, EventArgs e)
        {
            _newVisitAction.Invoke();
        }

        private void CancelVisitButton_Click(object sender, EventArgs e)
        {
            
        }

        private void SearchPatientButton_Click(object sender, EventArgs e)
        {

        }
    }
}
