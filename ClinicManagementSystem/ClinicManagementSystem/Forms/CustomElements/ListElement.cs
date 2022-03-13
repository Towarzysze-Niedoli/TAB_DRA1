using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClinicManagementSystem.Forms.CustomElements
{
    public partial class ListElement : UserControl
    {
        public ListElement()
        {
            InitializeComponent();
        }

        public ListElement(string upperText, string lowerLeftText, string lowerRightText)
        {
            InitializeComponent();
            this.MainLabel.Text = upperText;
            this.LowerLeftLabel.Text = lowerLeftText;
            this.LowerRightLabel.Text = lowerRightText;
        }
    }
}
