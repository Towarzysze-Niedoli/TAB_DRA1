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
        WaitingToBeAccepted,
        Returned
    }

    public static class TestStatusExtensions
    {
        public static string ToReadableString(this TestStatus testStatus)
        {
            return testStatus switch
            {
                TestStatus.Pending => "waiting to be done",
                TestStatus.Accepted => "approved by manager",
                TestStatus.Cancelled => "cancelled",
                TestStatus.WaitingToBeAccepted => "done, waiting to be accepted",
                TestStatus.Returned => "done, returned by manager",
                _ => throw new ArgumentOutOfRangeException("Unknown TestStatus")
            };
        }
    }

    
}
