using System;

namespace ClinicManagementSystem.Models
{
    public class Address
    {
        public int ID { get; set; }
        public String City { get; set; }
        public String Street { get; set; }
        public String HomeNumber { get; set; }
        public String ZipCode { get; set; } // TODO zmienic na klase zipcode?
    }
}
