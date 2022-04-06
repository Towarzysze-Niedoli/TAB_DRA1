#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClinicManagementSystem.Entities.Models
{
    public class PhysicalExam
    {
        [Key]
        public int Id { get; set; }

        string? Result { get; set; }

        [Required]
        Appointment Appointment { get; set; }

        [Required]
        Examination Examination { get; set; }
    }
}
