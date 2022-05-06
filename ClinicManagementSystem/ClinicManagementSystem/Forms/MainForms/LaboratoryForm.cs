using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClinicManagementSystem.Forms.EventArguments;
using ClinicManagementSystem.Forms.SideForms;

namespace ClinicManagementSystem.Forms.MainForms
{

    public partial class LaboratoryForm : Form
    {

        public delegate void TestClickedHandler(object sender, ListElementClickedArgs args); 
        public event TestClickedHandler TestClicked;

        public delegate void LaboratoryTestsListChanged(int index);
        public LaboratoryTestsListChanged LaboratoryTestsList;

        LaboratoryListForm TestsList;
        LaboratoryTestResults TestsResults;

        public delegate void PassSelectedIndex(int index);
        public PassSelectedIndex PassIndex;
        public LaboratoryForm()
        {
            InitializeComponent();
            InitializeTestList();
            InitializeTestResults();
            LaboratoryTestsComboBox.SelectedIndex = 0;
        }

        public LaboratoryForm(int tmp)
        {

        }

        void InitializeTestList()
        {
            TestsList = new LaboratoryListForm();
            TestsList.ElementClicked += OnTestElementClicked;
            this.LaboratoryTestsPanel.Controls.Add(TestsList);
            TestsList.Show();
        }

        void InitializeTestResults()
        {
            TestsResults = new LaboratoryTestResults();
            this.DescriptionPanel.Controls.Add(TestsResults);
            TestsResults.Show();
        }

        protected void OnTestElementClicked(object source, ListElementClickedArgs args)
        {
            if (TestClicked != null)
            {
                TestClicked.Invoke(this, args);
            }
        }


        private void LaboratoryTestsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = LaboratoryTestsComboBox.SelectedIndex;
            //LaboratoryTestsList = TestsList.LaboratoryTestsList;

            if (LaboratoryTestsList != null)
            {
                LaboratoryTestsList.Invoke(index);
            }

        }
    }
}
