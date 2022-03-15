using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClinicManagementSystem.Forms.CustomElements;

namespace ClinicManagementSystem.Forms.SideForms
{
    public partial class ListForm : Form
    {
        List<ListElement> elements;
        public ListForm()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            this.TopMost = true;
            this.TopLevel = false;
            PopulateListExample();
        }

        private void PopulateListExample()
        {
            elements = new List<ListElement>
            {
                new ListElement("Andrzej Duda", "Długopis", "Thu - 15.03.2022 - 8:00"),
                new ListElement("Andrzej Duda", "Długopis", "Thu - 15.03.2022 - 8:30"),
                new ListElement("Andrzej Duda", "Długopis", "Thu - 15.03.2022 - 9:00"),
                new ListElement("Andrzej Duda", "Długopis", "Thu - 15.03.2022 - 9:30"),
                new ListElement("Andrzej Duda", "Długopis", "Thu - 15.03.2022 - 10:00"),
                new ListElement("Andrzej Duda", "Długopis", "Thu - 15.03.2022 - 10:30"),
                new ListElement("Andrzej Duda", "Długopis", "Thu - 15.03.2022 - 11:00"),
                new ListElement("Andrzej Duda", "Długopis", "Thu - 15.03.2022 - 11:30"),
                new ListElement("Andrzej Duda", "Długopis", "Thu - 15.03.2022 - 12:00")
            };
            this.ListFlowPanel.Controls.Clear();
            foreach(ListElement element in elements)
            {
                this.ListFlowPanel.Controls.Add(element);
            }
        }
    }
}
