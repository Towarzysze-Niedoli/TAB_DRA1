using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClinicManagementSystem.Auth;
using ClinicManagementSystem.Auth.Services;
using System;
using System.Linq;

namespace ClinicManagementSystem.Auth.Test
{
    [TestClass]
    public class PasswordHasherTests
    {
        private readonly string[] passwords =
            {
                "testPassword123",
                "TAB_DRA1",
                "qwerty123",
                "G33DqSg@fgmU9CJK",
                "#6j@&@7gQWEzck8V",
                "T3*w8$ijtPA$Uzz2",
                RandomString(8),
                RandomString(10),
                RandomString(12),
                RandomString(16),
                RandomString(32),
                RandomString(64),
            };

        private static readonly Random random = new Random();

        [TestMethod]
        public void HashingTest()
        {
            foreach (string password in passwords)
            {
                string hash1 = PasswordHasher.Hash(password);
                string hash2 = PasswordHasher.Hash(password);

                // assert non-consistent hashing with salt:
                Assert.AreNotEqual(hash1, hash2);
            }
        }

        [TestMethod]
        public void VerificationTest()
        {
            foreach (string password in passwords)
            {
                // assert correct salt detection and password verification:
                for(int i = 0; i < 3; i++)
                {
                    Assert.IsTrue(PasswordHasher.Verify(password, PasswordHasher.Hash(password)));
                }
            }
        }

        public static string RandomString(int length)
        {
            const string chars = @"ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz`~!@#$%^&*()-_+=\|,./<>?[]{};:'""";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

    }
}