
namespace ClinicManagementSystem.Forms.MainForms
{
    partial class NewVisitForm
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
            this.components = new System.ComponentModel.Container();
            this.SearchPatientTextBox = new System.Windows.Forms.TextBox();
            this.SearchPatientButton = new System.Windows.Forms.Button();
            this.PatientPanel = new System.Windows.Forms.Panel();
            this.DoctorsListPanel = new System.Windows.Forms.Panel();
            this.NewPatientButton = new System.Windows.Forms.Button();
            this.SpecializationComboBox = new System.Windows.Forms.ComboBox();
            this.VisitDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PatientSurnameTextBox = new System.Windows.Forms.TextBox();
            this.PatientNameTextBox = new System.Windows.Forms.TextBox();
            this.DoctorNameTextBox = new System.Windows.Forms.TextBox();
            this.DoctorSurnameTextBox = new System.Windows.Forms.TextBox();
            this.VisitDateTextBox = new System.Windows.Forms.TextBox();
            this.VisitTimeTextBox = new System.Windows.Forms.TextBox();
            this.NewVisitButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchPatientTextBox
            // 
            this.SearchPatientTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchPatientTextBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchPatientTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.SearchPatientTextBox.Location = new System.Drawing.Point(50, 100);
            this.SearchPatientTextBox.MaxLength = 20;
            this.SearchPatientTextBox.Name = "SearchPatientTextBox";
            this.SearchPatientTextBox.PlaceholderText = "Search Patient";
            this.SearchPatientTextBox.Size = new System.Drawing.Size(302, 25);
            this.SearchPatientTextBox.TabIndex = 0;
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
            this.SearchPatientButton.Location = new System.Drawing.Point(506, 100);
            this.SearchPatientButton.Name = "SearchPatientButton";
            this.SearchPatientButton.Size = new System.Drawing.Size(94, 32);
            this.SearchPatientButton.TabIndex = 1;
            this.SearchPatientButton.Text = "Search";
            this.SearchPatientButton.UseVisualStyleBackColor = false;
            this.SearchPatientButton.Click += new System.EventHandler(this.SearchPatientButton_Click);
            // 
            // PatientPanel
            // 
            this.PatientPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.PatientPanel.Location = new System.Drawing.Point(50, 144);
            this.PatientPanel.Name = "PatientPanel";
            this.PatientPanel.Size = new System.Drawing.Size(550, 439);
            this.PatientPanel.TabIndex = 2;
            // 
            // DoctorsListPanel
            // 
            this.DoctorsListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.DoctorsListPanel.Location = new System.Drawing.Point(700, 144);
            this.DoctorsListPanel.Name = "DoctorsListPanel";
            this.DoctorsListPanel.Size = new System.Drawing.Size(550, 439);
            this.DoctorsListPanel.TabIndex = 3;
            // 
            // NewPatientButton
            // 
            this.NewPatientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.NewPatientButton.FlatAppearance.BorderSize = 0;
            this.NewPatientButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(88)))), ((int)(((byte)(103)))));
            this.NewPatientButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.NewPatientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewPatientButton.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewPatientButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.NewPatientButton.Location = new System.Drawing.Point(1127, 23);
            this.NewPatientButton.Name = "NewPatientButton";
            this.NewPatientButton.Size = new System.Drawing.Size(123, 46);
            this.NewPatientButton.TabIndex = 13;
            this.NewPatientButton.Text = "New Patient";
            this.NewPatientButton.UseVisualStyleBackColor = false;
            this.NewPatientButton.Click += new System.EventHandler(this.NewPatientButton_Click);
            // 
            // SpecializationComboBox
            // 
            this.SpecializationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SpecializationComboBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SpecializationComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.SpecializationComboBox.FormattingEnabled = true;
            this.SpecializationComboBox.Location = new System.Drawing.Point(700, 100);
            this.SpecializationComboBox.Name = "SpecializationComboBox";
            this.SpecializationComboBox.Size = new System.Drawing.Size(200, 32);
            this.SpecializationComboBox.TabIndex = 2;
            // 
            // VisitDateTimePicker
            // 
            this.VisitDateTimePicker.CalendarFont = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VisitDateTimePicker.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VisitDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.VisitDateTimePicker.Location = new System.Drawing.Point(926, 100);
            this.VisitDateTimePicker.Name = "VisitDateTimePicker";
            this.VisitDateTimePicker.Size = new System.Drawing.Size(200, 32);
            this.VisitDateTimePicker.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // PatientSurnameTextBox
            // 
            this.PatientSurnameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.PatientSurnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PatientSurnameTextBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientSurnameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.PatientSurnameTextBox.Location = new System.Drawing.Point(1009, 619);
            this.PatientSurnameTextBox.Name = "PatientSurnameTextBox";
            this.PatientSurnameTextBox.ReadOnly = true;
            this.PatientSurnameTextBox.Size = new System.Drawing.Size(241, 25);
            this.PatientSurnameTextBox.TabIndex = 6;
            // 
            // PatientNameTextBox
            // 
            this.PatientNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.PatientNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PatientNameTextBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.PatientNameTextBox.Location = new System.Drawing.Point(700, 619);
            this.PatientNameTextBox.Name = "PatientNameTextBox";
            this.PatientNameTextBox.ReadOnly = true;
            this.PatientNameTextBox.Size = new System.Drawing.Size(241, 25);
            this.PatientNameTextBox.TabIndex = 5;
            // 
            // DoctorNameTextBox
            // 
            this.DoctorNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.DoctorNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DoctorNameTextBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DoctorNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.DoctorNameTextBox.Location = new System.Drawing.Point(700, 680);
            this.DoctorNameTextBox.Name = "DoctorNameTextBox";
            this.DoctorNameTextBox.ReadOnly = true;
            this.DoctorNameTextBox.Size = new System.Drawing.Size(241, 25);
            this.DoctorNameTextBox.TabIndex = 7;
            // 
            // DoctorSurnameTextBox
            // 
            this.DoctorSurnameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.DoctorSurnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DoctorSurnameTextBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DoctorSurnameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.DoctorSurnameTextBox.Location = new System.Drawing.Point(1009, 680);
            this.DoctorSurnameTextBox.Name = "DoctorSurnameTextBox";
            this.DoctorSurnameTextBox.ReadOnly = true;
            this.DoctorSurnameTextBox.Size = new System.Drawing.Size(241, 25);
            this.DoctorSurnameTextBox.TabIndex = 8;
            // 
            // VisitDateTextBox
            // 
            this.VisitDateTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.VisitDateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VisitDateTextBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VisitDateTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.VisitDateTextBox.Location = new System.Drawing.Point(700, 741);
            this.VisitDateTextBox.Name = "VisitDateTextBox";
            this.VisitDateTextBox.ReadOnly = true;
            this.VisitDateTextBox.Size = new System.Drawing.Size(241, 25);
            this.VisitDateTextBox.TabIndex = 9;
            // 
            // VisitTimeTextBox
            // 
            this.VisitTimeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.VisitTimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VisitTimeTextBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VisitTimeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.VisitTimeTextBox.Location = new System.Drawing.Point(1009, 741);
            this.VisitTimeTextBox.Name = "VisitTimeTextBox";
            this.VisitTimeTextBox.ReadOnly = true;
            this.VisitTimeTextBox.Size = new System.Drawing.Size(241, 25);
            this.VisitTimeTextBox.TabIndex = 11;
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
            this.NewVisitButton.Location = new System.Drawing.Point(700, 802);
            this.NewVisitButton.Name = "NewVisitButton";
            this.NewVisitButton.Size = new System.Drawing.Size(550, 57);
            this.NewVisitButton.TabIndex = 12;
            this.NewVisitButton.Text = "Add Visit";
            this.NewVisitButton.UseVisualStyleBackColor = false;
            this.NewVisitButton.Click += new System.EventHandler(this.NewVisitButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(88)))), ((int)(((byte)(103)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(1156, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 32);
            this.button1.TabIndex = 14;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewVisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1300, 900);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NewVisitButton);
            this.Controls.Add(this.VisitTimeTextBox);
            this.Controls.Add(this.VisitDateTextBox);
            this.Controls.Add(this.DoctorSurnameTextBox);
            this.Controls.Add(this.DoctorNameTextBox);
            this.Controls.Add(this.PatientNameTextBox);
            this.Controls.Add(this.PatientSurnameTextBox);
            this.Controls.Add(this.VisitDateTimePicker);
            this.Controls.Add(this.SpecializationComboBox);
            this.Controls.Add(this.NewPatientButton);
            this.Controls.Add(this.DoctorsListPanel);
            this.Controls.Add(this.PatientPanel);
            this.Controls.Add(this.SearchPatientButton);
            this.Controls.Add(this.SearchPatientTextBox);
            this.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewVisitForm";
            this.Text = "NewVisitForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchPatientTextBox;
        private System.Windows.Forms.Button SearchPatientButton;
        private System.Windows.Forms.Panel PatientPanel;
        private System.Windows.Forms.Panel DoctorsListPanel;
        private System.Windows.Forms.Button NewPatientButton;
        private System.Windows.Forms.ComboBox SpecializationComboBox;
        private System.Windows.Forms.DateTimePicker VisitDateTimePicker;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox PatientSurnameTextBox;
        private System.Windows.Forms.TextBox PatientNameTextBox;
        private System.Windows.Forms.TextBox DoctorNameTextBox;
        private System.Windows.Forms.TextBox DoctorSurnameTextBox;
        private System.Windows.Forms.TextBox VisitDateTextBox;
        private System.Windows.Forms.TextBox VisitTimeTextBox;
        private System.Windows.Forms.Button NewVisitButton;
        private System.Windows.Forms.Button button1;
    }
}