using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using ClinicManagementSystem.Auth.Exceptions;
using ClinicManagementSystem.Entities;
using ClinicManagementSystem.Entities.Models;

namespace ClinicManagementSystem.Auth.Services
{
    public class AuthenticationService
    {
        public ApplicationUser Authenticate(string emailOrPhone, string password)
        {
            using SystemContext dbContext = new SystemContext();

            var (userPredicate, personPredicate) = GetPredicates(emailOrPhone);

            ApplicationUser user = FindUser(emailOrPhone, userPredicate);

            if (!PasswordHasher.Verify(password, user.Password))
                throw new InvalidPasswordException($"Invalid password for user with email address {user.Email}");

            return user;
        }
        
        public ApplicationUser CreateNewUser(string? email, string? phoneNumber, string password)
        {
            if (email == null && phoneNumber == null)
                throw new ArgumentNullException("email && phoneNumber");

            using SystemContext dbContext = new SystemContext();

            if (dbContext.ApplicationUsers.Where(user => user.Email == email || user.PhoneNumber == phoneNumber).Any())
                throw new InvalidLoginException("Email or phone number already exists!");

            ApplicationUser user = new ApplicationUser()
            {
                Email = email,
                PhoneNumber = phoneNumber,
                Password = PasswordHasher.Hash(password)
            };
            dbContext.ApplicationUsers.Add(user);
            dbContext.SaveChanges();
            return user;
        }

        public ApplicationUser ChangePasswordForUser(ApplicationUser user, string newPassword)
        {
            if (PasswordHasher.Verify(newPassword, user.Password))
                throw new InvalidPasswordException("Password cannot be identical to the previous one");

            using SystemContext dbContext = new SystemContext();

            user = dbContext.ApplicationUsers.Attach(user);
            user.Password = PasswordHasher.Hash(newPassword);
            dbContext.SaveChanges();
            return user;
        }

        public ApplicationUser ChangePasswordForUser(string emailOrPhone, string newPassword)
        {
            using SystemContext dbContext = new SystemContext();

            var (userPredicate, personPredicate) = GetPredicates(emailOrPhone);
            ApplicationUser user = FindUser(emailOrPhone, userPredicate);
            return ChangePasswordForUser(user, newPassword);
        }

        public ApplicationUser ChangeUserData(ApplicationUser user, string? newEmail, string? newPhoneNumber)
        {
            using SystemContext dbContext = new SystemContext();

            user = dbContext.ApplicationUsers.Attach(user);
            if (newEmail != null)
                user.Email = newEmail;
            if (newPhoneNumber != null)
                user.PhoneNumber = newPhoneNumber;

            dbContext.SaveChanges();
            return user;
        }

        

        private (Func<ApplicationUser, bool> userPredicate, Func<Person, bool> personPredicate) GetPredicates(string emailOrPhone)
        {
            if (new EmailAddressAttribute().IsValid(emailOrPhone))
            {
                return (
                    user => user.Email != null && user.Email.Equals(emailOrPhone),
                    person => person.Email != null && person.Email.Equals(emailOrPhone)
                );
            }
            else if (new PhoneAttribute().IsValid(emailOrPhone))
            {
                return (
                    user => user.PhoneNumber != null && user.PhoneNumber.Equals(emailOrPhone),
                    person => person.PhoneNumber != null && person.PhoneNumber.Equals(emailOrPhone)
                );
            }
            else
            {
                throw new ArgumentException($"{emailOrPhone} is not a valid email address or phone number", nameof(emailOrPhone));
            }
        }

        private ApplicationUser FindUser(string emailOrPhone, Func<ApplicationUser, bool> userPredicate)
        {
            using SystemContext dbContext = new SystemContext();
            try
            {
                return dbContext.ApplicationUsers.Where(userPredicate).Single();
            }
            catch (InvalidOperationException ex)
            {
                throw new InvalidLoginException($"Invalid login: {emailOrPhone}", ex);
            }
        }
    }
}
