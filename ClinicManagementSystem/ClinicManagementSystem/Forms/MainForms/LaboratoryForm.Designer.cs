namespace ClinicManagementSystem.Forms.MainForms
{
    partial class LaboratoryForm
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
            this.LaboratoryTestsPanel = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DescriptionPanel = new System.Windows.Forms.Panel();
            this.LabManagerTextBox = new System.Windows.Forms.TextBox();
            this.approveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.returnBtn = new System.Windows.Forms.Button();
            this.LaboratoryTestsComboBox = new System.Windows.Forms.ComboBox();
            this.PLabel = new System.Windows.Forms.Label();
            this.DLabel = new System.Windows.Forms.Label();
            this.RDLabel = new System.Windows.Forms.Label();
            this.PatientLabel = new System.Windows.Forms.Label();
            this.DoctorLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LaboratoryTestsPanel
            // 
            this.LaboratoryTestsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.LaboratoryTestsPanel.Location = new System.Drawing.Point(63, 182);
            this.LaboratoryTestsPanel.Name = "LaboratoryTestsPanel";
            this.LaboratoryTestsPanel.Size = new System.Drawing.Size(496, 695);
            this.LaboratoryTestsPanel.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(309, 124);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // DescriptionPanel
            // 
            this.DescriptionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.DescriptionPanel.Location = new System.Drawing.Point(648, 124);
            this.DescriptionPanel.Name = "DescriptionPanel";
            this.DescriptionPanel.Size = new System.Drawing.Size(519, 377);
            this.DescriptionPanel.TabIndex = 4;
            // 
            // LabManagerTextBox
            // 
            this.LabManagerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabManagerTextBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabManagerTextBox.Location = new System.Drawing.Point(648, 618);
            this.LabManagerTextBox.Multiline = true;
            this.LabManagerTextBox.Name = "LabManagerTextBox";
            this.LabManagerTextBox.Size = new System.Drawing.Size(519, 193);
            this.LabManagerTextBox.TabIndex = 5;
            // 
            // approveBtn
            // 
            this.approveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.approveBtn.FlatAppearance.BorderSize = 0;
            this.approveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.approveBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.approveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.approveBtn.Location = new System.Drawing.Point(1017, 837);
            this.approveBtn.Name = "approveBtn";
            this.approveBtn.Size = new System.Drawing.Size(150, 40);
            this.approveBtn.TabIndex = 1;
            this.approveBtn.Text = "Approve";
            this.approveBtn.UseVisualStyleBackColor = false;
            this.approveBtn.Click += new System.EventHandler(this.approveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(95)))), ((int)(((byte)(85)))));
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.cancelBtn.Location = new System.Drawing.Point(648, 837);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(150, 40);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.returnBtn.FlatAppearance.BorderSize = 0;
            this.returnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.returnBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.returnBtn.Location = new System.Drawing.Point(830, 837);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(150, 40);
            this.returnBtn.TabIndex = 1;
            this.returnBtn.Text = "Return";
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // LaboratoryTestsComboBox
            // 
            this.LaboratoryTestsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LaboratoryTestsComboBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LaboratoryTestsComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.LaboratoryTestsComboBox.Location = new System.Drawing.Point(63, 124);
            this.LaboratoryTestsComboBox.Name = "LaboratoryTestsComboBox";
            this.LaboratoryTestsComboBox.Size = new System.Drawing.Size(200, 26);
            this.LaboratoryTestsComboBox.TabIndex = 6;
            this.LaboratoryTestsComboBox.SelectedIndexChanged += new System.EventHandler(this.LaboratoryTestsComboBox_SelectedIndexChanged);
            // 
            // PLabel
            // 
            this.PLabel.AutoSize = true;
            this.PLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PLabel.Location = new System.Drawing.Point(648, 517);
            this.PLabel.Name = "PLabel";
            this.PLabel.Size = new System.Drawing.Size(74, 18);
            this.PLabel.TabIndex = 31;
            this.PLabel.Text = "Patient:";
            // 
            // DLabel
            // 
            this.DLabel.AutoSize = true;
            this.DLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DLabel.Location = new System.Drawing.Point(648, 551);
            this.DLabel.Name = "DLabel";
            this.DLabel.Size = new System.Drawing.Size(68, 18);
            this.DLabel.TabIndex = 32;
            this.DLabel.Text = "Doctor:";
            // 
            // RDLabel
            // 
            this.RDLabel.AutoSize = true;
            this.RDLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RDLabel.Location = new System.Drawing.Point(648, 584);
            this.RDLabel.Name = "RDLabel";
            this.RDLabel.Size = new System.Drawing.Size(122, 18);
            this.RDLabel.TabIndex = 33;
            this.RDLabel.Text = "Referral date:";
            // 
            // PatientLabel
            // 
            this.PatientLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientLabel.Location = new System.Drawing.Point(728, 517);
            this.PatientLabel.Name = "PatientLabel";
            this.PatientLabel.Size = new System.Drawing.Size(439, 18);
            this.PatientLabel.TabIndex = 34;
            // 
            // DoctorLabel
            // 
            this.DoctorLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DoctorLabel.Location = new System.Drawing.Point(722, 551);
            this.DoctorLabel.Name = "DoctorLabel";
            this.DoctorLabel.Size = new System.Drawing.Size(445, 18);
            this.DoctorLabel.TabIndex = 35;
            // 
            // DateLabel
            // 
            this.DateLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateLabel.Location = new System.Drawing.Point(776, 584);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(391, 18);
            this.DateLabel.TabIndex = 36;
            // 
            // LaboratoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1241, 948);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.DoctorLabel);
            this.Controls.Add(this.PatientLabel);
            this.Controls.Add(this.RDLabel);
            this.Controls.Add(this.DLabel);
            this.Controls.Add(this.PLabel);
            this.Controls.Add(this.LaboratoryTestsComboBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.approveBtn);
            this.Controls.Add(this.LabManagerTextBox);
            this.Controls.Add(this.DescriptionPanel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.LaboratoryTestsPanel);
            this.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LaboratoryForm";
            this.Text = "LaboratoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LaboratoryTestsPanel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel DescriptionPanel;
        private System.Windows.Forms.TextBox LabManagerTextBox;
        private System.Windows.Forms.Button approveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button returnBtn;
        public System.Windows.Forms.ComboBox LaboratoryTestsComboBox;
        private System.Windows.Forms.Label PLabel;
        private System.Windows.Forms.Label DLabel;
        private System.Windows.Forms.Label RDLabel;
        private System.Windows.Forms.Label PatientLabel;
        private System.Windows.Forms.Label DoctorLabel;
        private System.Windows.Forms.Label DateLabel;
    }
}