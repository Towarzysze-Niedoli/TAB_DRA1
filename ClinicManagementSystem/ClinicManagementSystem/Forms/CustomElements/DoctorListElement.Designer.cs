
namespace ClinicManagementSystem.Forms.CustomElements
{
    partial class DoctorListElement
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
            this.UpperMainLabel = new ClinicManagementSystem.Forms.CustomElements.DisabledLabel();
            this.BottomLabelOne = new ClinicManagementSystem.Forms.CustomElements.DisabledLabel();
            this.BottomLabelTwo = new ClinicManagementSystem.Forms.CustomElements.DisabledLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::ClinicManagementSystem.Properties.Resources.medical_symbol;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListElement_MouseDown);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.ListElement_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.ListElement_MouseHover);
            // 
            // UpperMainLabel
            // 
            this.UpperMainLabel.AutoEllipsis = true;
            this.UpperMainLabel.AutoSize = true;
            this.UpperMainLabel.CausesValidation = false;
            this.UpperMainLabel.Enabled = false;
            this.UpperMainLabel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpperMainLabel.Location = new System.Drawing.Point(120, 5);
            this.UpperMainLabel.Name = "UpperMainLabel";
            this.UpperMainLabel.Size = new System.Drawing.Size(189, 29);
            this.UpperMainLabel.TabIndex = 1;
            this.UpperMainLabel.Text = "UpperMainText";
            this.UpperMainLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListElement_MouseDown);
            this.UpperMainLabel.MouseLeave += new System.EventHandler(this.ListElement_MouseLeave);
            this.UpperMainLabel.MouseHover += new System.EventHandler(this.ListElement_MouseHover);
            // 
            // BottomLabelOne
            // 
            this.BottomLabelOne.AutoEllipsis = true;
            this.BottomLabelOne.AutoSize = true;
            this.BottomLabelOne.CausesValidation = false;
            this.BottomLabelOne.Enabled = false;
            this.BottomLabelOne.Location = new System.Drawing.Point(120, 49);
            this.BottomLabelOne.Name = "BottomLabelOne";
            this.BottomLabelOne.Size = new System.Drawing.Size(135, 18);
            this.BottomLabelOne.TabIndex = 2;
            this.BottomLabelOne.Text = "BottomTextOne";
            this.BottomLabelOne.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListElement_MouseDown);
            this.BottomLabelOne.MouseLeave += new System.EventHandler(this.ListElement_MouseLeave);
            this.BottomLabelOne.MouseHover += new System.EventHandler(this.ListElement_MouseHover);
            // 
            // BottomLabelTwo
            // 
            this.BottomLabelTwo.AutoEllipsis = true;
            this.BottomLabelTwo.AutoSize = true;
            this.BottomLabelTwo.CausesValidation = false;
            this.BottomLabelTwo.Enabled = false;
            this.BottomLabelTwo.Location = new System.Drawing.Point(120, 82);
            this.BottomLabelTwo.Name = "BottomLabelTwo";
            this.BottomLabelTwo.Size = new System.Drawing.Size(133, 18);
            this.BottomLabelTwo.TabIndex = 3;
            this.BottomLabelTwo.Text = "BottomTextTwo";
            // 
            // DoctorListElement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.Controls.Add(this.BottomLabelTwo);
            this.Controls.Add(this.BottomLabelOne);
            this.Controls.Add(this.UpperMainLabel);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DoctorListElement";
            this.Size = new System.Drawing.Size(542, 113);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListElement_MouseDown);
            this.MouseLeave += new System.EventHandler(this.ListElement_MouseLeave);
            this.MouseHover += new System.EventHandler(this.ListElement_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DisabledLabel UpperMainLabel;
        private DisabledLabel BottomLabelOne;
        private DisabledLabel BottomLabelTwo;
    }
}
