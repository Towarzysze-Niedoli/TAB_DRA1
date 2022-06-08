﻿using System;
using ClinicManagementSystem.Entities.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClinicManagementSystem.Entities.Models
{
    public class LaboratoryExam
    {
        [Key]
        public int Id { get; set; }

        public string Result { get; set; }

        public string DoctorComment { get; set; }

        public string LaboratoryManagerComment { get; set; }

        [Required]
        public DateTime ReferralDate { get; set; }

        /// <summary>
        /// Date when the test was performed or cancelled.
        /// </summary>
        public DateTime? RealisationDate { get; set; }

        /// <summary>
        /// Date when the test was accepted or cancelled.
        /// </summary>
        public DateTime? CompletionDate { get; set; }

        [Required]
        public TestStatus Status { get; set; } = TestStatus.Pending;

        [Required]
        public Appointment Appointment { get; set; }

        [Required]
        public Examination Examination { get; set; }

        public LaboratoryManager LaboratoryManager { get; set; }

        public LaboratoryTechnician LaboratoryTechnician { get; set; }
    }
}
