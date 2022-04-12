using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Entities.Enums
{
    public enum TestStatus 
    {
        Pending = AppointmentStatus.Pending,
        Accepted = AppointmentStatus.Accepted,
        Cancelled = AppointmentStatus.Cancelled,
        WaitingToBeAccepted
    }
}
