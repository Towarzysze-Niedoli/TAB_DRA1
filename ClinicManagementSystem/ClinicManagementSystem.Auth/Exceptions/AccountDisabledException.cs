using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Auth.Exceptions
{
    public class AccountDisabledException : Exception
    {
        public AccountDisabledException()
        {
        }

        public AccountDisabledException(string message)
            : base(message)
        {
        }

        public AccountDisabledException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
