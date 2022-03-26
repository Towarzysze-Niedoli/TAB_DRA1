using ClinicManagementSystem.Forms.CustomElements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClinicManagementSystem.Forms.SideForms
{
    public partial class LaboratoryListForm : Form
    {

        List<LaboratoryTestListElement> tests;
        public LaboratoryListForm()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            this.TopMost = true; 
            this.TopLevel = false;
            LaboratoryTestsListExample();
        }
        
        //TODO dodać opisy, żeby się wyświetlały w 2 oknie
        private void LaboratoryTestsListExample()
        {
            tests = new List<LaboratoryTestListElement>
            {
                new LaboratoryTestListElement("Complete Blood Count", "Fri - 25.03.2022 - 7:00"),
                new LaboratoryTestListElement("Prothrombin Time", "Fri - 25.03.2022 - 7:30"),
                new LaboratoryTestListElement("Basic Metabolic Panel", "Fri - 25.03.2022 - 8:00"),
                new LaboratoryTestListElement("Lipid Panel", "Fri - 25.03.2022 - 8:30"),
                new LaboratoryTestListElement("Thyroid Stimulating Hormone", "Fri - 25.03.2022 - 8:30"),
                new LaboratoryTestListElement("Hemoglobin A1C", "Fri - 25.03.2022 - 9:00"),
                new LaboratoryTestListElement("Cultures", "Fri - 25.03.2022 - 9:30"),
                new LaboratoryTestListElement("Uber Test", "Fri - 25.03.2022 - 12:30")
            };
            this.LabListFlowPanel.Controls.Clear();
            foreach(LaboratoryTestListElement test in tests)
            {
                this.LabListFlowPanel.Controls.Add(test);
            }
        }

        private void LaboratoryListForm_Load(object sender, EventArgs e)
        {

        }
    }
}
