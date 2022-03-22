using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClinicManagementSystem.Forms.CustomElements
{
    public partial class VisitListElement : ListElement
    {
        public VisitListElement(int index, string patientName, string doctorName, string date) : base(index)
        {          
            InitializeComponent();
            this.PatientNameLabel.Text = patientName;
            this.DoctorNameLabel.Text = doctorName;
            this.DateLabel.Text = date;
        }

        protected override void ListElement_MouseDown(object sender, MouseEventArgs e)
        {
            SetNoHoverColor();
            OnListElementClicked(new EventArguments.ListElementClickedDoctorArgs(_index,
                PatientNameLabel.Text, DoctorNameLabel.Text));
        }
    }
}
