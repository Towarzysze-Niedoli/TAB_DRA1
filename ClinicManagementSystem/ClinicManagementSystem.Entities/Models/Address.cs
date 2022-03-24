﻿#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Text;

namespace ClinicManagementSystem.Entities
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public string HomeNumber { get; set; }

        [Required]
        [RegularExpression(@"^[0-9]{2}-[0-9]{3}$")]
        public string ZipCode { get; set; } // TODO zmienic na klase zipcode? ~PR

    }

    
}

#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
