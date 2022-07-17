﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using ClinicManagementSystem.Entities;
using ClinicManagementSystem.Entities.Enums;
using ClinicManagementSystem.Forms.CustomElements;
using ClinicManagementSystem.Forms.EventArguments;
using ClinicManagementSystem.Forms.SideForms;
using ClinicManagementSystem.Services;
using ClinicManagementSystem.Entities.Models;

namespace ClinicManagementSystem.Forms.MainForms
{

    public partial class LaboratoryForm : Form
    {

        public delegate void TestClickedHandler(object sender, ListElementClickedArgs args); 
        public event TestClickedHandler TestClicked;

        public delegate void LaboratoryTestsListChanged(TestStatus? status);
        public LaboratoryTestsListChanged LaboratoryTestsList;

        LaboratoryListForm TestsList;
        LaboratoryTestResults TestsResults;

        public delegate void PassSelectedIndex(int index);
        public PassSelectedIndex PassIndex;
        private UserLevel _level;
        private List<(TestStatus?, string)> _testStatus;
        private ILaboratoryExamService _labExamService;

        public LaboratoryForm(UserLevel level, ILaboratoryExamService laboratoryExamService)
        {
            _labExamService = laboratoryExamService;
            InitializeComponent();
            InitializeTestList();
            InitializeTestResults();
            InitializeLaboratoryTestsCombobox();
            _level = level;
            SetAccessibility();     
        }

        private void InitializeLaboratoryTestsCombobox()
        {
            _testStatus = new List<(TestStatus?, string)>
            {
                (null, "<Select Test Status>"),
                (TestStatus.Pending, "To do"),
                (TestStatus.WaitingToBeAccepted, "Done"),
                (TestStatus.Returned, "Returned"),
                (TestStatus.Cancelled, "Cancelled"),
                (TestStatus.Accepted, "Approved")
            };

            _testStatus.ForEach(((TestStatus?, string) tuple) => {
                LaboratoryTestsComboBox.Items.Add(tuple.Item2);
            });
            LaboratoryTestsComboBox.SelectedIndex = 1; // domyslnie wyswietlaja sie "to do"
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
            TestStatus? status = _testStatus[index].Item1;

            IList<LaboratoryExam> labExams = _labExamService.GetLaboratoryExamsByStatus(status);
            TestsList.PopulateList(labExams);

            LaboratoryTestsList = TestsList.LaboratoryTestsList;
            if (LaboratoryTestsList != null)
            {
                LaboratoryTestsList.Invoke(_testStatus[index].Item1);
            }

        }

        private void SetAccessibility()
        {
            if(_level == UserLevel.Laborant)
            {
                this.LabManagerComboBox.Enabled = false;
                returnBtn.Hide();
                cancelBtn.Hide();
                approveBtn.Text = "Done";

            }
            else
            {
                TestsResults.SetDisabled();
            }
        }
    }
}
