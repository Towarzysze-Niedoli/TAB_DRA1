using ClinicManagementSystem.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClinicManagementSystem.Entities.Models
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }

        public string? Description { get; set; }

        public string? Diagnosis { get; set; }

        [Required]
        public AppointmentStatus AppointmentStatus { get; set; } = AppointmentStatus.Pending;

        public DateTime? RegistrationDate { get; set; }

        public DateTime? CompletionDate { get; set; }

        public Receptionist Receptionist { get; set; }

        [Required]
        public Doctor Doctor { get; set; }

        public Patient Patient { get; set; }

        [InverseProperty("Appointment")] // explicit bidirectional mapping, default lazy loading
        public List<LaboratoryExam> LaboratoryExams { get; set; }

        [InverseProperty("Appointment")] // explicit bidirectional mapping, default lazy loading
        public List<PhysicalExam> PhysicalExams { get; set; }


    }
}