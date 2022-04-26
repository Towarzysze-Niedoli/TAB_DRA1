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

        [EmailAddress]
        public string? Email { get; set; }

        [Phone]
        public string? PhoneNumber { get; set; }

        public string Password { get; set; }

        //public UserType UserType { get; set; }
    }
}
