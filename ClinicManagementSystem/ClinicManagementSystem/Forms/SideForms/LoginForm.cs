using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClinicManagementSystem.Forms.EventArguments;

namespace ClinicManagementSystem.Forms.SideForms
{
    public partial class LoginForm : Form
    {
        public delegate void NextPageButtonClicked(object source, PageControllingButtonClickedArgs args);

        public event NextPageButtonClicked ButtonClicked;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            ButtonClicked.Invoke(this, new PageControllingButtonClickedArgs(MainForms.MainFormType.Main, UserLevel.Manager));
        }
    }
}
