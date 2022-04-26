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
            //stworzenie delegate'a
            LaboratoryListForm obj = new LaboratoryListForm();
            this.PassIndex += new PassSelectedIndex(obj.SetIndex);
            PassIndex(index);
           // InitializeTestList();
            // obj.ComboBoxIndex(index);
            //LabManagerComboBox.Text = index.ToString();
        }
    }
}
