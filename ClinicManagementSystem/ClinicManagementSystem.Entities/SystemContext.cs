using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace ClinicManagementSystem.Entities
{
    class SystemContext : DbContext
    {
        DbSet<Patient> Patients { get; set; }
        DbSet<Address> Addresses { get; set; }
        DbSet<Receptionist> Receptionists { get; set; }
        DbSet<Doctor> Doctors { get; set; }
        DbSet<Appointment> Appointments { get; set; }
        DbSet<LaboratoryExam> LaboratoryExams { get; set; }
        DbSet<PhysicalExam> PhysicalExams { get; set; }
        DbSet<Examination> Examinations { get; set; }
        DbSet<LaboratoryTechnician> LaboratoryTechnicians { get; set; }
        DbSet<LaboratoryManager> LaboratoryManagers { get; set; }


        public SystemContext() : base("CMS")
        {

        }
    }
}