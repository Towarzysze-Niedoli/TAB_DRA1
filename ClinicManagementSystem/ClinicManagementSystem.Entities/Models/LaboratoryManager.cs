using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ClinicManagementSystem.Entities.Models
{
    public class LaboratoryManager : Person
    {
        public Address? Address { get; set; }
    }
}
