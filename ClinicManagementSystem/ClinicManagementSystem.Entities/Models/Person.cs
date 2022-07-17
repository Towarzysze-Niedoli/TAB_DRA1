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

        [Required(ErrorMessage = "First name is required")]
        [RegularExpression(@"^[a-zA-ZĄąĆćĘęŁłŃńÓóŚśŻżŹź'\- ]{1,50}$", ErrorMessage = "First name cannot contain forbidden characters or be longer than 50 characters")] // up to 50 uppercase and lowercase characters
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [RegularExpression(@"^[a-zA-ZĄąĆćĘęŁłŃńÓóŚśŻżŹź'\- ]{1,50}$", ErrorMessage = "Last name cannot contain forbidden characters or be longer than 50 characters")] // up to 50 uppercase and lowercase characters
        public string LastName { get; set; }

        [EmailAddress(ErrorMessage = "Entered email address is not a valid email address")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Entered phone number is not a valid phone number")]
        public string PhoneNumber { get; set; }

        public Address Address { get; set; }

        public string FullName => $"{this.FirstName} {this.LastName}";
    }
}