#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClinicManagementSystem.Entities.Models
{
    class Doctor : Person
    {
        [Required]
        [RegularExpression(@"^[1-9][0-9]{6}$")]
        uint LicenseNumber { get; set; } // numer PWZ

        public Address? Address { get; set; }
    }
}


#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.