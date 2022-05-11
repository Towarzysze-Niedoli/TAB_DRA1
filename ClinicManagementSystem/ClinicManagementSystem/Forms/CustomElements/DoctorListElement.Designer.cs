
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
            this.UpperMainLabel = new DisabledLabel();
            this.BottomLabelOne = new DisabledLabel();
            this.BottomLabelTwo = new DisabledLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::ClinicManagementSystem.Properties.Resources.medical_symbol;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 85);
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
            this.UpperMainLabel.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpperMainLabel.Location = new System.Drawing.Point(96, 4);
            this.UpperMainLabel.Name = "UpperMainLabel";
            this.UpperMainLabel.Size = new System.Drawing.Size(211, 37);
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
            this.BottomLabelOne.Location = new System.Drawing.Point(96, 57);
            this.BottomLabelOne.Name = "BottomLabelOne";
            this.BottomLabelOne.Size = new System.Drawing.Size(147, 24);
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
            this.BottomLabelTwo.Location = new System.Drawing.Point(303, 57);
            this.BottomLabelTwo.Name = "BottomLabelTwo";
            this.BottomLabelTwo.Size = new System.Drawing.Size(146, 24);
            this.BottomLabelTwo.TabIndex = 3;
            this.BottomLabelTwo.Text = "BottomTextTwo";
            this.BottomLabelTwo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListElement_MouseDown);
            this.BottomLabelTwo.MouseLeave += new System.EventHandler(this.ListElement_MouseLeave);
            this.BottomLabelTwo.MouseHover += new System.EventHandler(this.ListElement_MouseHover);
            // 
            // DoctorListElement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.Controls.Add(this.BottomLabelTwo);
            this.Controls.Add(this.BottomLabelOne);
            this.Controls.Add(this.UpperMainLabel);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DoctorListElement";
            this.Size = new System.Drawing.Size(526, 90);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListElement_MouseDown);
            this.MouseLeave += new System.EventHandler(this.ListElement_MouseLeave);
            this.MouseHover += new System.EventHandler(this.ListElement_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label UpperMainLabel;
        private System.Windows.Forms.Label BottomLabelOne;
        private System.Windows.Forms.Label BottomLabelTwo;
    }
}
