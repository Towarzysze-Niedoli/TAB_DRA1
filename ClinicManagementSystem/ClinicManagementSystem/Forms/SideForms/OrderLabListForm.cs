using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicManagementSystem.Entities.Models;
using ClinicManagementSystem.Forms.CustomElements;
using ClinicManagementSystem.Forms.EventArguments;


namespace ClinicManagementSystem.Forms.SideForms
{
    public partial class OrderLabListForm : ListForm
    {

        public void PopulateList(IEnumerable<Examination> examinations)
        {
            int index = 0;
            _elements = new List<ListElement>(examinations.Select(e => new OrderLabListElement(index++, e)));

            this.ListFlowPanel.Controls.Clear();
            foreach (ListElement element in _elements)
            {
                element.ListElementClicked += OnElementClicked;
                this.ListFlowPanel.Controls.Add(element);
            }
        }

        protected override void PopulateListExample()
        {
            //_elements = new List<ListElement>
            //{
            //    new OrderLabListElement(0, "Complete Blood Count"),
            //    new OrderLabListElement(1, "Basic Metabolic Panel"), 
            //    new OrderLabListElement(2, "Thyroid Stimulating Hormone")
            //};
            //this.ListFlowPanel.Controls.Clear();
            //foreach (ListElement element in _elements)
            //{
            //    element.ListElementClicked += OnElementClicked;
            //    this.ListFlowPanel.Controls.Add(element);
            //}
        }

        public void SetDisabled()
        {
            foreach(OrderLabListElement element in _elements)
            {
                element.SetDisabled();
            }
        }

        public IList<OrderLabListElement> GetSelectedLabListElements()
        {
            return _elements.Select(e => e as OrderLabListElement).Where(e => e.IsEnabled).ToList();
        }
    }
}
