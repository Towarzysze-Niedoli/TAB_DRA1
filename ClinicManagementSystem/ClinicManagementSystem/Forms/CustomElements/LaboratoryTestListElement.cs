using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ClinicManagementSystem.Forms.CustomElements
{
    public partial class LaboratoryTestListElement : UserControl
    {
        public LaboratoryTestListElement(string upperText, string lowerText)
        {
            InitializeComponent();
            this.UpperMainLabel.Text = upperText;
            this.BottomLabelOne.Text = lowerText;
            
        }

        private void LabTestElement_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(87, 115, 153);
        }

        private void LabTestElement_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(189, 213, 234);
        }

        private void LabTestElement_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.FromArgb(73, 88, 103);
        }
    }
}
