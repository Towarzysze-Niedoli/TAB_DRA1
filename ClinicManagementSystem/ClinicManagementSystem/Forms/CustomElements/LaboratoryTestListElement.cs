using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using ClinicManagementSystem.Forms.SideForms;
using ClinicManagementSystem.Forms.EventArguments;

namespace ClinicManagementSystem.Forms.CustomElements
{
    public partial class LaboratoryTestListElement : UserControl
    {

        public delegate void LabTestElementClickedEventHandler(object sender, LaboratoryListElementClickedArgs args); //zmiana //chyba do wywalenia
        public event LabTestElementClickedEventHandler LabTestElementClicked;

       // LaboratoryTestResults LabResults;

        public string results;
        public string testName;
        public string date;

        public LaboratoryTestListElement(string upperText, string lowerText)
        {
            InitializeComponent();
            this.UpperMainLabel.Text = upperText;
            this.BottomLabelOne.Text = lowerText;
            testName = upperText;
            date = lowerText;
            
        }

        public void SetResults(string res)
        {
            results = res;
        }

        private void LabTestElement_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(87, 115, 153);
        }

        private void LabTestElement_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(189, 213, 234);
        }

        protected void OnClickLabTestElementClicked(LaboratoryListElementClickedArgs args)
        {
           // testName = args.TestName;
           // results = args.Results;
           //LabTestElementClicked
            LabTestElementClicked?.Invoke(this, args);
           // OnClickLabTestElementClicked(this, args);
        }

        private void LabTestElement_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.FromArgb(73, 88, 103);
            OnClickLabTestElementClicked(new EventArguments.LaboratoryListElementClickedArgs(testName, results));
            
        }
    }
}
