using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClinicManagementSystem.Auth.Exceptions;
using ClinicManagementSystem.Auth.Services;
using ClinicManagementSystem.Entities.Models;
using ClinicManagementSystem.Forms.EventArguments;
using Microsoft.Extensions.DependencyInjection;

namespace ClinicManagementSystem.Forms.SideForms
{
    public partial class LoginForm : Form
    {
        public delegate void NextPageButtonClicked(object source, PageControllingButtonClickedArgs args);

        public event NextPageButtonClicked ButtonClicked;
        private IServiceProvider _provider;
        private IAuthenticationService _authenticationService;
        private IAuthorizationService _authorizationService;
        private Action _closeApplication;

        public LoginForm(IServiceProvider provider, Action closeApplicationFunction)
        {
            _provider = provider;
            _authenticationService = _provider.GetService<IAuthenticationService>();
            _authorizationService = _provider.GetService<IAuthorizationService>();
            _closeApplication = closeApplicationFunction;

            InitializeComponent();
            AcceptButton = loginButton;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            ApplicationUser user;
            try
            {
                LoginStatusLabel.Text = "Logging in...";
                user = _authenticationService.Authenticate(loginTextBox.Text.Trim(), passwordTextBox.Text.Trim());
                LoginStatusLabel.Text = "";
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Please enter your email or phone number", "Invalid login", MessageBoxButtons.OK);
                LoginStatusLabel.Text = "";
                return;
            }
            catch (InvalidLoginException)
            {
                MessageBox.Show("User with provided login not found", "Invalid login", MessageBoxButtons.OK);
                LoginStatusLabel.Text = "";
                return;
            }
            catch (InvalidPasswordException)
            {
                MessageBox.Show("Provided password is not correct. If you have forgotten your password, please contact system administrator", "Invalid password", MessageBoxButtons.OK);
                LoginStatusLabel.Text = "";
                return;
            }
            catch (NoDatabaseConnectionException ex)
            {
                MessageBox.Show(ex.Message + "\nThe application will close now", "Database connection error", MessageBoxButtons.OK);
                _closeApplication();
                return;
            }

            PersonWithAccount person = _authorizationService.UserLogin(user);
            if (person is null)
            {
                MessageBox.Show("Your account is not linked with any role. Please contact system administrator", "Role not found", MessageBoxButtons.OK);
                return;
            }

            UserLevel userLevel = PersonToUserLevel.GetLevel(person.GetType());
            ButtonClicked.Invoke(this, new PageControllingButtonClickedArgs(MainForms.MainFormType.Main, userLevel));
        }
    }
}
