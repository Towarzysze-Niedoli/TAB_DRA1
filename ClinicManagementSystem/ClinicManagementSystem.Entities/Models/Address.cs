using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClinicManagementSystem.Entities.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }

        [Required(ErrorMessage = "Street name is required")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Home number is required")]
        public string HomeNumber { get; set; }

        [Required(ErrorMessage = "Zip code is required")]
        [RegularExpression(@"^[0-9]{2}-[0-9]{3}$", ErrorMessage = "Zip code is not in valid format: XX-XXX")]
        public string ZipCode { get; set; }

    }

    
}