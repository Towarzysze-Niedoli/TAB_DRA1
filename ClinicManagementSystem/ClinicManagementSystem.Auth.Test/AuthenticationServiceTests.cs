using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClinicManagementSystem.Auth;
using ClinicManagementSystem.Auth.Services;
using ClinicManagementSystem.Entities.Models;
using ClinicManagementSystem.Entities;
using System;
using System.Linq;
using ClinicManagementSystem.Auth.Exceptions;

namespace ClinicManagementSystem.Auth.Test
{
    [TestClass]
    public class AuthenticationServiceTests
    {
        private static readonly SystemContext dbContext = new SystemContext();
        readonly IAuthenticationService authenticationService = new AuthenticationService(new PasswordHasher(), dbContext);

        const int n = 5;
        readonly static string[] emails = new string[n] { "email@email.com", "second@different.pl", "another@some.com.pl", null, null };
        readonly static string[] phones = new string[n] { "123456789", "322427042", null, "+48258147369", null };
        readonly static string[] passwords = new string[n] { "TAB_DRA1", "qwerty 123", "G33DqSg@fgmU9CJK", "#6j@&@7gQWEzck8V", "T3*w8$ijtPA$Uzz2" };

        private static int RemoveEntries()
        {
            // remove necessary existing entries:
            dbContext.ApplicationUsers.RemoveRange(
                dbContext.ApplicationUsers.Where(user => emails.Contains(user.Email) || phones.Contains(user.PhoneNumber))
            );
            return dbContext.SaveChanges();
        }

        [TestMethod]
        public void CreateUserTest()
        {
            RemoveEntries();

            // insert:
            for (int i = 0; i < n; i++)
            {
                if (emails[i] == null && phones[i] == null)
                    Assert.ThrowsException<ArgumentNullException>(() => authenticationService.AddNewUser(emails[i], phones[i], passwords[i]));
                else
                {
                    ApplicationUser createdUser = authenticationService.AddNewUser(emails[i], phones[i], passwords[i]);
                    ApplicationUser foundUser = dbContext.ApplicationUsers.Find(createdUser.Id);
                    Assert.AreEqual(emails[i], foundUser.Email);
                    Assert.AreEqual(phones[i], foundUser.PhoneNumber);
                    Assert.AreEqual(createdUser.Password, foundUser.Password);
                    // double insertion:
                    Assert.ThrowsException<InvalidLoginException>(() => authenticationService.AddNewUser(emails[i], phones[i], passwords[i]));
                }
            }
        }

        [TestMethod]
        public void AuthenticateUserTest()
        {
            RemoveEntries();

            // insert and auth:
            for (int i = 0; i < n; i++)
            {
                if (emails[i] != null || phones[i] != null)
                {
                    if (emails[i] != null)
                        Assert.ThrowsException<InvalidLoginException>(() => authenticationService.Authenticate(emails[i], passwords[i]));
                    if (phones[i] != null)
                        Assert.ThrowsException<InvalidLoginException>(() => authenticationService.Authenticate(phones[i], passwords[i]));

                    ApplicationUser createdUser = authenticationService.AddNewUser(emails[i], phones[i], passwords[i]);

                    if (emails[i] != null)
                        Assert.AreEqual(createdUser.Id, authenticationService.Authenticate(emails[i], passwords[i]).Id);
                    if (phones[i] != null)
                        Assert.AreEqual(createdUser.Id, authenticationService.Authenticate(phones[i], passwords[i]).Id);
                }
            }
        }

        [TestMethod]
        public void ChangePasswordForUserTest()
        {
            RemoveEntries();

            // insert and auth:
            for (int i = 0; i < n; i++)
            {
                if (emails[i] != null || phones[i] != null)
                {
                    ApplicationUser user = authenticationService.AddNewUser(emails[i], phones[i], passwords[i]);
                    
                    Assert.ThrowsException<InvalidPasswordException>(() => authenticationService.ChangePasswordForUser(user, passwords[i]));
                    string newPassword = passwords[i] + "an0th3r!#@$";
                    authenticationService.ChangePasswordForUser(user, newPassword);

                    AssertCorrectPasswordChange(emails[i], phones[i], passwords[i], newPassword, user.Id);
                }
            }
        }

        [TestMethod]
        public void ChangePasswordByLoginTest()
        {
            RemoveEntries();

            // insert and auth:
            for (int i = 0; i < n; i++)
            {
                if (emails[i] != null || phones[i] != null)
                {
                    ApplicationUser user = authenticationService.AddNewUser(emails[i], phones[i], passwords[i]);

                    if (user.Email != null)
                    {
                        string newPassword = passwords[i] + "an0th3r!#@$";
                        authenticationService.ChangePasswordForUser(user.Email, newPassword);

                        AssertCorrectPasswordChange(emails[i], phones[i], passwords[i], newPassword, user.Id);
                    }

                    if (user.PhoneNumber != null)
                    {
                        string newPassword = passwords[i] + "diff3r3nt$%^&";
                        authenticationService.ChangePasswordForUser(user.PhoneNumber, newPassword);

                        AssertCorrectPasswordChange(emails[i], phones[i], passwords[i], newPassword, user.Id);
                    }
                }
            }
        }

        [TestMethod]
        public void ChangeUserDataTest()
        {
            RemoveEntries();
            string baseEmail = "blah@someemail.blah";
            string basePhone = "844530198";
            string basePassword = "s0m3P4ssw0rd";

            // insert and auth:
            for (int i = 0; i < n; i++)
            {
                dbContext.ApplicationUsers.RemoveRange(dbContext.ApplicationUsers.Where(user => baseEmail == user.Email || basePhone == user.PhoneNumber));
                dbContext.SaveChanges();

                ApplicationUser user = authenticationService.AddNewUser(baseEmail, basePhone, basePassword);

                user = authenticationService.ChangeUserData(user, emails[i], phones[i]);

                if (emails[i] == null)
                    Assert.AreEqual(baseEmail, user.Email);
                else
                    Assert.AreEqual(emails[i], user.Email);

                if (phones[i] == null)
                    Assert.AreEqual(basePhone, user.PhoneNumber);
                else
                    Assert.AreEqual(phones[i], user.PhoneNumber);

            }
        }

        private void AssertCorrectPasswordChange(string email, string phone, string oldPassword, string newPassword, int userId)
        {
            if (email != null)
            {
                Assert.ThrowsException<InvalidPasswordException>(() => authenticationService.Authenticate(email, oldPassword));
                Assert.AreEqual(userId, authenticationService.Authenticate(email, newPassword).Id);
            }
            if (phone != null)
            {
                Assert.ThrowsException<InvalidPasswordException>(() => authenticationService.Authenticate(phone, oldPassword));
                Assert.AreEqual(userId, authenticationService.Authenticate(phone, newPassword).Id);
            }
        }
    }
}
