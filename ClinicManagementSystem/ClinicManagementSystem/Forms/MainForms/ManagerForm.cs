using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClinicManagementSystem.Forms.MainForms
{
    public partial class ManagerForm : Form
    {
        private MainFormType _formType;
        public ManagerForm(MainFormType formType)
        {
            this._formType = formType;
            InitializeComponent();
            SpecializationComboBox.SelectedIndex = 0;
            ShowCorrectElements();
        }

        private void HideBtns()
        {
            UpdateButton.Hide();
            DeleteButton.Hide();
        }

        private void HideForDoctor()
        {
            LabTechicianRadioButton.Hide();
            LabManagerRadioButton.Hide();
        }

        private void HideForLab()
        {
            DoctoralLabel.Hide();
            SpecializationComboBox.Hide();
        }


        private void HideLogin()
        {
            LoginLabel.Hide();
            LoginTextBox.Hide();
            PasswordTextBox.Hide();
        }

        private void Receptionist()
        {
            HideForLab();
            HideForDoctor();
            HideBtns();
            SetUserCategories("Receptionist");
        }

        private void Doctor()
        {
            HideForDoctor();
            HideBtns();
            SetUserCategories("Doctor");
        }

        private void Lab()
        {
            HideForLab();
            HideBtns();
            SetUserCategories("Lab Worker");
        }

        private void Patient()
        {
            HideLogin();
            HideForDoctor();
            HideForLab();
            HideBtns();
            SetUserCategories("Patient");
        }

        private void SetUserCategories(string user)
        {
            SearchUserTextBox.PlaceholderText = "Search " + user + " for Update";
            LoginTextBox.PlaceholderText = user + "'s Login";
            PasswordTextBox.PlaceholderText = user + "'s Password";
            AddButton.Text = "Add " + user;
            UpdateButton.Text = "Update " + user;
            DeleteButton.Text = "Delete " + user;
        }

        private void ShowCorrectElements()
        {
            switch (_formType)
            {
                case MainFormType.ManagerDoctors:
                    Doctor();
                    break;
                case MainFormType.ManagerLaboratory:
                    Lab();
                    break;
                case MainFormType.ManagerReceptionist:
                    Receptionist();
                    break;
                case MainFormType.ManagerPatients:
                    Patient();
                    break;
                default:
                    break;
            }
        }

        private void SearchUserButton_Click(object sender, EventArgs e)
        {
            if (SearchUserTextBox.Text != "")
            {
                if (SearchUserTextBox.Text == "997")
                {
                    SearchUserTextBox.Clear();
                    UpdateButton.Show();
                    DeleteButton.Show();
                    PESELTextBox.Text = "997";
                    PhoneTextBox.Text = "1234";
                    UserNameTextBox.Text = "Mateusz";
                    UserSurnameTextBox.Text = "Nieadamczyk";
                    CityTextBox.Text = "Bajtom";
                    StreetTextBox.Text = "Szybka";
                    ZIPCodeTextBox.Text = "12-345";
                    NumberTextBox.Text = "12";
                    EMailTextBox.Text = "szybkimail@hot.com";
                    LoginTextBox.Text = "997";
                    PasswordTextBox.Text = "1234";
                }
            }
        }


        private void ClearData()
        {
            PESELTextBox.Clear();
            PhoneTextBox.Clear();
            UserNameTextBox.Clear();
            UserSurnameTextBox.Clear();
            CityTextBox.Clear();
            StreetTextBox.Clear();
            ZIPCodeTextBox.Clear();
            NumberTextBox.Clear();
            EMailTextBox.Clear();
            LoginTextBox.Clear();
            PasswordTextBox.Clear();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
