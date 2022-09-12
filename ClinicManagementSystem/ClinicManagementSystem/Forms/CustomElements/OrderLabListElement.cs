using ClinicManagementSystem.Entities.Enums;
using ClinicManagementSystem.Entities.Models;
using ClinicManagementSystem.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ClinicManagementSystem.Forms.CustomElements
{
    public partial class OrderLabListElement : ListElement
    {
        public bool IsEnabled { get; private set; }
        public bool IsSelected { get => _status; }

        public Examination Examination { get; private set; }
        public LaboratoryExam LabExam { get; private set; }

        private const char _pun = '\u2022';

        public OrderLabListElement(int index, Examination examination) : base(index)
        {
            InitializeComponent();

            base.MouseDown -= base.MouseDownHandler;
            base.MouseLeave -= base.MouseLeaveHandler;
            base.MouseHover -= base.MouseHoverHandler;
            this.MouseDown += new MouseEventHandler(this.ListElement_MouseDown);
            this.MouseLeave += new EventHandler(this.ListElement_MouseLeave);
            this.MouseHover += new EventHandler(this.ListElement_MouseHover);

            Examination = examination;

            UpperMainTextBox.Text = examination.FormattedName; // PR: zamienilem label na textbox udajacy label, bo wtedy dziala word wrap :> kocham winformsy
            UpperMainTextBox.SelectionChanged += UpperMainTextBox_SelectionChanged;
            IsEnabled = true;

            ViewDetailsButton.Hide();
        }

        public OrderLabListElement(int index, LaboratoryExam laboratoryExam) : this(index, laboratoryExam.Examination)
        {
            LabExam = laboratoryExam;
        }

        private void UpperMainTextBox_SelectionChanged(object sender, EventArgs e)
        {
            UpperMainTextBox.SelectionChanged -= UpperMainTextBox_SelectionChanged;
            UpperMainTextBox.SelectionStart = UpperMainTextBox.Text.Length;
            UpperMainTextBox.SelectionChanged += UpperMainTextBox_SelectionChanged;
        }

        protected override void ListElement_MouseDown(object sender, MouseEventArgs e)
        {
            if (IsEnabled)
            {
                //SetNoHoverColor();
                ChangeStatus();
                //OnListElementClicked(new EventArguments.ListElementClickedArgs(_index));
                ShowHideTick();
                SetNoHoverColor();
            }
        }

        private void ShowHideTick()
        {
            TickPictureBox.Visible = _status;
        }

        public new void SetNoHoverColor()
        {
            base.SetNoHoverColor();
            UpperMainTextBox.BackColor = _status ? _activeColor : _inactiveColor;
        }

        protected new void ListElement_MouseHover(object sender, EventArgs e)
        {
            base.ListElement_MouseHover(sender, e);
            UpperMainTextBox.BackColor = _hoverColor;
        }

        protected new void ListElement_MouseLeave(object sender, EventArgs e)
        {
            this.SetNoHoverColor();
        }

        public void SetDisabled()
        {
            IsEnabled = false;
            ViewDetailsButton.Show();
        }

        private void ViewDetailsButton_Click(object sender, EventArgs e)
        {
            if (LabExam is null)
            {
                MessageBox.Show("Invalid state: no examination", "Error");
                return;
            }
            
            MessageBox.Show(
                $"Examination with status: {LabExam.Status.ToReadableString()}\n\n" +
                $"{_pun} Result: {LabExam.Result.WordWrap(64) ?? "none"}\n\n" +
                $"{_pun} Laboratory Technician: {(LabExam.LaboratoryTechnician is null ? "none" : LabExam.LaboratoryTechnician.FullName)}\n\n" +
                $"{_pun} Laboratory Manager comment: {LabExam.LaboratoryManagerComment.WordWrap(64) ?? "none"}\n\n" +
                $"{_pun} Laboratory Manager: {(LabExam.LaboratoryManager is null ? "none" : LabExam.LaboratoryManager.FullName)}\n\n" +
                $"{_pun} Realisation date: {(LabExam.RealisationDate is null ? "none": LabExam.RealisationDate.Value.ToString("d"))}\n\n" +
                $"{_pun} Completion date: {(LabExam.CompletionDate is null ? "none" : LabExam.CompletionDate.Value.ToString("d"))}\n\n",
                "Examination info"
            );

        }
    }
}
