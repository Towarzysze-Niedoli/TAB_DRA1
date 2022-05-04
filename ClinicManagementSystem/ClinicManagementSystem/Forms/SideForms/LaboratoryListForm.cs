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
    public partial class LaboratoryListForm : Form
    {

        public delegate void LabTestClickedEventHandler(object sender, LaboratoryListElementClickedArgs args); //dodane
        public event LabTestClickedEventHandler LabElementClicked;


        List<LaboratoryTestListElement> tests;
        public LaboratoryListForm()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            this.TopMost = true; 
            this.TopLevel = false;

     
           LaboratoryTestsList(0);

        }


        public void LaboratoryTestsList(int comboBoxIndex)
        {
            int index=comboBoxIndex;

            if (index == 0)
            {
                tests = new List<LaboratoryTestListElement>
            {
                //new LaboratoryTestListElement(lab.IndexLaboratoryTestsComboBox, "Fri - 25.03.2022 - 7:00"),
                new LaboratoryTestListElement(index.ToString()/*"Complete Blood Count"*/, "Fri - 25.03.2022 - 7:00"),
                new LaboratoryTestListElement("Prothrombin Time", "Fri - 25.03.2022 - 7:30"),
                new LaboratoryTestListElement("Basic Metabolic Panel", "Fri - 25.03.2022 - 8:00"),
                new LaboratoryTestListElement("Lipid Panel", "Fri - 25.03.2022 - 8:30"),
                new LaboratoryTestListElement("Thyroid Stimulating Hormone", "Fri - 25.03.2022 - 8:30"),
                new LaboratoryTestListElement("Hemoglobin A1C", "Fri - 25.03.2022 - 9:00"),
                new LaboratoryTestListElement("Cultures", "Fri - 25.03.2022 - 9:30"),
                new LaboratoryTestListElement("Uber Test", "Fri - 25.03.2022 - 12:30")
            };
                this.LabListFlowPanel.Controls.Clear();
                foreach (LaboratoryTestListElement test in tests)
                {
                    test.LabTestElementClicked += OnElementClicked;
                    this.LabListFlowPanel.Controls.Add(test);
                }
            }
            else
            {
                tests = new List<LaboratoryTestListElement>
            {
                //new LaboratoryTestListElement(lab.IndexLaboratoryTestsComboBox, "Fri - 25.03.2022 - 7:00"),
                new LaboratoryTestListElement(index.ToString(), "Fri - 25.03.2022 - 7:00"),
                new LaboratoryTestListElement("da Time", "Fri - 25.03.2022 - 7:30"),
                new LaboratoryTestListElement("da Metabolic Panel", "Fri - 25.03.2022 - 8:00"),
                new LaboratoryTestListElement("Lipadaid Panel", "Fri - 25.03.2022 - 8:30"),
                new LaboratoryTestListElement("Thdadayroid Stimulating Hormone", "Fri - 25.03.2022 - 8:30"),
                new LaboratoryTestListElement("Hemdadaoglobin A1C", "Fri - 25.03.2022 - 9:00"),
                new LaboratoryTestListElement("da", "Fri - 25.03.2022 - 9:30"),
                new LaboratoryTestListElement("da Test", "Fri - 25.03.2022 - 12:30")
            };
                this.LabListFlowPanel.Controls.Clear();
                foreach (LaboratoryTestListElement test in tests)
                {
                    test.LabTestElementClicked += OnElementClicked;
                    this.LabListFlowPanel.Controls.Add(test);
                }
            }
        }

        protected void OnElementClicked(object source, LaboratoryListElementClickedArgs args)
        {
            LabElementClicked.Invoke(this, args);
        }


        private void LaboratoryListForm_Load(object sender, EventArgs e)
        {
           
        }

    }
}
