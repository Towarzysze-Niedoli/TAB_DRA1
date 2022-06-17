using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using ClinicManagementSystem.Entities.Models;

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

        public void InitializeValues(Patient patient, DateTime? lastVisit)
        {
            if (patient == null)
                throw new ArgumentNullException(nameof(patient));

            this.NameSurnameLabel.Text = patient.FirstName + " " + patient.LastName;
            this.peselLabel.Text = patient.PersonalIdentityNumber;
            this.PhoneLabel.Text = patient.PhoneNumber;
            this.MailLabel.Text = patient.Email;

            Address address = patient.Address;
            if (address == null)
            {
                this.CityLabel.Text = "";
                this.ZIPCodeLabel.Text = "";
                this.StreetLabel.Text = "";
                this.NumberLabel.Text = "";
            }
            else
            {
                this.CityLabel.Text = address.City;
                this.ZIPCodeLabel.Text = address.ZipCode;
                this.StreetLabel.Text = address.Street;
                this.NumberLabel.Text = address.HomeNumber;
            }
            
            
            if(lastVisit != null)
                this.LastVisitLabel.Text = ((DateTime)lastVisit).ToString("d", CultureInfo.GetCultureInfo("de-DE"));
            else
                this.LastVisitLabel.Text = String.Empty;
        }
    }
}
