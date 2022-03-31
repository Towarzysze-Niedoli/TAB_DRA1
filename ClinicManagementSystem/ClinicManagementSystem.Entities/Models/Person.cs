#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClinicManagementSystem.Entities.Models
{
    abstract class Person
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,50}$")] // up to 50 uppercase and lowercase characters
        public string FirstName { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,50}$")] // up to 50 uppercase and lowercase characters
        public string LastName { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        [Phone]
        public string? PhoneNumber { get; set; }
    }
}

#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.