using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace ClinicManagementSystem.Entities.Models
{
    public class ApplicationUser
    {
        [Key]
        public int Id { get; set; }

        [EmailAddress(ErrorMessage = "Entered email address is not a valid email address")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Entered phone number is not a valid phone number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d).{8,}$", ErrorMessage = "Password must be at least 8 characters long and contain at least one letter and one number")]
        public string Password { get; set; }

        [Required]
        public bool IsDisabled { get; set; } = false;

    }
}
