using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace ClinicManagementSystem.Entities
{
    public class Address
    {
        public int ID { get; set; }
        public String City { get; set; }
        public String Street { get; set; }
        public String HomeNumber { get; set; }
        public String ZipCode { get; set; } // TODO zmienic na klase zipcode?
    }

    public class AddressDbContext : DbContext
    {
        public AddressDbContext()
        {
        }

        public DbSet<Address> Addresses { get; set; }
    }
}


