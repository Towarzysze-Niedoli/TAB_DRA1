using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClinicManagementSystem.Entities.Models
{
    public class Doctor : Person
    {
        [Required]
        [RegularExpression(@"^[1-9][0-9]{6}$")]
        public uint LicenseNumber { get; set; } // numer PWZ

        public Address? Address { get; set; }
    }
}