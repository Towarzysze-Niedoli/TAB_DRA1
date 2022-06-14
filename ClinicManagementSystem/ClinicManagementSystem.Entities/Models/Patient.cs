using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClinicManagementSystem.Entities.Models
{
    public class Patient : Person
    {
        [Required(ErrorMessage = "Personal Identity Number is required")]
        [RegularExpression(@"^[0-9]{11}$", ErrorMessage = "Personal Identity Number is not in valid format (11 digits)")]
        public string PersonalIdentityNumber { get; set; } // TODO klasa PESEL ? ~PR

        [Required(ErrorMessage = "Address is required")]
        public new Address Address { get; set; }
    }
}