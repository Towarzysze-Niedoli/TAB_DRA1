using System;
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
                new DoctorListElement(0, "Andrzej Duda", "Długopis", "Thu - 15.03.2022 - 8:00"),
                new DoctorListElement(1, "Andrzej Duda", "Długopis", "Thu - 15.03.2022 - 8:30"),
                new DoctorListElement(2, "Andrzej Duda", "Długopis", "Thu - 15.03.2022 - 9:00"),
                new DoctorListElement(3, "Andrzej Duda", "Długopis", "Thu - 15.03.2022 - 9:30"),
                new DoctorListElement(4, "Andrzej Duda", "Długopis", "Thu - 15.03.2022 - 10:00"),
                new DoctorListElement(5, "Andrzej Duda", "Długopis", "Thu - 15.03.2022 - 10:30"),
                new DoctorListElement(6, "Andrzej Duda", "Długopis", "Thu - 15.03.2022 - 11:00"),
                new DoctorListElement(7, "Andrzej Duda", "Długopis", "Thu - 15.03.2022 - 11:30"),
                new DoctorListElement(8, "Andrzej Duda", "Długopis", "Thu - 15.03.2022 - 12:00")
            };
            this.ListFlowPanel.Controls.Clear();
            foreach (ListElement element in _elements)
            {
                element.ListElementClicked += OnElementClicked;
                this.ListFlowPanel.Controls.Add(element);
            }
        }
    }
}
