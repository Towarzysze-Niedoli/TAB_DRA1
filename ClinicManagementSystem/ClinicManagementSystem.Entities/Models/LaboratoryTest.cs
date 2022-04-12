#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

using System;
using ClinicManagementSystem.Entities.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClinicManagementSystem.Entities.Models
{
    public class LaboratoryTest
    {
        [Key]
        public int Id { get; set; }

        string? Result { get; set; }

        string? DoctorComment { get; set; }

        string? LaboratoryHeadComment { get; set; }

        [Required]
        DateTime? ReferralDate { get; set; }

        DateTime? RealisationDate { get; set; }

        DateTime? CompletionDate { get; set; }

        [Required]
        Status Status { get; set; } = Status.Pending;

        [Required]
        Appointment Appointment { get; set; }

        [Required]
        Examination Examination { get; set; }

        LaboratoryManager LaboratoryManager { get; set; }
        
        LabTechnician LabTechnician { get; set; }
    }
}
