using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClinicManagementSystem.Entities.Models
{
    class Receptionist : Person
    {
        public Address? Address { get; set; }
    }
}
