
namespace ClinicManagementSystem.Forms.CustomElements
{
    partial class ListElement
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainLabel = new System.Windows.Forms.Label();
            this.LowerLeftLabel = new System.Windows.Forms.Label();
            this.LowerRightLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClinicManagementSystem.Properties.Resources.medical_symbol;
            this.pictureBox1.Location = new System.Drawing.Point(16, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainLabel
            // 
            this.MainLabel.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.MainLabel.Location = new System.Drawing.Point(175, 16);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(534, 49);
            this.MainLabel.TabIndex = 1;
            this.MainLabel.Text = "Name and Surname";
            // 
            // LowerLeftLabel
            // 
            this.LowerLeftLabel.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LowerLeftLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.LowerLeftLabel.Location = new System.Drawing.Point(175, 107);
            this.LowerLeftLabel.Name = "LowerLeftLabel";
            this.LowerLeftLabel.Size = new System.Drawing.Size(215, 37);
            this.LowerLeftLabel.TabIndex = 2;
            this.LowerLeftLabel.Text = "Cardiologist";
            // 
            // LowerRightLabel
            // 
            this.LowerRightLabel.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LowerRightLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.LowerRightLabel.Location = new System.Drawing.Point(396, 107);
            this.LowerRightLabel.Name = "LowerRightLabel";
            this.LowerRightLabel.Size = new System.Drawing.Size(313, 37);
            this.LowerRightLabel.TabIndex = 3;
            this.LowerRightLabel.Text = "Mon - 14.03.2022 - 12:30";
            // 
            // ListElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.Controls.Add(this.LowerRightLabel);
            this.Controls.Add(this.LowerLeftLabel);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ListElement";
            this.Size = new System.Drawing.Size(750, 160);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Label LowerLeftLabel;
        private System.Windows.Forms.Label LowerRightLabel;
    }
}
