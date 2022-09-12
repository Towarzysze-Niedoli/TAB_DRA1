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

        public LaboratoryTestListElement(int index, string testName, string date): base(index)
        {
            InitializeComponent();
            UpperMainLabel.Text = TestName = testName;
            BottomLabelOne.Text = Date = date;          
        }

        protected override void ListElement_MouseDown(object sender, MouseEventArgs e)
        {
            SetNoHoverColor();
            OnListElementClicked(new EventArguments.ListElementClickedArgs(_index));
        }
    }
}
