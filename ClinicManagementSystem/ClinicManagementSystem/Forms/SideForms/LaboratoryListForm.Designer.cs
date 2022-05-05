
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LabListFlowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabListFlowPanel
            // 
            this.LabListFlowPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.LabListFlowPanel.Controls.Add(this.flowLayoutPanel1);
            this.LabListFlowPanel.Location = new System.Drawing.Point(11, 12);
            this.LabListFlowPanel.Name = "LabListFlowPanel";
            this.LabListFlowPanel.Size = new System.Drawing.Size(480, 532);
            this.LabListFlowPanel.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(250, 125);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // LaboratoryListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(500, 556);
            this.Controls.Add(this.LabListFlowPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LaboratoryListForm";
            this.Text = "LaboratoryListForm";
            this.Load += new System.EventHandler(this.LaboratoryListForm_Load);
            this.LabListFlowPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel LabListFlowPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}