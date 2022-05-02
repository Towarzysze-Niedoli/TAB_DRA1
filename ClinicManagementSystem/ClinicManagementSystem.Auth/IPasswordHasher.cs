using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Auth
{
    public interface IPasswordHasher
    {
        /// <summary>
        /// Creates a hash from a password.
        /// </summary>
        /// <param name="password">password</param>
        /// <param name="iterations">number of iterations</param>
        /// <returns>hashed password</returns>
        public string Hash(string password, int iterations);

        /// <summary>
        /// Creates a hash from a password with default number of iterations
        /// </summary>
        /// <param name="password">password</param>
        /// <returns>hashed password</returns>
        public string Hash(string password);

        /// <summary>
        /// Verifies a password against a hash.
        /// </summary>
        /// <param name="password">password</param>
        /// <param name="hashedPassword">hash</param>
        /// <returns>true if matches</returns>
        public bool Verify(string password, string hashedPassword);
    }
}
