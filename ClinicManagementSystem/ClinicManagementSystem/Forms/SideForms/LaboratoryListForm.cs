using ClinicManagementSystem.Forms.CustomElements;
using ClinicManagementSystem.Forms.EventArguments;
using ClinicManagementSystem.Forms.MainForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClinicManagementSystem.Forms.SideForms
{
    public partial class LaboratoryListForm : ListForm
    {
        protected override void PopulateListExample()
        {
            _elements = new List<ListElement>
            {
                new LaboratoryTestListElement(0, "Complete Blood Count", "Fri - 25.03.2022 - 7:00"),
                new LaboratoryTestListElement(1, "Basic Metabolic Panel", "Fri - 25.03.2022 - 8:00"),
                new LaboratoryTestListElement(2, "Thyroid Stimulating Hormone", "Fri - 25.03.2022 - 8:30")
            };
            this.ListFlowPanel.Controls.Clear();
            foreach (ListElement element in _elements)
            {
                element.ListElementClicked += OnElementClicked;
                this.ListFlowPanel.Controls.Add(element);
            }
        }

        public void LaboratoryTestsList(int comboBoxIndex)
        {
            _currentIndex = -1;
            int index2 = comboBoxIndex;
            if (comboBoxIndex == 0)
            {
                this.ListFlowPanel.Controls.Clear();
                _elements = new List<ListElement>
            {
                new LaboratoryTestListElement(0, index2.ToString()/*"Complete Blood Count"*/, "Fri - 25.03.2022 - 7:00"),
                new LaboratoryTestListElement(1, "Basic Metabolic Panel", "Fri - 25.03.2022 - 8:00"),
                new LaboratoryTestListElement(2, "Thyroid Stimulating Hormone", "Fri - 25.03.2022 - 8:30")
            };
                foreach (ListElement element in _elements)
                {
                    element.ListElementClicked += OnElementClicked;
                    this.ListFlowPanel.Controls.Add(element);
                }
            }
            else
            {
                _elements = new List<ListElement>
            {
                new LaboratoryTestListElement(0, index2.ToString()/*"Complete Blood Count"*/, "Fri - 25.03.2022 - 7:00"),
                new LaboratoryTestListElement(1, "Basic Metabolic Panel", "Fri - 25.03.2022 - 8:00"),
                new LaboratoryTestListElement(2, "Thyroid Stimulating Hormone", "Fri - 25.03.2022 - 8:30")
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
}
