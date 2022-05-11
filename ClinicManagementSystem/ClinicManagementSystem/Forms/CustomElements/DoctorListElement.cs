using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClinicManagementSystem.Forms.CustomElements
{
    public partial class DoctorListElement : ListElement
    {
        public DoctorListElement(int index, string upperText, string bottomLeftText, string bottomRightText) : base(index)
        {
            InitializeComponent();
            this.UpperMainLabel.Text = upperText;
            this.BottomLabelOne.Text = bottomLeftText;
            this.BottomLabelTwo.Text = bottomRightText;
            
        }

        protected override void ListElement_MouseDown(object sender, MouseEventArgs e)
        {
            SetNoHoverColor();
            OnListElementClicked(new EventArguments.ListElementClickedArgs(_index));
        }
    }
}
