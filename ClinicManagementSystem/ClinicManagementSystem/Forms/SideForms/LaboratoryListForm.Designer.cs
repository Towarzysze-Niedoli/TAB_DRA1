
namespace ClinicManagementSystem.Forms.SideForms
{
    partial class LaboratoryListForm
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
            this.LabListFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // ListFlowPanel
            // 
            this.ListFlowPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListFlowPanel.Size = new System.Drawing.Size(2164, 1071);
            // 
            // LabListFlowPanel
            // 
            this.LabListFlowPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.LabListFlowPanel.AutoScroll = true;
            this.LabListFlowPanel.Location = new System.Drawing.Point(9, 9);
            this.LabListFlowPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LabListFlowPanel.Name = "LabListFlowPanel";
            this.LabListFlowPanel.Size = new System.Drawing.Size(420, 399);
            this.LabListFlowPanel.TabIndex = 0;
            // 
            // LaboratoryListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(2164, 1071);
            this.Controls.Add(this.LabListFlowPanel);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "LaboratoryListForm";
            this.Text = "LaboratoryListForm";
            this.Controls.SetChildIndex(this.LabListFlowPanel, 0);
            this.Controls.SetChildIndex(this.ListFlowPanel, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel LabListFlowPanel;
    }
}