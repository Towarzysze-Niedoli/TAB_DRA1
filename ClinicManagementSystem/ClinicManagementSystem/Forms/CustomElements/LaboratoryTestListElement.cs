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
    public partial class LaboratoryTestListElement : ListElement
    {
        public string TestName { get; set; }
        public string Date { get; set; }

        public LaboratoryTestListElement(int index, string upperText, string lowerText): base(index)
        {
            InitializeComponent();
            this.UpperMainLabel.Text = upperText;
            this.BottomLabelOne.Text = lowerText;
            TestName = upperText;
            Date = lowerText;           
        }

        protected override void ListElement_MouseDown(object sender, MouseEventArgs e)
        {
            SetNoHoverColor();
            OnListElementClicked(new EventArguments.ListElementClickedArgs(_index));
        }
    }
}
