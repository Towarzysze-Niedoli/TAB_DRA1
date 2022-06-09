
namespace ClinicManagementSystem.Forms.SideForms
{
    partial class PhysicalForm
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
            this.TemperatureTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PreasureTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SugerLevelTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TemperatureTextBox
            // 
            this.TemperatureTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.TemperatureTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TemperatureTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TemperatureTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.TemperatureTextBox.Location = new System.Drawing.Point(452, 83);
            this.TemperatureTextBox.Name = "TemperatureTextBox";
            this.TemperatureTextBox.ReadOnly = true;
            this.TemperatureTextBox.Size = new System.Drawing.Size(301, 27);
            this.TemperatureTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(104, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Temperature [C]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(104, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Blood Presure [mmHg]";
            // 
            // PreasureTextBox
            // 
            this.PreasureTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.PreasureTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PreasureTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PreasureTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.PreasureTextBox.Location = new System.Drawing.Point(453, 173);
            this.PreasureTextBox.Name = "PreasureTextBox";
            this.PreasureTextBox.ReadOnly = true;
            this.PreasureTextBox.Size = new System.Drawing.Size(301, 27);
            this.PreasureTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(104, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Blood Suger Level [mg/dL]";
            // 
            // SugerLevelTextBox
            // 
            this.SugerLevelTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.SugerLevelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SugerLevelTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SugerLevelTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.SugerLevelTextBox.Location = new System.Drawing.Point(453, 264);
            this.SugerLevelTextBox.Name = "SugerLevelTextBox";
            this.SugerLevelTextBox.ReadOnly = true;
            this.SugerLevelTextBox.Size = new System.Drawing.Size(301, 27);
            this.SugerLevelTextBox.TabIndex = 10;
            // 
            // PhysicalForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(833, 549);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SugerLevelTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PreasureTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TemperatureTextBox);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PhysicalForm";
            this.Text = "PhysicalForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TemperatureTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PreasureTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SugerLevelTextBox;
    }
}