
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
            this.SuspendLayout();
            // 
            // VisitsListPanel
            // 
            this.VisitsListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.VisitsListPanel.Location = new System.Drawing.Point(12, 201);
            this.VisitsListPanel.Name = "VisitsListPanel";
            this.VisitsListPanel.Size = new System.Drawing.Size(760, 687);
            this.VisitsListPanel.TabIndex = 18;
            // 
            // VisitDateTextBox
            // 
            this.VisitDateTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.VisitDateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VisitDateTextBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VisitDateTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.VisitDateTextBox.Location = new System.Drawing.Point(788, 724);
            this.VisitDateTextBox.Name = "VisitDateTextBox";
            this.VisitDateTextBox.ReadOnly = true;
            this.VisitDateTextBox.Size = new System.Drawing.Size(241, 20);
            this.VisitDateTextBox.TabIndex = 7;
            // 
            // DoctorNameTextBox
            // 
            this.DoctorNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.DoctorNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DoctorNameTextBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DoctorNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.DoctorNameTextBox.Location = new System.Drawing.Point(788, 663);
            this.DoctorNameTextBox.Name = "DoctorNameTextBox";
            this.DoctorNameTextBox.ReadOnly = true;
            this.DoctorNameTextBox.Size = new System.Drawing.Size(241, 20);
            this.DoctorNameTextBox.TabIndex = 5;
            // 
            // PatientNameTextBox
            // 
            this.PatientNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.PatientNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PatientNameTextBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.PatientNameTextBox.Location = new System.Drawing.Point(788, 602);
            this.PatientNameTextBox.Name = "PatientNameTextBox";
            this.PatientNameTextBox.ReadOnly = true;
            this.PatientNameTextBox.Size = new System.Drawing.Size(241, 20);
            this.PatientNameTextBox.TabIndex = 3;
            // 
            // VisitTimeTextBox
            // 
            this.VisitTimeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.VisitTimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VisitTimeTextBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VisitTimeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.VisitTimeTextBox.Location = new System.Drawing.Point(1047, 724);
            this.VisitTimeTextBox.Name = "VisitTimeTextBox";
            this.VisitTimeTextBox.ReadOnly = true;
            this.VisitTimeTextBox.Size = new System.Drawing.Size(241, 20);
            this.VisitTimeTextBox.TabIndex = 8;
            // 
            // DoctorSurnameTextBox
            // 
            this.DoctorSurnameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.DoctorSurnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DoctorSurnameTextBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DoctorSurnameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.DoctorSurnameTextBox.Location = new System.Drawing.Point(1047, 663);
            this.DoctorSurnameTextBox.Name = "DoctorSurnameTextBox";
            this.DoctorSurnameTextBox.ReadOnly = true;
            this.DoctorSurnameTextBox.Size = new System.Drawing.Size(241, 20);
            this.DoctorSurnameTextBox.TabIndex = 6;
            // 
            // PatientSurnameTextBox
            // 
            this.PatientSurnameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.PatientSurnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PatientSurnameTextBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientSurnameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.PatientSurnameTextBox.Location = new System.Drawing.Point(1047, 602);
            this.PatientSurnameTextBox.Name = "PatientSurnameTextBox";
            this.PatientSurnameTextBox.ReadOnly = true;
            this.PatientSurnameTextBox.Size = new System.Drawing.Size(241, 20);
            this.PatientSurnameTextBox.TabIndex = 4;
            // 
            // CancelVisitButton
            // 
            this.CancelVisitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(95)))), ((int)(((byte)(85)))));
            this.CancelVisitButton.FlatAppearance.BorderSize = 0;
            this.CancelVisitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.CancelVisitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(65)))), ((int)(((byte)(68)))));
            this.CancelVisitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelVisitButton.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelVisitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.CancelVisitButton.Location = new System.Drawing.Point(788, 838);
            this.CancelVisitButton.Name = "CancelVisitButton";
            this.CancelVisitButton.Size = new System.Drawing.Size(500, 50);
            this.CancelVisitButton.TabIndex = 21;
            this.CancelVisitButton.Text = "Cancel Visit";
            this.CancelVisitButton.UseVisualStyleBackColor = false;
            this.CancelVisitButton.Click += new System.EventHandler(this.CancelVisitButton_Click);
            // 
            // SearchPatientTextBox
            // 
            this.SearchPatientTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchPatientTextBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchPatientTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.SearchPatientTextBox.Location = new System.Drawing.Point(12, 150);
            this.SearchPatientTextBox.MaxLength = 20;
            this.SearchPatientTextBox.Name = "SearchPatientTextBox";
            this.SearchPatientTextBox.PlaceholderText = "Search Patient";
            this.SearchPatientTextBox.Size = new System.Drawing.Size(506, 20);
            this.SearchPatientTextBox.TabIndex = 1;
            // 
            // NewVisitButton
            // 
            this.NewVisitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.NewVisitButton.FlatAppearance.BorderSize = 0;
            this.NewVisitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(88)))), ((int)(((byte)(103)))));
            this.NewVisitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.NewVisitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewVisitButton.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewVisitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.NewVisitButton.Location = new System.Drawing.Point(1047, 12);
            this.NewVisitButton.Name = "NewVisitButton";
            this.NewVisitButton.Size = new System.Drawing.Size(241, 50);
            this.NewVisitButton.TabIndex = 22;
            this.NewVisitButton.Text = "New Visit";
            this.NewVisitButton.UseVisualStyleBackColor = false;
            this.NewVisitButton.Click += new System.EventHandler(this.NewVisitButton_Click);
            // 
            // SearchPatientButton
            // 
            this.SearchPatientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.SearchPatientButton.FlatAppearance.BorderSize = 0;
            this.SearchPatientButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(88)))), ((int)(((byte)(103)))));
            this.SearchPatientButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.SearchPatientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchPatientButton.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchPatientButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.SearchPatientButton.Location = new System.Drawing.Point(678, 146);
            this.SearchPatientButton.Name = "SearchPatientButton";
            this.SearchPatientButton.Size = new System.Drawing.Size(94, 32);
            this.SearchPatientButton.TabIndex = 23;
            this.SearchPatientButton.Text = "Search";
            this.SearchPatientButton.UseVisualStyleBackColor = false;
            // 
            // PerformVisitButton
            // 
            this.PerformVisitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.PerformVisitButton.FlatAppearance.BorderSize = 0;
            this.PerformVisitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(88)))), ((int)(((byte)(103)))));
            this.PerformVisitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.PerformVisitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PerformVisitButton.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PerformVisitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.PerformVisitButton.Location = new System.Drawing.Point(788, 769);
            this.PerformVisitButton.Name = "PerformVisitButton";
            this.PerformVisitButton.Size = new System.Drawing.Size(500, 50);
            this.PerformVisitButton.TabIndex = 24;
            this.PerformVisitButton.Text = "Perform Visit";
            this.PerformVisitButton.UseVisualStyleBackColor = false;
            this.PerformVisitButton.Click += new System.EventHandler(this.PerformVisitButton_Click);
            // 
            // VisitStatusComboBox
            // 
            this.VisitStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VisitStatusComboBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VisitStatusComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.VisitStatusComboBox.Items.AddRange(new object[] {
            "Pending",
            "Canceled",
            "Finished"});
            this.VisitStatusComboBox.Location = new System.Drawing.Point(12, 94);
            this.VisitStatusComboBox.Name = "VisitStatusComboBox";
            this.VisitStatusComboBox.Size = new System.Drawing.Size(201, 27);
            this.VisitStatusComboBox.TabIndex = 25;
            // 
            // VisitDatePicker
            // 
            this.VisitDatePicker.CalendarFont = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VisitDatePicker.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VisitDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.VisitDatePicker.Location = new System.Drawing.Point(318, 91);
            this.VisitDatePicker.Name = "VisitDatePicker";
            this.VisitDatePicker.Size = new System.Drawing.Size(200, 27);
            this.VisitDatePicker.TabIndex = 26;
            // 
            // VisitsMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1300, 900);
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
            this.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
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
    }
}