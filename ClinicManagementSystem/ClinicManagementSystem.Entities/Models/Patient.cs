#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClinicManagementSystem.Entities.Models
{
    class Patient : Person
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

#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.