#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

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

        public SystemContext() : base("CMS")
        {

        }
    }
}

#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.