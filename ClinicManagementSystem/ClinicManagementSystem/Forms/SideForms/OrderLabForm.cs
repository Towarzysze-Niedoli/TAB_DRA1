using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicManagementSystem.Entities.Enums;
using ClinicManagementSystem.Entities.Models;
using ClinicManagementSystem.Forms.CustomElements;
using ClinicManagementSystem.Forms.EventArguments;

namespace ClinicManagementSystem.Forms.SideForms
{
    public partial class OrderLabForm : Form
    {
        private OrderLabListForm _orderLabListForm;
        private IEnumerable<Examination> _examinations;
        private IEnumerable<LaboratoryExam> _labExams;

        public delegate void AddExaminationFunction(string code, string examinationName, ExaminationType examinationType);
        private AddExaminationFunction _addExamination;


        public OrderLabForm(AddExaminationFunction addExamination)
        {
            InitializeComponent();
            SearchTextBox.KeyDown += (sender, args) => { // search on enter click
                if (args.KeyCode == Keys.Enter || args.KeyCode == Keys.Return)
                    SearchButton.PerformClick();
            };

            if (addExamination == null)
            {
                codeTextBox.Visible = false;
                examinationNameTextBox.Visible = false;
                AddButton.Visible = false;
            }
            else
            {
                _addExamination = addExamination;
            }
        }

        public OrderLabForm(IEnumerable<LaboratoryExam> examinations, AddExaminationFunction addExamination) : this(addExamination)
        {
            _labExams = examinations;
            _orderLabListForm = new OrderLabListForm();
            _orderLabListForm.PopulateList(examinations);
            FinalizeForm();
        }


        public OrderLabForm(IEnumerable<Examination> examinations, AddExaminationFunction addExamination) : this(addExamination)
        {
            _examinations = examinations;
            _orderLabListForm = new OrderLabListForm();
            _orderLabListForm.PopulateList(examinations);
            FinalizeForm();
        }

        private void FinalizeForm()
        {
            _orderLabListForm.ElementClicked += ListElementClicked;
            this.ListPanel.Controls.Add(_orderLabListForm);
            _orderLabListForm.Show();
            SetDocking();
        }

        private void SetDocking()
        {
            Dock = DockStyle.Fill;
            this.TopMost = true;
            this.TopLevel = false;
        }

        private void ListElementClicked(object source, ListElementClickedArgs args)
        {

        }

        public void SetDisabled()
        {
            _orderLabListForm.SetDisabled();
        }

        public IList<OrderLabListElement> GetSelectedLabListElements()
        {
            return _orderLabListForm.GetSelectedLabListElements();
        }

        private void LabSearchButton_Click(object sender, EventArgs e)
        {
            string text = this.SearchTextBox.Text.ToLower();
            if (string.IsNullOrWhiteSpace(text))
            {
                this._orderLabListForm.SetVisibility(Enumerable.Repeat(true, _examinations.Count()).ToList());
            }
            else
            {
                this._orderLabListForm.SetVisibility(
                    _examinations.Select(e =>
                        e.Code.ToLower().Contains(text)
                        || text.Contains(e.Code.ToLower())
                        || e.ExaminationName.ToLower().Contains(text)
                        || text.Contains(e.ExaminationName.ToLower())
                    ).ToList()
                );
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _addExamination(codeTextBox.Text, examinationNameTextBox.Text, ExaminationType.Laboratory);
        }

        public void PopulateList(IEnumerable<Examination> examinations)
        {
            _orderLabListForm.PopulateList(examinations);
        }

        public void PopulateList(IEnumerable<LaboratoryExam> examinations)
        {
            _orderLabListForm.PopulateList(examinations);
        }

        public void ClearTextBoxes()
        {
            codeTextBox.Clear();
            examinationNameTextBox.Clear();
            SearchTextBox.Clear();
        }
    }
}
