
namespace ClinicManagementSystem.Forms.CustomElements
{
    partial class OrderLabListElement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderLabListElement));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UpperMainTextBox = new System.Windows.Forms.RichTextBox();
            this.TickPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TickPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListElement_MouseDown);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.ListElement_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.ListElement_MouseHover);
            // 
            // UpperMainTextBox
            // 
            this.UpperMainTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.UpperMainTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UpperMainTextBox.CausesValidation = false;
            this.UpperMainTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.UpperMainTextBox.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpperMainTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.UpperMainTextBox.Location = new System.Drawing.Point(115, 16);
            this.UpperMainTextBox.Name = "UpperMainTextBox";
            this.UpperMainTextBox.ReadOnly = true;
            this.UpperMainTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.UpperMainTextBox.ShortcutsEnabled = false;
            this.UpperMainTextBox.ShowSelectionMargin = true;
            this.UpperMainTextBox.Size = new System.Drawing.Size(382, 93);
            this.UpperMainTextBox.TabIndex = 4;
            this.UpperMainTextBox.TabStop = false;
            this.UpperMainTextBox.Text = "Lorem ipsum dolor sit amet";
            this.UpperMainTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListElement_MouseDown);
            this.UpperMainTextBox.MouseLeave += new System.EventHandler(this.ListElement_MouseLeave);
            this.UpperMainTextBox.MouseHover += new System.EventHandler(this.ListElement_MouseHover);
            // 
            // TickPictureBox
            // 
            this.TickPictureBox.Image = global::ClinicManagementSystem.Properties.Resources.tick;
            this.TickPictureBox.Location = new System.Drawing.Point(465, 77);
            this.TickPictureBox.Name = "TickPictureBox";
            this.TickPictureBox.Size = new System.Drawing.Size(32, 32);
            this.TickPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TickPictureBox.TabIndex = 5;
            this.TickPictureBox.TabStop = false;
            this.TickPictureBox.Visible = false;
            // 
            // OrderLabListElement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.Controls.Add(this.TickPictureBox);
            this.Controls.Add(this.UpperMainTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "OrderLabListElement";
            this.Size = new System.Drawing.Size(510, 125);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TickPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox UpperMainTextBox;
        private System.Windows.Forms.PictureBox TickPictureBox;
    }
}