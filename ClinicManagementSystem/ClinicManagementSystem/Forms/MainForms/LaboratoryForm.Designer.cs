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
            this.LabManagerComboBox = new System.Windows.Forms.TextBox();
            this.approveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.returnBtn = new System.Windows.Forms.Button();
            this.LaboratoryTestsComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LaboratoryTestsPanel
            // 
            this.LaboratoryTestsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.LaboratoryTestsPanel.Location = new System.Drawing.Point(63, 182);
            this.LaboratoryTestsPanel.Name = "LaboratoryTestsPanel";
            this.LaboratoryTestsPanel.Size = new System.Drawing.Size(625, 695);
            this.LaboratoryTestsPanel.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(438, 124);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // DescriptionPanel
            // 
            this.DescriptionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.DescriptionPanel.Location = new System.Drawing.Point(818, 124);
            this.DescriptionPanel.Name = "DescriptionPanel";
            this.DescriptionPanel.Size = new System.Drawing.Size(745, 422);
            this.DescriptionPanel.TabIndex = 4;
            // 
            // LabManagerComboBox
            // 
            this.LabManagerComboBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabManagerComboBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabManagerComboBox.Location = new System.Drawing.Point(818, 553);
            this.LabManagerComboBox.Multiline = true;
            this.LabManagerComboBox.Name = "LabManagerComboBox";
            this.LabManagerComboBox.Size = new System.Drawing.Size(745, 199);
            this.LabManagerComboBox.TabIndex = 5;
            // 
            // approveBtn
            // 
            this.approveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.approveBtn.FlatAppearance.BorderSize = 0;
            this.approveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.approveBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.approveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.approveBtn.Location = new System.Drawing.Point(1374, 837);
            this.approveBtn.Name = "approveBtn";
            this.approveBtn.Size = new System.Drawing.Size(189, 40);
            this.approveBtn.TabIndex = 1;
            this.approveBtn.Text = "Approve";
            this.approveBtn.UseVisualStyleBackColor = false;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(95)))), ((int)(((byte)(85)))));
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.cancelBtn.Location = new System.Drawing.Point(818, 837);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(189, 40);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            // 
            // returnBtn
            // 
            this.returnBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.returnBtn.FlatAppearance.BorderSize = 0;
            this.returnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.returnBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.returnBtn.Location = new System.Drawing.Point(1099, 837);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(189, 40);
            this.returnBtn.TabIndex = 1;
            this.returnBtn.Text = "Return";
            this.returnBtn.UseVisualStyleBackColor = false;
            // 
            // LaboratoryTestsComboBox
            // 
            this.LaboratoryTestsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LaboratoryTestsComboBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LaboratoryTestsComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.LaboratoryTestsComboBox.Items.AddRange(new object[] {
            "To Do",
            "Done",
            "Returned",
            "Canceled",
            "Approved"});
            this.LaboratoryTestsComboBox.Location = new System.Drawing.Point(63, 124);
            this.LaboratoryTestsComboBox.Name = "LaboratoryTestsComboBox";
            this.LaboratoryTestsComboBox.Size = new System.Drawing.Size(189, 26);
            this.LaboratoryTestsComboBox.TabIndex = 6;
            this.LaboratoryTestsComboBox.SelectedIndexChanged += new System.EventHandler(this.LaboratoryTestsComboBox_SelectedIndexChanged);
            // 
            // LaboratoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1605, 1076);
            this.Controls.Add(this.LaboratoryTestsComboBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.approveBtn);
            this.Controls.Add(this.LabManagerComboBox);
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
        private System.Windows.Forms.TextBox LabManagerComboBox;
        private System.Windows.Forms.Button approveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button returnBtn;
        public System.Windows.Forms.ComboBox LaboratoryTestsComboBox;
    }
}