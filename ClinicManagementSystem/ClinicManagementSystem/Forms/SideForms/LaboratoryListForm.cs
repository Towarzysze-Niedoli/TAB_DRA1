using ClinicManagementSystem.Forms.CustomElements;
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
        //LaboratoryForm labForm;
        int index;
        List<LaboratoryTestListElement> tests;
        public LaboratoryListForm()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            this.TopMost = true; 
            this.TopLevel = false;

            TestsScrollBar.Value = LabListFlowPanel.VerticalScroll.Value;
            TestsScrollBar.Minimum = LabListFlowPanel.VerticalScroll.Minimum;
            TestsScrollBar.Maximum = LabListFlowPanel.VerticalScroll.Maximum;

            
            LabListFlowPanel.ControlAdded += LabListFlowPanel_ControlAdded;
            LabListFlowPanel.ControlRemoved += LabListFlowPanel_ControlRemoved;
            LaboratoryTestsListExample();

        }

        private void LabListFlowPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            TestsScrollBar.Minimum = LabListFlowPanel.VerticalScroll.Minimum;
        }

        private void LabListFlowPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            TestsScrollBar.Maximum = LabListFlowPanel.VerticalScroll.Maximum;
        }

        //TODO dodać opisy, żeby się wyświetlały w 2 oknie
        private void LaboratoryTestsListExample()
        {
            //int index = labForm != null ? labForm.IndexLaboratoryTestsComboBox(): 0;
            //var labForm = new LaboratoryForm();
            //labForm = labForm.IndexLaboratoryTestsComboBox();

            if (index == 0)
            {
                tests = new List<LaboratoryTestListElement>
            {
                //new LaboratoryTestListElement(lab.IndexLaboratoryTestsComboBox, "Fri - 25.03.2022 - 7:00"),
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
                foreach (LaboratoryTestListElement test in tests)
                {
                    this.LabListFlowPanel.Controls.Add(test);
                }
            }
            else
            {
                tests = new List<LaboratoryTestListElement>
            {
                //new LaboratoryTestListElement(lab.IndexLaboratoryTestsComboBox, "Fri - 25.03.2022 - 7:00"),
                new LaboratoryTestListElement("da", "Fri - 25.03.2022 - 7:00"),
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
                    this.LabListFlowPanel.Controls.Add(test);
                }
            }
        }

        
        public void ComboBoxIndex(int indexOfComboBox)
        {

        }

        private void LaboratoryListForm_Load(object sender, EventArgs e)
        {
           
        }

        private void TestsScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            LabListFlowPanel.VerticalScroll.Value = TestsScrollBar.Value;
        }
    }
}
