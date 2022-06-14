using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ClinicManagementSystem.Entities.Enums;

namespace ClinicManagementSystem.Entities.Models
{
    public class Doctor : PersonWithAccount
    {
        [Required(ErrorMessage = "License number is required")]
        [RegularExpression(@"^[1-9][0-9]{6}$", ErrorMessage = "License number is not in valid format (7 digits, not starting with 0)")]
        public string LicenseNumber { get; set; } // numer PWZ

        [Required(ErrorMessage = "Doctor specialization is required")]
        public Specialization Specialization { get; set; }
    }
}