﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using ClinicManagementSystem.Entities.Enums;

namespace ClinicManagementSystem.Entities.Models
{
    public class Examination
    {
        [Key]
        [RegularExpression(@"^Z[0-9]{2}.[0-9]$")]
        public string Code { get; set; } // ICD-10 code, eg. Z46.3

        [Required]
        public ExaminationType ExamType { get; set; }

        public string? ExaminationName;
    }
}