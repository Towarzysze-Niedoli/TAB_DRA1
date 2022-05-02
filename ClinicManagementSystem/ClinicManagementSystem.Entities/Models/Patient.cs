using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClinicManagementSystem.Entities.Models
{
    public class Patient : Person
    {
        [Required]
        [RegularExpression(@"^[0-9]{11}$")]
        public string PersonalIdentityNumber { get; set; } // TODO klasa PESEL ? ~PR

        [Required]
        public new Address Address { get; set; }
    }
}