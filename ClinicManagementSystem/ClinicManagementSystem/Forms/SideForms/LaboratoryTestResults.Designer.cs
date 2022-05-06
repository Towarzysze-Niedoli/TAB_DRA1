
namespace ClinicManagementSystem.Forms.SideForms
{
    partial class LaboratoryTestResults
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
            this.TestName = new System.Windows.Forms.Label();
            this.TestResults = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TestName
            // 
            this.TestName.AutoEllipsis = true;
            this.TestName.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TestName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.TestName.Location = new System.Drawing.Point(14, 12);
            this.TestName.Name = "TestName";
            this.TestName.Size = new System.Drawing.Size(289, 64);
            this.TestName.TabIndex = 3;
            this.TestName.Text = "Please select the test";
            // 
            // TestResults
            // 
            this.TestResults.Location = new System.Drawing.Point(11, 80);
            this.TestResults.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TestResults.Multiline = true;
            this.TestResults.Name = "TestResults";
            this.TestResults.Size = new System.Drawing.Size(509, 236);
            this.TestResults.TabIndex = 4;
            // 
            // LaboratoryTestResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(530, 326);
            this.Controls.Add(this.TestResults);
            this.Controls.Add(this.TestName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LaboratoryTestResults";
            this.Text = "LaboratoryTestResults";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TestName;
        private System.Windows.Forms.TextBox TestResults;
    }
}