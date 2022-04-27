﻿using System;
using System.Collections.Generic;
using System.Text;
using ClinicManagementSystem.Forms.CustomElements;
using ClinicManagementSystem.Forms.EventArguments;

namespace ClinicManagementSystem.Forms.SideForms
{   
    class DoctorListForm : ListForm
    {
        protected override void PopulateListExample()
        {
            _elements = new List<ListElement>
            {
                new DoctorListElement(0, "Michał Kalke", "Internist", "Thu - 15.03.2022 - 8:00"),
                new DoctorListElement(1, "Michał Kalke", "Internist", "Thu - 15.03.2022 - 8:30"),
                new DoctorListElement(2, "Michał Kalke", "Internist", "Thu - 15.03.2022 - 9:00"),
                new DoctorListElement(3, "Michał Kalke", "Internist", "Thu - 15.03.2022 - 9:30"),
                new DoctorListElement(4, "Michał Kalke", "Internist", "Thu - 15.03.2022 - 10:00"),
                new DoctorListElement(5, "Michał Kalke", "Internist", "Thu - 15.03.2022 - 10:30"),
                new DoctorListElement(6, "Michał Kalke", "Internist", "Thu - 15.03.2022 - 11:00"),
                new DoctorListElement(7, "Michał Kalke", "Internist", "Thu - 15.03.2022 - 11:30"),
                new DoctorListElement(8, "Michał Kalke", "Internist", "Thu - 15.03.2022 - 12:00")
            };
            this.ListFlowPanel.Controls.Clear();
            foreach (ListElement element in _elements)
            {
                element.ListElementClicked += OnElementClicked;
                this.ListFlowPanel.Controls.Add(element);
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // DoctorListForm
            // 
            this.ClientSize = new System.Drawing.Size(1241, 818);
            this.Name = "DoctorListForm";
            this.ResumeLayout(false);

        }
    }
}
