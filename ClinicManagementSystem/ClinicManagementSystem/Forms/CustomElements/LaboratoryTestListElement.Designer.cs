namespace ClinicManagementSystem.Forms.CustomElements
{
    partial class LaboratoryTestListElement
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaboratoryTestListElement));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UpperMainLabel = new DisabledLabel();
            this.BottomLabelOne = new DisabledLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            //this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabTestElement_MouseDown);
            //this.pictureBox1.MouseLeave += new System.EventHandler(this.LabTestElement_MouseLeave);
            //this.pictureBox1.MouseHover += new System.EventHandler(this.LabTestElement_MouseHover);
            // 
            // UpperMainLabel
            // 
            this.UpperMainLabel.AutoEllipsis = true;
            this.UpperMainLabel.AutoSize = true;
            this.UpperMainLabel.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpperMainLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.UpperMainLabel.Location = new System.Drawing.Point(70, 4);
            this.UpperMainLabel.Name = "UpperMainLabel";
            this.UpperMainLabel.Size = new System.Drawing.Size(289, 64);
            this.UpperMainLabel.TabIndex = 1;
            this.UpperMainLabel.Text = "UpperMainText";
            //this.UpperMainLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabTestElement_MouseDown);
            //this.UpperMainLabel.MouseLeave += new System.EventHandler(this.LabTestElement_MouseLeave);
            //this.UpperMainLabel.MouseHover += new System.EventHandler(this.LabTestElement_MouseHover);
            // 
            // BottomLabelOne
            // 
            this.BottomLabelOne.AutoEllipsis = true;
            this.BottomLabelOne.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BottomLabelOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.BottomLabelOne.Location = new System.Drawing.Point(70, 77);
            this.BottomLabelOne.Name = "BottomLabelOne";
            this.BottomLabelOne.Size = new System.Drawing.Size(289, 43);
            this.BottomLabelOne.TabIndex = 2;
            this.BottomLabelOne.Text = "BottomTextOne";
            //this.BottomLabelOne.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabTestElement_MouseDown);
            //this.BottomLabelOne.MouseLeave += new System.EventHandler(this.LabTestElement_MouseLeave);
            //this.BottomLabelOne.MouseHover += new System.EventHandler(this.LabTestElement_MouseHover);
            // 
            // LaboratoryTestListElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.Controls.Add(this.BottomLabelOne);
            this.Controls.Add(this.UpperMainLabel);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LaboratoryTestListElement";
            this.Size = new System.Drawing.Size(500, 110);
            //this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabTestElement_MouseDown);
            //this.MouseLeave += new System.EventHandler(this.LabTestElement_MouseLeave);
            //this.MouseHover += new System.EventHandler(this.LabTestElement_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label UpperMainLabel;
        private System.Windows.Forms.Label BottomLabelOne;
    }
}
