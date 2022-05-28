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
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IPasswordHasher passwordHasher;
        private readonly ISystemContext dbContext;

        public AuthenticationService(IPasswordHasher _passwordHasher, ISystemContext systemContext)
        {
            passwordHasher = _passwordHasher;
            dbContext = systemContext;
        }

        public ApplicationUser Authenticate(string emailOrPhone, string password)
        {
            var (userPredicate, personPredicate) = GetPredicates(emailOrPhone);

            ApplicationUser user = FindUser(emailOrPhone, userPredicate);

            if (!passwordHasher.Verify(password, user.Password))
                throw new InvalidPasswordException($"Invalid password for user with email address {user.Email}");

            return user;
        }

        public ApplicationUser AddNewUser(string? email, string? phoneNumber, string password)
        {
            ApplicationUser user = CreateNewUser(email, phoneNumber, password);
            dbContext.ApplicationUsers.Add(user);
            dbContext.SaveChanges();
            return user;
        }

        public ApplicationUser CreateNewUser(string? email, string? phoneNumber, string password)
        {
            if (email == null && phoneNumber == null)
                throw new ArgumentNullException("email && phoneNumber");

            if (dbContext.ApplicationUsers.Where(user => user.Email == email || user.PhoneNumber == phoneNumber).Any())
                throw new InvalidLoginException("Email or phone number already exists!");

            return new ApplicationUser()
            {
                Email = email,
                PhoneNumber = phoneNumber,
                Password = passwordHasher.Hash(password)
            };
        }

        public ApplicationUser ChangePasswordForUser(ApplicationUser user, string newPassword)
        {
            if (passwordHasher.Verify(newPassword, user.Password))
                throw new InvalidPasswordException("Password cannot be identical to the previous one");

            user = dbContext.ApplicationUsers.Attach(user);
            user.Password = passwordHasher.Hash(newPassword);
            dbContext.SaveChanges();
            return user;
        }

        public ApplicationUser ChangePasswordForUser(string emailOrPhone, string newPassword)
        {
            var (userPredicate, personPredicate) = GetPredicates(emailOrPhone);
            ApplicationUser user = FindUser(emailOrPhone, userPredicate);
            return ChangePasswordForUser(user, newPassword);
        }

        public ApplicationUser ChangeUserData(ApplicationUser user, string? newEmail, string? newPhoneNumber)
        {
            user = dbContext.ApplicationUsers.Attach(user);
            if (newEmail != null)
                user.Email = newEmail;
            if (newPhoneNumber != null)
                user.PhoneNumber = newPhoneNumber;

            dbContext.SaveChanges();
            return user;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="emailOrPhone"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">when given string is not a valid email address or phone number</exception>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="emailOrPhone"></param>
        /// <param name="userPredicate"></param>
        /// <returns></returns>
        private ApplicationUser FindUser(string emailOrPhone, Func<ApplicationUser, bool> userPredicate)
        {
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
