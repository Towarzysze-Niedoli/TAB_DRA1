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
        public LaboratoryForm()
        {
            InitializeComponent();
            InitializeTestList();
        }

        void InitializeTestList()
        {
            TestsList = new LaboratoryListForm();
            this.LaboratoryTestsPanel.Controls.Add(TestsList);
            TestsList.Show();
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
    }
}
