using ClinicManagementSystem.Entities.Enums;
using ClinicManagementSystem.Entities.Models;
using ClinicManagementSystem.Forms.CustomElements;
using ClinicManagementSystem.Forms.EventArguments;
using ClinicManagementSystem.Forms.MainForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClinicManagementSystem.Forms.SideForms
{
    public partial class LaboratoryListForm : ListForm
    {
        
        public void PopulateList(IList<LaboratoryExam> laboratoryExams)
        {
            List<ListElement> listElements = laboratoryExams.Select((exam, idx) => new LaboratoryTestListElement(idx, exam.Examination.FormattedName, exam.DoctorComment) as ListElement).ToList();
            base.PopulateList(listElements);
        }
        

        protected override void PopulateListExample()
        {
            //ResetIndex();
            //_elements = new List<ListElement>
            //{
            //    new LaboratoryTestListElement(0, "Complete Blood Count", "Fri - 25.03.2022 - 7:00"),
            //    new LaboratoryTestListElement(1, "Basic Metabolic Panel", "Fri - 25.03.2022 - 8:00"),
            //    new LaboratoryTestListElement(2, "Thyroid Stimulating Hormone", "Fri - 25.03.2022 - 8:30")
            //};
            //this.ListFlowPanel.Controls.Clear();
            //foreach (ListElement element in _elements)
            //{
            //    element.ListElementClicked += OnElementClicked;
            //    this.ListFlowPanel.Controls.Add(element);
            //}
        }

        public void LaboratoryTestsList(TestStatus? testStatus)
        {
            //_currentIndex = -1;
            //this.ListFlowPanel.Controls.Clear();

            //if (testStatus.HasValue)
            //{
            //    _elements = new List<ListElement>
            //    {
            //        new LaboratoryTestListElement(0, testStatus.ToString()/*"Complete Blood Count"*/, "Fri - 25.03.2022 - 7:00"),
            //        new LaboratoryTestListElement(1, "Basic Metabolic Panel", "Fri - 25.03.2022 - 8:00"),
            //        new LaboratoryTestListElement(2, "Thyroid Stimulating Hormone", "Fri - 25.03.2022 - 8:30")
            //    };
            //}
            //else
            //{
            //    _elements = new List<ListElement>
            //    {
            //        new LaboratoryTestListElement(0, "Complete Blood Count", "Fri - 25.03.2022 - 7:00"),
            //        new LaboratoryTestListElement(1, "Basic Metabolic Panel", "Fri - 25.03.2022 - 8:00"),
            //        new LaboratoryTestListElement(2, "Thyroid Stimulating Hormone", "Fri - 25.03.2022 - 8:30")
            //    };
            //}

            //foreach (ListElement element in _elements)
            //{
            //    element.ListElementClicked += OnElementClicked;
            //    this.ListFlowPanel.Controls.Add(element);
            //}
        }
    }
}
