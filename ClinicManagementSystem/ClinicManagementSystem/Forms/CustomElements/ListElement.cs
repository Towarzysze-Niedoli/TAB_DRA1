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
        public ListElement(string upperText, string bottomLeftText, string bottomRightText)
        {
            InitializeComponent();
            this.UpperMainLabel.Text = upperText;
            this.BottomLabelOne.Text = bottomLeftText;
            this.BottomLabelTwo.Text = bottomRightText;
        }

        private void ListElement_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(87, 115, 153);
        }

        private void ListElement_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(189, 213, 234);
        }

        private void ListElement_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.FromArgb(73, 88, 103);
        }
    }
}
