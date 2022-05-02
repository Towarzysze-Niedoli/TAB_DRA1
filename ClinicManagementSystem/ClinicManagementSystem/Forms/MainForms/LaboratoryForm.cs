using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClinicManagementSystem.Forms.SideForms;

namespace ClinicManagementSystem.Forms.MainForms
{

    public partial class LaboratoryForm : Form
    {
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

        void InitializeTestList()
        {
            TestsList = new LaboratoryListForm();
            this.LaboratoryTestsPanel.Controls.Add(TestsList);
            TestsList.Show();
        }

        void InitializeTestResults()
        {
            TestsResults = new LaboratoryTestResults();
            this.DescriptionPanel.Controls.Add(TestsResults);
            TestsResults.Show();
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void made_Click(object sender, EventArgs e)
        {

        }

        private void LaboratoryForm_Load(object sender, EventArgs e)
        {

        }



        private void LaboratoryTestsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = LaboratoryTestsComboBox.SelectedIndex;
            LaboratoryTestsList = TestsList.LaboratoryTestsList;

            if (LaboratoryTestsList != null)
            {
                LaboratoryTestsList.Invoke(index);
            }

        }
    }
}
