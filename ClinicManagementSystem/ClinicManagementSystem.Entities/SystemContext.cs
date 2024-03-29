﻿using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementSystem.Entities
{
    public class SystemContext : DbContext, ISystemContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Receptionist> Receptionists { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<LaboratoryExam> LaboratoryExams { get; set; }
        public DbSet<PhysicalExam> PhysicalExams { get; set; }
        public DbSet<Examination> Examinations { get; set; }
        public DbSet<LaboratoryTechnician> LaboratoryTechnicians { get; set; }
        public DbSet<LaboratoryManager> LaboratoryManagers { get; set; }
        public DbSet<Admin> SystemAdministrators { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public Task DbConnectionInitialization { get; set; }

        public SystemContext() : base("CMS")
        {
#if DEBUG
            this.Database.Log += s => System.Diagnostics.Debug.Write(s);
#endif
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Entry>()
        //        .Ignore(e => e.IsManaged)
        //        .Ignore(e => e.IsValid)
        //         //etc.
        //}
    }
}