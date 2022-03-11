
namespace ClinicManagementSystem
{
    partial class MainWindow  
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SideBottomPanel = new System.Windows.Forms.Panel();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SideUpperPanel = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.LogoText = new System.Windows.Forms.Label();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.SideBottomPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SideBottomPanel
            // 
            this.SideBottomPanel.Controls.Add(this.LogoutButton);
            this.SideBottomPanel.Controls.Add(this.CancelButton);
            this.SideBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SideBottomPanel.Location = new System.Drawing.Point(0, 722);
            this.SideBottomPanel.Name = "SideBottomPanel";
            this.SideBottomPanel.Size = new System.Drawing.Size(300, 178);
            this.SideBottomPanel.TabIndex = 0;
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(95)))), ((int)(((byte)(85)))));
            this.LogoutButton.FlatAppearance.BorderSize = 0;
            this.LogoutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.LogoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(65)))), ((int)(((byte)(68)))));
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.LogoutButton.Location = new System.Drawing.Point(74, 40);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(150, 50);
            this.LogoutButton.TabIndex = 0;
            this.LogoutButton.Text = "Log out";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(95)))), ((int)(((byte)(85)))));
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.CancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(65)))), ((int)(((byte)(68)))));
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.CancelButton.Location = new System.Drawing.Point(74, 116);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(150, 50);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Close";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.panel1.Controls.Add(this.SideUpperPanel);
            this.panel1.Controls.Add(this.SideBottomPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 900);
            this.panel1.TabIndex = 0;
            // 
            // SideUpperPanel
            // 
            this.SideUpperPanel.Location = new System.Drawing.Point(0, 144);
            this.SideUpperPanel.Name = "SideUpperPanel";
            this.SideUpperPanel.Size = new System.Drawing.Size(300, 570);
            this.SideUpperPanel.TabIndex = 1;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.LogoText);
            this.MainPanel.Controls.Add(this.LogoBox);
            this.MainPanel.Location = new System.Drawing.Point(300, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1300, 900);
            this.MainPanel.TabIndex = 1;
            // 
            // LogoText
            // 
            this.LogoText.AutoSize = true;
            this.LogoText.Font = new System.Drawing.Font("Corbel", 60.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogoText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.LogoText.Location = new System.Drawing.Point(252, 636);
            this.LogoText.Name = "LogoText";
            this.LogoText.Size = new System.Drawing.Size(796, 124);
            this.LogoText.TabIndex = 1;
            this.LogoText.Text = "MEDICAL CLINIC";
            // 
            // LogoBox
            // 
            this.LogoBox.Image = global::ClinicManagementSystem.Properties.Resources.medical__1_;
            this.LogoBox.Location = new System.Drawing.Point(394, 144);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(512, 512);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LogoBox.TabIndex = 0;
            this.LogoBox.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.SideBottomPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideBottomPanel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.Label LogoText;
        private System.Windows.Forms.Panel SideUpperPanel;
        private System.Windows.Forms.Button LogoutButton;
    }
}

