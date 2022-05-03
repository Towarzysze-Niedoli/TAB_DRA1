using ClinicManagementSystem.Entities;
using ClinicManagementSystem.Entities.Models;
using ClinicManagementSystem.Repositories.Repositories.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
/*
            // for testing CLEAN UP LATER
            Doctor doctor = new Doctor()
            {
                FirstName = "dff",
                LastName = "sdff",
                Email = "dsff@gmail.com",
                PhoneNumber = "999000999",
                Address = new Entities.Address() { City = "Kato", HomeNumber = "1", Street = "gfdg", ZipCode = "41-700" },
                LicenseNumber = 1955646
            };
            DoctorRepository doctorRepository = new DoctorRepository(new SystemContext());
            //doctorRepository.InsertDoctor(doctor);
            doctorRepository.DeleteDoctor(3);
            //doctorRepository.Save();
            //doctor.LastName = "sdfgkjnjgf";
            //doctorRepository.UpdateDoctor(doctor);
            doctorRepository.Save();
            //List<Doctor> docs = doctorRepository.GetDoctors().ToList();
*/
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
