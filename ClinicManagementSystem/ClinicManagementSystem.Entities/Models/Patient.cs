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
        public Address Address { get; set; }

        //public Patient(string firstName, string lastName, string personalIdentityNumber, string? email, string? phoneNumber)
        //{
        //    FirstName = firstName;
        //    LastName = lastName;
        //    PersonalIdentityNumber = personalIdentityNumber;
        //    Email = email;
        //    PhoneNumber = phoneNumber;
        //}

        //public Patient(int id, string firstName, string lastName, string personalIdentityNumber, string? email, string? phoneNumber) 
        //    : this(firstName, lastName, personalIdentityNumber, email, phoneNumber)
        //{
        //    Id = id;
        //}
    }
}