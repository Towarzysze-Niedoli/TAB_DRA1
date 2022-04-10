using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ClinicManagementSystem.Entities.Models
{
    class LaboratoryManager : Person
    {
        public Address? Address { get; set; }
    }
}
