using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    public partial class MainWindow : Form
    {
        LoginForm _loginForm;
        SideMenu _sideMenu;
        public MainWindow()
        {
            InitializeComponent();
            ShowLoginForm();
            this.LogoutButton.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowLoginForm()
        {
            _loginForm = new LoginForm(LoginButtonClicked)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            this.SideUpperPanel.Controls.Add(_loginForm);
            _loginForm.Show();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            ShowLoginForm();
            this.LogoBox.Show();
            this.LogoText.Show();
            this.LogoutButton.Hide();
            this.SideBottomPanel.Controls.Remove(_sideMenu);
        }

        private void LoginButtonClicked()
        {
            this.LogoBox.Hide();
            this.LogoText.Hide();
            this.LogoutButton.Show();
            this.SideUpperPanel.Controls.Remove(_loginForm);
            ShowSideMenuForm(UserLevel.Manager);
        }

        private void ShowSideMenuForm(UserLevel level)
        {
            _sideMenu = new SideMenu(level)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            this.SideUpperPanel.Controls.Add(_sideMenu);
            _sideMenu.Show();
        }
    }
}
