using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ClinicManagementSystem.Entities.Enums;

namespace ClinicManagementSystem.Entities.Models
{
    public class Doctor : PersonWithAccount
    {
        [Required]
        [RegularExpression(@"^[1-9][0-9]{6}$")]
        public string LicenseNumber { get; set; } // numer PWZ

        [Required]
        public Specialization Specialization { get; set; }
    }
}