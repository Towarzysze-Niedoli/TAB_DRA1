using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ClinicManagementSystem.Auth
{
    public static class PasswordHasher
    {
        /// <summary>
        /// Size of salt.
        /// </summary>
        private const int SaltSize = 16;

        /// <summary>
        /// Size of hash.
        /// </summary>
        private const int HashSize = 20;

        /// <summary>
        /// Deafult number of iterations.
        /// </summary>
        private const int Iterations = 10000;

        /// <summary>
        /// Creates a hash from a password.
        /// </summary>
        /// <param name="password">password</param>
        /// <param name="iterations">number of iterations</param>
        /// <returns>hashed password</returns>
        public static string Hash(string password, int iterations)
        {
            // Create salt
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[SaltSize]);

            // Create hash
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
            byte[] hash = pbkdf2.GetBytes(HashSize);

            // Combine salt and hash
            byte[] hashBytes = new byte[SaltSize + HashSize];
            Array.Copy(salt, 0, hashBytes, 0, SaltSize);
            Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);

            // Convert to base64
            string base64Hash = Convert.ToBase64String(hashBytes);

            // Format hash with extra information
            return string.Format("{0}${1}", iterations, base64Hash);
        }

        /// <summary>
        /// Creates a hash from a password with default number of iterations
        /// </summary>
        /// <param name="password">password</param>
        /// <returns>hashed password</returns>
        public static string Hash(string password)
        {
            return Hash(password, Iterations);
        }

        /// <summary>
        /// Verifies a password against a hash.
        /// </summary>
        /// <param name="password">password</param>
        /// <param name="hashedPassword">hash</param>
        /// <returns>true if matches</returns>
        public static bool Verify(string password, string hashedPassword)
        {
            // Extract iteration and Base64 string
            string[] splittedHashString = hashedPassword.Split('$');
            int iterations = int.Parse(splittedHashString[0]);
            string base64Hash = splittedHashString[1];

            // Get hash bytes
            byte[] hashBytes = Convert.FromBase64String(base64Hash);

            // Get salt
            byte[] salt = new byte[SaltSize];
            Array.Copy(hashBytes, 0, salt, 0, SaltSize);

            // Create hash with given salt
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
            byte[] hash = pbkdf2.GetBytes(HashSize);

            // Get result
            for (int i = 0; i < HashSize; i++)
                if (hashBytes[i + SaltSize] != hash[i])
                    return false;
            
            return true;
        }
    }
}
