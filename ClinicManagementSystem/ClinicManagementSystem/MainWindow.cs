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
        private LoginForm _loginForm;
        private SideMenu _sideMenu;
        private NewVisitForm _newVisitForm;
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
            _loginForm = new LoginForm(LoginButtonClicked);
            InitializeForm(_loginForm);
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
            _sideMenu = new SideMenu(level, ShowNewVisitForm);
            InitializeForm(_sideMenu);
            this.SideUpperPanel.Controls.Add(_sideMenu);
            _sideMenu.Show();
        }

        private void ShowNewVisitForm()
        {
            _newVisitForm = new NewVisitForm();
            InitializeForm(_newVisitForm);
            this.MainPanel.Controls.Add(_newVisitForm);
            _newVisitForm.Show();
        }

        private void InitializeForm(Form form)
        {
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.TopMost = true;
        }
    }
}
