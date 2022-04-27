
namespace ClinicManagementSystem.Forms.MainForms
{
    partial class ManagerForm
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
            this.PatientPanel = new System.Windows.Forms.Panel();
            this.EMailTextBox = new System.Windows.Forms.TextBox();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.ZIPCodeTextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.PESELTextBox = new System.Windows.Forms.TextBox();
            this.PatientSurnameTextBox = new System.Windows.Forms.TextBox();
            this.UpperMainLabel = new System.Windows.Forms.Label();
            this.PatientNameTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SearchPatientTextBox = new System.Windows.Forms.TextBox();
            this.SearchPatientButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SpecializationComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.PatientPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PatientPanel
            // 
            this.PatientPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.PatientPanel.Controls.Add(this.EMailTextBox);
            this.PatientPanel.Controls.Add(this.NumberTextBox);
            this.PatientPanel.Controls.Add(this.StreetTextBox);
            this.PatientPanel.Controls.Add(this.ZIPCodeTextBox);
            this.PatientPanel.Controls.Add(this.CityTextBox);
            this.PatientPanel.Controls.Add(this.PhoneTextBox);
            this.PatientPanel.Controls.Add(this.PESELTextBox);
            this.PatientPanel.Controls.Add(this.PatientSurnameTextBox);
            this.PatientPanel.Controls.Add(this.UpperMainLabel);
            this.PatientPanel.Controls.Add(this.PatientNameTextBox);
            this.PatientPanel.Location = new System.Drawing.Point(41, 178);
            this.PatientPanel.Name = "PatientPanel";
            this.PatientPanel.Size = new System.Drawing.Size(550, 596);
            this.PatientPanel.TabIndex = 3;
            // 
            // EMailTextBox
            // 
            this.EMailTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.EMailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EMailTextBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EMailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.EMailTextBox.Location = new System.Drawing.Point(27, 417);
            this.EMailTextBox.Name = "EMailTextBox";
            this.EMailTextBox.PlaceholderText = "E-mail";
            this.EMailTextBox.ReadOnly = true;
            this.EMailTextBox.Size = new System.Drawing.Size(205, 25);
            this.EMailTextBox.TabIndex = 24;
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.NumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumberTextBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumberTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.NumberTextBox.Location = new System.Drawing.Point(306, 343);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.PlaceholderText = "Number";
            this.NumberTextBox.ReadOnly = true;
            this.NumberTextBox.Size = new System.Drawing.Size(205, 25);
            this.NumberTextBox.TabIndex = 23;
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.StreetTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StreetTextBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StreetTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.StreetTextBox.Location = new System.Drawing.Point(27, 343);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.PlaceholderText = "Street";
            this.StreetTextBox.ReadOnly = true;
            this.StreetTextBox.Size = new System.Drawing.Size(205, 25);
            this.StreetTextBox.TabIndex = 22;
            // 
            // ZIPCodeTextBox
            // 
            this.ZIPCodeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ZIPCodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ZIPCodeTextBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ZIPCodeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.ZIPCodeTextBox.Location = new System.Drawing.Point(306, 272);
            this.ZIPCodeTextBox.Name = "ZIPCodeTextBox";
            this.ZIPCodeTextBox.PlaceholderText = "ZIP Code";
            this.ZIPCodeTextBox.ReadOnly = true;
            this.ZIPCodeTextBox.Size = new System.Drawing.Size(205, 25);
            this.ZIPCodeTextBox.TabIndex = 21;
            // 
            // CityTextBox
            // 
            this.CityTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.CityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CityTextBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CityTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.CityTextBox.Location = new System.Drawing.Point(27, 272);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.PlaceholderText = "City";
            this.CityTextBox.ReadOnly = true;
            this.CityTextBox.Size = new System.Drawing.Size(205, 25);
            this.CityTextBox.TabIndex = 20;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.PhoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneTextBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.PhoneTextBox.Location = new System.Drawing.Point(306, 126);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.PlaceholderText = "Phone";
            this.PhoneTextBox.ReadOnly = true;
            this.PhoneTextBox.Size = new System.Drawing.Size(205, 25);
            this.PhoneTextBox.TabIndex = 19;
            // 
            // PESELTextBox
            // 
            this.PESELTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.PESELTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PESELTextBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PESELTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.PESELTextBox.Location = new System.Drawing.Point(27, 126);
            this.PESELTextBox.Name = "PESELTextBox";
            this.PESELTextBox.PlaceholderText = "PESEL";
            this.PESELTextBox.ReadOnly = true;
            this.PESELTextBox.Size = new System.Drawing.Size(205, 25);
            this.PESELTextBox.TabIndex = 18;
            // 
            // PatientSurnameTextBox
            // 
            this.PatientSurnameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.PatientSurnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PatientSurnameTextBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientSurnameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.PatientSurnameTextBox.Location = new System.Drawing.Point(306, 200);
            this.PatientSurnameTextBox.Name = "PatientSurnameTextBox";
            this.PatientSurnameTextBox.PlaceholderText = "Last Name";
            this.PatientSurnameTextBox.ReadOnly = true;
            this.PatientSurnameTextBox.Size = new System.Drawing.Size(205, 25);
            this.PatientSurnameTextBox.TabIndex = 17;
            // 
            // UpperMainLabel
            // 
            this.UpperMainLabel.AutoEllipsis = true;
            this.UpperMainLabel.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpperMainLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.UpperMainLabel.Location = new System.Drawing.Point(27, 23);
            this.UpperMainLabel.Name = "UpperMainLabel";
            this.UpperMainLabel.Size = new System.Drawing.Size(345, 41);
            this.UpperMainLabel.TabIndex = 16;
            this.UpperMainLabel.Text = "Personal Data";
            // 
            // PatientNameTextBox
            // 
            this.PatientNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.PatientNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PatientNameTextBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.PatientNameTextBox.Location = new System.Drawing.Point(27, 200);
            this.PatientNameTextBox.Name = "PatientNameTextBox";
            this.PatientNameTextBox.PlaceholderText = "First Name";
            this.PatientNameTextBox.ReadOnly = true;
            this.PatientNameTextBox.Size = new System.Drawing.Size(205, 25);
            this.PatientNameTextBox.TabIndex = 6;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(88)))), ((int)(((byte)(103)))));
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.AddButton.Location = new System.Drawing.Point(713, 717);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(550, 57);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "Add User";
            this.AddButton.UseVisualStyleBackColor = false;
            // 
            // SearchPatientTextBox
            // 
            this.SearchPatientTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchPatientTextBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchPatientTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.SearchPatientTextBox.Location = new System.Drawing.Point(41, 133);
            this.SearchPatientTextBox.MaxLength = 20;
            this.SearchPatientTextBox.Name = "SearchPatientTextBox";
            this.SearchPatientTextBox.PlaceholderText = "Search User for Update";
            this.SearchPatientTextBox.Size = new System.Drawing.Size(302, 25);
            this.SearchPatientTextBox.TabIndex = 14;
            // 
            // SearchPatientButton
            // 
            this.SearchPatientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.SearchPatientButton.FlatAppearance.BorderSize = 0;
            this.SearchPatientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchPatientButton.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchPatientButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.SearchPatientButton.Location = new System.Drawing.Point(497, 133);
            this.SearchPatientButton.Name = "SearchPatientButton";
            this.SearchPatientButton.Size = new System.Drawing.Size(94, 32);
            this.SearchPatientButton.TabIndex = 15;
            this.SearchPatientButton.Text = "Search";
            this.SearchPatientButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.label1.Location = new System.Drawing.Point(713, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 41);
            this.label1.TabIndex = 25;
            this.label1.Text = "Login";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.LoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginTextBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.LoginTextBox.Location = new System.Drawing.Point(713, 248);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.PlaceholderText = "User\'s Login";
            this.LoginTextBox.ReadOnly = true;
            this.LoginTextBox.Size = new System.Drawing.Size(205, 25);
            this.LoginTextBox.TabIndex = 26;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.PasswordTextBox.Location = new System.Drawing.Point(713, 304);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PlaceholderText = "User\'s Password";
            this.PasswordTextBox.ReadOnly = true;
            this.PasswordTextBox.Size = new System.Drawing.Size(205, 25);
            this.PasswordTextBox.TabIndex = 27;
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.UpdateButton.FlatAppearance.BorderSize = 0;
            this.UpdateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(88)))), ((int)(((byte)(103)))));
            this.UpdateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.UpdateButton.Location = new System.Drawing.Point(713, 563);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(550, 57);
            this.UpdateButton.TabIndex = 28;
            this.UpdateButton.Text = "Update User";
            this.UpdateButton.UseVisualStyleBackColor = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(95)))), ((int)(((byte)(85)))));
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(88)))), ((int)(((byte)(103)))));
            this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.DeleteButton.Location = new System.Drawing.Point(713, 640);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(550, 57);
            this.DeleteButton.TabIndex = 29;
            this.DeleteButton.Text = "Delete User";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // SpecializationComboBox
            // 
            this.SpecializationComboBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SpecializationComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.SpecializationComboBox.FormattingEnabled = true;
            this.SpecializationComboBox.Location = new System.Drawing.Point(1040, 371);
            this.SpecializationComboBox.Name = "SpecializationComboBox";
            this.SpecializationComboBox.Size = new System.Drawing.Size(200, 32);
            this.SpecializationComboBox.TabIndex = 30;
            this.SpecializationComboBox.Text = "Specialization";
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.label2.Location = new System.Drawing.Point(713, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 39);
            this.label2.TabIndex = 31;
            this.label2.Text = "Doctoral Specialization:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.radioButton1.Location = new System.Drawing.Point(713, 450);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(158, 32);
            this.radioButton1.TabIndex = 32;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Lab Technician";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(157)))));
            this.radioButton2.Location = new System.Drawing.Point(1040, 450);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(212, 32);
            this.radioButton2.TabIndex = 33;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Laboratory Manager";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1300, 900);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SpecializationComboBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchPatientButton);
            this.Controls.Add(this.SearchPatientTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PatientPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.PatientPanel.ResumeLayout(false);
            this.PatientPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PatientPanel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox SearchPatientTextBox;
        private System.Windows.Forms.Button SearchPatientButton;
        private System.Windows.Forms.TextBox PatientNameTextBox;
        private System.Windows.Forms.TextBox EMailTextBox;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.TextBox ZIPCodeTextBox;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox PESELTextBox;
        private System.Windows.Forms.TextBox PatientSurnameTextBox;
        private System.Windows.Forms.Label UpperMainLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ComboBox SpecializationComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}