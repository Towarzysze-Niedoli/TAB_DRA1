using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Auth.Exceptions
{
    public class InvalidPasswordException : Exception
    {
        public InvalidPasswordException()
        {
        }

        public InvalidPasswordException(string message)
            : base(message)
        {
        }

        public InvalidPasswordException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
