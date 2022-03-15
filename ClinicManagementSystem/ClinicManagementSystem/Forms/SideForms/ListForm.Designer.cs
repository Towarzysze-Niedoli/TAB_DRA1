
namespace ClinicManagementSystem.Forms.SideForms
{
    partial class ListForm
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
            this.ListFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // ListFlowPanel
            // 
            this.ListFlowPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.ListFlowPanel.AutoScroll = true;
            this.ListFlowPanel.Location = new System.Drawing.Point(12, 12);
            this.ListFlowPanel.Name = "ListFlowPanel";
            this.ListFlowPanel.Size = new System.Drawing.Size(526, 381);
            this.ListFlowPanel.TabIndex = 0;
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(550, 405);
            this.Controls.Add(this.ListFlowPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ListForm";
            this.Text = "ListForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ListFlowPanel;
    }
}