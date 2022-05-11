
namespace ClinicManagementSystem.Forms.CustomElements
{
    partial class VisitListElement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PatientNameLabel = new DisabledLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DoctorNameLabel = new DisabledLabel();
            this.DateLabel = new DisabledLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PatientNameLabel
            // 
            this.PatientNameLabel.AutoSize = true;
            this.PatientNameLabel.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PatientNameLabel.Location = new System.Drawing.Point(113, 3);
            this.PatientNameLabel.Name = "PatientNameLabel";
            this.PatientNameLabel.Size = new System.Drawing.Size(359, 37);
            this.PatientNameLabel.TabIndex = 0;
            this.PatientNameLabel.Text = "PatientNameAndSurname";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClinicManagementSystem.Properties.Resources.calendar_white;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // DoctorNameLabel
            // 
            this.DoctorNameLabel.AutoSize = true;
            this.DoctorNameLabel.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DoctorNameLabel.Location = new System.Drawing.Point(113, 50);
            this.DoctorNameLabel.Name = "DoctorNameLabel";
            this.DoctorNameLabel.Size = new System.Drawing.Size(354, 37);
            this.DoctorNameLabel.TabIndex = 2;
            this.DoctorNameLabel.Text = "DoctorNameAndSurname";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoEllipsis = true;
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Corbel", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateLabel.Location = new System.Drawing.Point(400, 50);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(285, 36);
            this.DateLabel.TabIndex = 3;
            this.DateLabel.Text = "Thu - 15.03.2022 - 8:00";
            // 
            // VisitListElement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.DoctorNameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PatientNameLabel);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.Name = "VisitListElement";
            this.Size = new System.Drawing.Size(750, 90);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DisabledLabel PatientNameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DisabledLabel DoctorNameLabel;
        private DisabledLabel DateLabel;
    }
}
