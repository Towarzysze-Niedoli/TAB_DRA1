using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClinicManagementSystem.Entities.Models
{
    public abstract class Person
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-ZĄąĆćĘęŁłŃńÓóŚśŻżŹź'\- ]{1,50}$")] // up to 50 uppercase and lowercase characters
        public string FirstName { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-ZĄąĆćĘęŁłŃńÓóŚśŻżŹź'\- ]{1,50}$")] // up to 50 uppercase and lowercase characters
        public string LastName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        public Address Address { get; set; }
    }
}