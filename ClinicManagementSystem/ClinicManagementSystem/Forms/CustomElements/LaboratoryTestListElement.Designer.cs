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
            this.UpperMainLabel = new System.Windows.Forms.Label();
            this.BottomLabelOne = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UpperMainLabel
            // 
            this.UpperMainLabel.AutoEllipsis = true;
            this.UpperMainLabel.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpperMainLabel.Location = new System.Drawing.Point(94, 3);
            this.UpperMainLabel.Name = "UpperMainLabel";
            this.UpperMainLabel.Size = new System.Drawing.Size(253, 48);
            this.UpperMainLabel.TabIndex = 1;
            this.UpperMainLabel.Text = "UpperMainText";
            // 
            // BottomLabelOne
            // 
            this.BottomLabelOne.AutoEllipsis = true;
            this.BottomLabelOne.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BottomLabelOne.Location = new System.Drawing.Point(203, 58);
            this.BottomLabelOne.Name = "BottomLabelOne";
            this.BottomLabelOne.Size = new System.Drawing.Size(144, 32);
            this.BottomLabelOne.TabIndex = 2;
            this.BottomLabelOne.Text = "BottomTextOne";
            // 
            // LaboratoryTestListElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.Controls.Add(this.BottomLabelOne);
            this.Controls.Add(this.UpperMainLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LaboratoryTestListElement";
            this.Size = new System.Drawing.Size(350, 90);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label UpperMainLabel;
        private System.Windows.Forms.Label BottomLabelOne;
    }
}
