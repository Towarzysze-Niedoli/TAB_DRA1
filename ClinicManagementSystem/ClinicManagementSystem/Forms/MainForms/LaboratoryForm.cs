using System;
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
        private IList<LaboratoryExam> _labExams;
        private LaboratoryExam _selectedExam;
        private PersonWithAccount _loggedPerson;

        public LaboratoryForm(UserLevel level, ILaboratoryExamService laboratoryExamService, PersonWithAccount loggedPerson)
        {
            _labExamService = laboratoryExamService;
            _loggedPerson = loggedPerson;
            _level = level;
            InitializeComponent();
            InitializeTestList();
            InitializeTestResults();
            InitializeLaboratoryTestsCombobox();
            SetAccessibility();     
        }

        private void InitializeLaboratoryTestsCombobox()
        {
            _testStatus = new List<(TestStatus?, string)>
            {
                (null, "All"),
                (TestStatus.Pending, "To do"),
                (TestStatus.WaitingToBeAccepted, "Done"),
                (TestStatus.Returned, "Returned"),
                (TestStatus.Cancelled, "Cancelled"),
                (TestStatus.Accepted, "Approved")
            };

            _testStatus.ForEach(((TestStatus?, string) tuple) => {
                LaboratoryTestsComboBox.Items.Add(tuple.Item2);
            });
            LaboratoryTestsComboBox.SelectedIndex = _level switch // domyslnie wyswietlaja sie "to do" albo "done" aka czekajace na zaakceptowanie
            {
                UserLevel.Laborant => 1,
                UserLevel.HeadOfLab => 2,
                _ => throw new ArgumentOutOfRangeException("UserLevel")
            };
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
            // PR: co autor mial na mysli?...
            //if (TestClicked != null)
            //{
            //    TestClicked.Invoke(this, args);
            //}
            _selectedExam = _labExams[args.Index];
            TestsResults.TestTitle = _selectedExam.Examination.FormattedName;
            TestsResults.Result = _selectedExam.Result ?? "";
            LabManagerTextBox.Text = _selectedExam.LaboratoryManagerComment ?? "";
            PatientLabel.Text = _selectedExam.Appointment.Patient.FullName;
            DoctorLabel.Text = _selectedExam.Appointment.Doctor.FullName;
            DateLabel.Text = _selectedExam.ReferralDate.ToString("g");
        }


        private void LaboratoryTestsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = LaboratoryTestsComboBox.SelectedIndex;
            TestStatus? status = _testStatus[index].Item1;

            _labExams = _labExamService.GetLaboratoryExamsByStatus(status);
            TestsList.PopulateList(_labExams);

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
                this.LabManagerTextBox.Enabled = false;
                returnBtn.Hide();
                approveBtn.Text = "Done";

            }
            else
            {
                TestsResults.SetDisabled();
            }
        }

        private void UpdateAndRefresh()
        {
            _labExamService.UpdateLaboratoryExam(_selectedExam);
            LaboratoryTestsComboBox_SelectedIndexChanged(null, null);
            TestsResults.TestTitle = "Please select the test";
            TestsResults.ClearResult();
            LabManagerTextBox.Clear();
            PatientLabel.Text = DoctorLabel.Text = DateLabel.Text = "";
        }

        private void approveBtn_Click(object sender, EventArgs e)
        {
            if (_selectedExam is null)
            {
                MessageBox.Show("No examination selected", "Error");
                return;
            }

            if (_level == UserLevel.Laborant)
            {
                _selectedExam.RealisationDate = DateTime.Now;
                _selectedExam.LaboratoryTechnician = _loggedPerson as LaboratoryTechnician;
                _selectedExam.Result = TestsResults.Result;
                _selectedExam.Status = TestStatus.WaitingToBeAccepted;
            }
            else
            {
                _selectedExam.CompletionDate = DateTime.Now;
                _selectedExam.LaboratoryManager = _loggedPerson as LaboratoryManager;
                _selectedExam.LaboratoryManagerComment = LabManagerTextBox.Text;
                _selectedExam.Status = TestStatus.Accepted;
            }
            UpdateAndRefresh();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            if (_selectedExam is null)
            {
                MessageBox.Show("No examination selected", "Error");
                return;
            }

            if (_level == UserLevel.Laborant)
            {
                throw new InvalidOperationException("_level == UserLevel.Laborant");
            }
            else
            {
                _selectedExam.LaboratoryManager = _loggedPerson as LaboratoryManager;
                _selectedExam.LaboratoryManagerComment = LabManagerTextBox.Text;
                _selectedExam.Status = TestStatus.Returned;
            }
            UpdateAndRefresh();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (_selectedExam is null)
            {
                MessageBox.Show("No examination selected", "Error");
                return;
            }

            if (_level == UserLevel.Laborant)
            {
                _selectedExam.LaboratoryTechnician = _loggedPerson as LaboratoryTechnician;
                _selectedExam.Result = TestsResults.Result;
            }
            else
            {
                _selectedExam.LaboratoryManager = _loggedPerson as LaboratoryManager;
                _selectedExam.LaboratoryManagerComment = LabManagerTextBox.Text;
            }
            _selectedExam.Status = TestStatus.Cancelled;
            UpdateAndRefresh();
        }
    }
}
