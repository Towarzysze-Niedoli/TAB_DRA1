
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
            this.PressureTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SugarLevelTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TemperatureTextBox
            // 
            this.TemperatureTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.TemperatureTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TemperatureTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TemperatureTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.TemperatureTextBox.Location = new System.Drawing.Point(116, 133);
            this.TemperatureTextBox.Name = "TemperatureTextBox";
            this.TemperatureTextBox.Size = new System.Drawing.Size(301, 27);
            this.TemperatureTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(116, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Temperature [°C]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(116, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Blood Pressure [mmHg]";
            // 
            // PressureTextBox
            // 
            this.PressureTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.PressureTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PressureTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PressureTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.PressureTextBox.Location = new System.Drawing.Point(116, 256);
            this.PressureTextBox.Name = "PressureTextBox";
            this.PressureTextBox.Size = new System.Drawing.Size(301, 27);
            this.PressureTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(116, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Blood Sugar Level [mg/dL]";
            // 
            // SugarLevelTextBox
            // 
            this.SugarLevelTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.SugarLevelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SugarLevelTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SugarLevelTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.SugarLevelTextBox.Location = new System.Drawing.Point(116, 383);
            this.SugarLevelTextBox.Name = "SugarLevelTextBox";
            this.SugarLevelTextBox.Size = new System.Drawing.Size(301, 27);
            this.SugarLevelTextBox.TabIndex = 10;
            // 
            // PhysicalForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(560, 551);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SugarLevelTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PressureTextBox);
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
        private System.Windows.Forms.TextBox PressureTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SugarLevelTextBox;
    }
}