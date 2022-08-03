
using System;

namespace ClinicManagementSystem.Forms.MainForms
{
    partial class VisitsMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.VisitsListPanel = new System.Windows.Forms.Panel();
            this.VisitDateTextBox = new System.Windows.Forms.TextBox();
            this.DoctorNameTextBox = new System.Windows.Forms.TextBox();
            this.PatientNameTextBox = new System.Windows.Forms.TextBox();
            this.VisitTimeTextBox = new System.Windows.Forms.TextBox();
            this.DoctorSurnameTextBox = new System.Windows.Forms.TextBox();
            this.PatientSurnameTextBox = new System.Windows.Forms.TextBox();
            this.CancelVisitButton = new System.Windows.Forms.Button();
            this.SearchPatientTextBox = new System.Windows.Forms.TextBox();
            this.NewVisitButton = new System.Windows.Forms.Button();
            this.SearchPatientButton = new System.Windows.Forms.Button();
            this.PerformVisitButton = new System.Windows.Forms.Button();
            this.VisitStatusComboBox = new System.Windows.Forms.ComboBox();
            this.VisitDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ConciderDateCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // VisitsListPanel
            // 
            this.VisitsListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.VisitsListPanel.Location = new System.Drawing.Point(27, 194);
            this.VisitsListPanel.Name = "VisitsListPanel";
            this.VisitsListPanel.Size = new System.Drawing.Size(632, 697);
            this.VisitsListPanel.TabIndex = 18;
            // 
            // VisitDateTextBox
            // 
            this.VisitDateTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.VisitDateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VisitDateTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VisitDateTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.VisitDateTextBox.Location = new System.Drawing.Point(689, 629);
            this.VisitDateTextBox.Name = "VisitDateTextBox";
            this.VisitDateTextBox.ReadOnly = true;
            this.VisitDateTextBox.Size = new System.Drawing.Size(235, 27);
            this.VisitDateTextBox.TabIndex = 7;
            // 
            // DoctorNameTextBox
            // 
            this.DoctorNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.DoctorNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DoctorNameTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DoctorNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.DoctorNameTextBox.Location = new System.Drawing.Point(689, 553);
            this.DoctorNameTextBox.Name = "DoctorNameTextBox";
            this.DoctorNameTextBox.ReadOnly = true;
            this.DoctorNameTextBox.Size = new System.Drawing.Size(235, 27);
            this.DoctorNameTextBox.TabIndex = 5;
            // 
            // PatientNameTextBox
            // 
            this.PatientNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.PatientNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PatientNameTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.PatientNameTextBox.Location = new System.Drawing.Point(689, 477);
            this.PatientNameTextBox.Name = "PatientNameTextBox";
            this.PatientNameTextBox.ReadOnly = true;
            this.PatientNameTextBox.Size = new System.Drawing.Size(235, 27);
            this.PatientNameTextBox.TabIndex = 3;
            // 
            // VisitTimeTextBox
            // 
            this.VisitTimeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.VisitTimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VisitTimeTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VisitTimeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.VisitTimeTextBox.Location = new System.Drawing.Point(970, 629);
            this.VisitTimeTextBox.Name = "VisitTimeTextBox";
            this.VisitTimeTextBox.ReadOnly = true;
            this.VisitTimeTextBox.Size = new System.Drawing.Size(235, 27);
            this.VisitTimeTextBox.TabIndex = 8;
            // 
            // DoctorSurnameTextBox
            // 
            this.DoctorSurnameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.DoctorSurnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DoctorSurnameTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DoctorSurnameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.DoctorSurnameTextBox.Location = new System.Drawing.Point(970, 553);
            this.DoctorSurnameTextBox.Name = "DoctorSurnameTextBox";
            this.DoctorSurnameTextBox.ReadOnly = true;
            this.DoctorSurnameTextBox.Size = new System.Drawing.Size(235, 27);
            this.DoctorSurnameTextBox.TabIndex = 6;
            // 
            // PatientSurnameTextBox
            // 
            this.PatientSurnameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.PatientSurnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PatientSurnameTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientSurnameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.PatientSurnameTextBox.Location = new System.Drawing.Point(970, 477);
            this.PatientSurnameTextBox.Name = "PatientSurnameTextBox";
            this.PatientSurnameTextBox.ReadOnly = true;
            this.PatientSurnameTextBox.Size = new System.Drawing.Size(235, 27);
            this.PatientSurnameTextBox.TabIndex = 4;
            // 
            // CancelVisitButton
            // 
            this.CancelVisitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(95)))), ((int)(((byte)(85)))));
            this.CancelVisitButton.FlatAppearance.BorderSize = 0;
            this.CancelVisitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.CancelVisitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(65)))), ((int)(((byte)(68)))));
            this.CancelVisitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelVisitButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelVisitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.CancelVisitButton.Location = new System.Drawing.Point(689, 831);
            this.CancelVisitButton.Name = "CancelVisitButton";
            this.CancelVisitButton.Size = new System.Drawing.Size(516, 60);
            this.CancelVisitButton.TabIndex = 21;
            this.CancelVisitButton.Text = "Cancel Visit";
            this.CancelVisitButton.UseVisualStyleBackColor = false;
            this.CancelVisitButton.Click += new System.EventHandler(this.CancelVisitButton_Click);
            // 
            // SearchPatientTextBox
            // 
            this.SearchPatientTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchPatientTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchPatientTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.SearchPatientTextBox.Location = new System.Drawing.Point(27, 139);
            this.SearchPatientTextBox.MaxLength = 20;
            this.SearchPatientTextBox.Name = "SearchPatientTextBox";
            this.SearchPatientTextBox.PlaceholderText = "Search Patient";
            this.SearchPatientTextBox.Size = new System.Drawing.Size(301, 27);
            this.SearchPatientTextBox.TabIndex = 1;
            // 
            // NewVisitButton
            // 
            this.NewVisitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.NewVisitButton.FlatAppearance.BorderSize = 0;
            this.NewVisitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.NewVisitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.NewVisitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewVisitButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewVisitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.NewVisitButton.Location = new System.Drawing.Point(928, 12);
            this.NewVisitButton.Name = "NewVisitButton";
            this.NewVisitButton.Size = new System.Drawing.Size(301, 60);
            this.NewVisitButton.TabIndex = 22;
            this.NewVisitButton.Text = "New Visit";
            this.NewVisitButton.UseVisualStyleBackColor = false;
            this.NewVisitButton.Click += new System.EventHandler(this.NewVisitButton_Click);
            // 
            // SearchPatientButton
            // 
            this.SearchPatientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.SearchPatientButton.FlatAppearance.BorderSize = 0;
            this.SearchPatientButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.SearchPatientButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.SearchPatientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchPatientButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchPatientButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.SearchPatientButton.Location = new System.Drawing.Point(541, 139);
            this.SearchPatientButton.Name = "SearchPatientButton";
            this.SearchPatientButton.Size = new System.Drawing.Size(118, 40);
            this.SearchPatientButton.TabIndex = 23;
            this.SearchPatientButton.Text = "Search";
            this.SearchPatientButton.UseVisualStyleBackColor = false;
            this.SearchPatientButton.Click += new System.EventHandler(this.SearchPatientButton_Click);
            // 
            // PerformVisitButton
            // 
            this.PerformVisitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.PerformVisitButton.Enabled = false;
            this.PerformVisitButton.FlatAppearance.BorderSize = 0;
            this.PerformVisitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.PerformVisitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.PerformVisitButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PerformVisitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.PerformVisitButton.Location = new System.Drawing.Point(689, 743);
            this.PerformVisitButton.Name = "PerformVisitButton";
            this.PerformVisitButton.Size = new System.Drawing.Size(516, 60);
            this.PerformVisitButton.TabIndex = 24;
            this.PerformVisitButton.Text = "Perform Visit";
            this.PerformVisitButton.UseVisualStyleBackColor = false;
            this.PerformVisitButton.Click += new System.EventHandler(this.PerformVisitButton_Click);
            // 
            // VisitStatusComboBox
            // 
            this.VisitStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VisitStatusComboBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VisitStatusComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.VisitStatusComboBox.Location = new System.Drawing.Point(27, 68);
            this.VisitStatusComboBox.Name = "VisitStatusComboBox";
            this.VisitStatusComboBox.Size = new System.Drawing.Size(301, 26);
            this.VisitStatusComboBox.TabIndex = 25;
            this.VisitStatusComboBox.SelectedIndexChanged += new System.EventHandler(this.VisitStatusComboBox_SelectedIndexChanged);
            // 
            // VisitDatePicker
            // 
            this.VisitDatePicker.CalendarFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VisitDatePicker.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VisitDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.VisitDatePicker.Location = new System.Drawing.Point(409, 68);
            this.VisitDatePicker.Name = "VisitDatePicker";
            this.VisitDatePicker.Size = new System.Drawing.Size(250, 27);
            this.VisitDatePicker.TabIndex = 26;
            this.VisitDatePicker.ValueChanged += new System.EventHandler(this.VisitDatePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(689, 456);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "Patient\'s Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(970, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "Patient\'s Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(689, 532);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "Doctor\'s Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(970, 532);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "Doctor\'s Surname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(689, 608);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(970, 608);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 18);
            this.label6.TabIndex = 32;
            this.label6.Text = "Time";
            // 
            // ConciderDateCheckBox
            // 
            this.ConciderDateCheckBox.AutoSize = true;
            this.ConciderDateCheckBox.Location = new System.Drawing.Point(533, 101);
            this.ConciderDateCheckBox.Name = "ConciderDateCheckBox";
            this.ConciderDateCheckBox.Size = new System.Drawing.Size(126, 21);
            this.ConciderDateCheckBox.TabIndex = 33;
            this.ConciderDateCheckBox.Text = "Concider Date";
            this.ConciderDateCheckBox.UseVisualStyleBackColor = true;
            this.ConciderDateCheckBox.CheckedChanged += new System.EventHandler(this.ConciderDateCheckBox_CheckedChanged);
            // 
            // VisitsMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1241, 948);
            this.Controls.Add(this.ConciderDateCheckBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VisitDatePicker);
            this.Controls.Add(this.VisitStatusComboBox);
            this.Controls.Add(this.PerformVisitButton);
            this.Controls.Add(this.SearchPatientButton);
            this.Controls.Add(this.NewVisitButton);
            this.Controls.Add(this.SearchPatientTextBox);
            this.Controls.Add(this.CancelVisitButton);
            this.Controls.Add(this.VisitTimeTextBox);
            this.Controls.Add(this.VisitDateTextBox);
            this.Controls.Add(this.DoctorSurnameTextBox);
            this.Controls.Add(this.VisitsListPanel);
            this.Controls.Add(this.DoctorNameTextBox);
            this.Controls.Add(this.PatientSurnameTextBox);
            this.Controls.Add(this.PatientNameTextBox);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VisitsMainForm";
            this.Text = "VisitsMainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel VisitsListPanel;
        private System.Windows.Forms.TextBox VisitDateTextBox;
        private System.Windows.Forms.TextBox DoctorNameTextBox;
        private System.Windows.Forms.TextBox PatientNameTextBox;
        private System.Windows.Forms.TextBox VisitTimeTextBox;
        private System.Windows.Forms.TextBox DoctorSurnameTextBox;
        private System.Windows.Forms.TextBox PatientSurnameTextBox;
        private System.Windows.Forms.Button CancelVisitButton;
        private System.Windows.Forms.TextBox SearchPatientTextBox;
        private System.Windows.Forms.Button NewVisitButton;
        private System.Windows.Forms.Button SearchPatientButton;
        private System.Windows.Forms.Button PerformVisitButton;
        public System.Windows.Forms.ComboBox VisitStatusComboBox;
        private System.Windows.Forms.DateTimePicker VisitDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ConciderDateCheckBox;
    }
}