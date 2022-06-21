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

        public string Description { get; set; }

        public string Diagnosis { get; set; }

        [Required]
        public AppointmentStatus AppointmentStatus { get; set; } = AppointmentStatus.Pending;

        [Required]
        public DateTime RegistrationDate { get; set; }

        [Required]
        public DateTime ScheduledDate { get; set; }

        public DateTime? CompletionDate { get; set; }

        public Receptionist Receptionist { get; set; }

        [Required(ErrorMessage = "Doctor is required for an appointment")]
        public Doctor Doctor { get; set; }
        [Required(ErrorMessage = "Patient is required for an appointment")]
        public Patient Patient { get; set; }

        // PR: IList tutaj i nizej? moze sie okazac ze tak lepiej i latwiej bedzie
        [InverseProperty("Appointment")] // explicit bidirectional mapping, default lazy loading
        public List<LaboratoryExam> LaboratoryExams { get; set; }

        [InverseProperty("Appointment")] // explicit bidirectional mapping, default lazy loading
        public List<PhysicalExam> PhysicalExams { get; set; }


    }
}