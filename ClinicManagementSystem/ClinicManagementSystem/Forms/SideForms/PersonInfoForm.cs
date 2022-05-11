using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace ClinicManagementSystem.Forms.SideForms
{
    public partial class PersonInfoForm : Form
    {
        public PersonInfoForm()
        {
            InitializeComponent(); 
            Dock = DockStyle.Fill;
            this.TopMost = true;
            this.TopLevel = false;
        }

        public void InitializeValues(string pesel, string phoneNumber, string city, string zipCode,
            string streetName, string houseNumber, string mail, DateTime lastVisit)
        {
            this.peselLabel.Text = pesel;
            this.PhoneLabel.Text = phoneNumber;
            this.CityLabel.Text = city;
            this.ZIPCodeLabel.Text = zipCode;
            this.StreetLabel.Text = streetName;
            this.NumberLabel.Text = houseNumber;
            this.MailLabel.Text = mail;
            this.LastVisitLabel.Text = lastVisit.ToString("d", CultureInfo.GetCultureInfo("de-DE"));
        }
    }
}
