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

        public string Result { get; set; }

        [Required(ErrorMessage = "Appointment is required for physical exam")]
        public Appointment Appointment { get; set; }

        [Required(ErrorMessage = "Examination is required for physical exam")]
        public Examination Examination { get; set; }
    }
}
