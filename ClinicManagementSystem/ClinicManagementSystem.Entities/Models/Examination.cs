using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using ClinicManagementSystem.Entities.Enums;

namespace ClinicManagementSystem.Entities.Models
{
    public class Examination
    {
        [Key]
        public int Code { get; set; }

        [Required]
        ExaminationType ExamType { get; set; }

        string? ExaminationName;
    }
}
