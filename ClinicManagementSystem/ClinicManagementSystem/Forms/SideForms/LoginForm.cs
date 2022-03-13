using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClinicManagementSystem.Forms.SideForms
{
    public partial class LoginForm : Form
    {
        private Action _loginButtonClicked;
        public LoginForm(Action loginButtonClicked)
        {
            InitializeComponent();
            _loginButtonClicked += loginButtonClicked;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            _loginButtonClicked.Invoke();
        }
    }
}
