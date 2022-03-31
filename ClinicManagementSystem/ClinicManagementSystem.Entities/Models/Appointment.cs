#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

using ClinicManagementSystem.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClinicManagementSystem.Entities.Models
{
    class Appointment
    {
        [Key]
        public int Id { get; set; }

        string Description { get; set; }

        string Diagnosis { get; set; } // string? enum? enum[]? ~PR

        [Required]
        Status Status { get; set; } = Status.Pending;

        DateTime? RegistrationDate { get; set; }

        DateTime? CompletionDate { get; set; }

        [Required]
        Receptionist Receptionist { get; set; }

        [Required]
        Doctor Doctor { get; set; }

        [Required]
        Patient Patient { get; set; }
    }
}

#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.