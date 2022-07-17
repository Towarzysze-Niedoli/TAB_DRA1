using System;
using System.Collections.Generic;
using System.Linq;
using ClinicManagementSystem.Entities.Models;
using ClinicManagementSystem.Forms.CustomElements;

namespace ClinicManagementSystem.Forms.SideForms
{
    class VisitsListForm : ListForm
    {
        public void PopulateList(IList<Appointment> appointments)
        {
            List<ListElement> elements = appointments
                .Select((app, index) => new VisitListElement(index, app.Patient.FullName, app.Doctor.FullName, app.ScheduledDate.ToString("g")))
                .ToList<ListElement>();
            base.PopulateList(elements);
        }

        protected override void PopulateListExample()
        {
            //_elements = new List<ListElement>
            //{
            //    new VisitListElement(0, "Mateusz Adamczyk", "Piotr Rajnisz", "Thu - 15.03.2022 - 8:00"),
            //    new VisitListElement(1, "Mateusz Adamczyk", "Piotr Rajnisz", "Thu - 15.03.2022 - 8:30"),
            //    new VisitListElement(2, "Mateusz Adamczyk", "Piotr Rajnisz", "Thu - 15.03.2022 - 9:00"),
            //    new VisitListElement(3, "Mateusz Adamczyk", "Piotr Rajnisz", "Thu - 15.03.2022 - 9:30"),
            //    new VisitListElement(4, "Mateusz Adamczyk", "Piotr Rajnisz", "Thu - 15.03.2022 - 10:00"),
            //    new VisitListElement(5, "Mateusz Adamczyk", "Piotr Rajnisz", "Thu - 15.03.2022 - 10:30"),
            //    new VisitListElement(6, "Mateusz Adamczyk", "Piotr Rajnisz", "Thu - 15.03.2022 - 11:00"),
            //    new VisitListElement(7, "Mateusz Adamczyk", "Piotr Rajnisz", "Thu - 15.03.2022 - 11:30"),
            //    new VisitListElement(8, "Mateusz Adamczyk", "Piotr Rajnisz", "Thu - 15.03.2022 - 12:00")
            //};
            //this.ListFlowPanel.Controls.Clear();
            //foreach (ListElement element in _elements)
            //{
            //    element.ListElementClicked += OnElementClicked;
            //    this.ListFlowPanel.Controls.Add(element);
            //}
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // VisitsListForm
            // 
            this.ClientSize = new System.Drawing.Size(1505, 666);
            this.Name = "VisitsListForm";
            this.ResumeLayout(false);

        }
    }
}
