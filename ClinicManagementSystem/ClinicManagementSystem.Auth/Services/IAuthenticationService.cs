using ClinicManagementSystem.Entities.Models;
using ClinicManagementSystem.Auth.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Auth.Services
{
    public interface IAuthenticationService
    {
        /// <summary>
        /// Verifies user's login and password.
        /// </summary>
        /// <param name="emailOrPhone">login aka email address or phone number</param>
        /// <param name="password">user's password</param>
        /// <returns>authenticated user</returns>
        /// <exception cref="ArgumentException">when given login is not a valid email address or phone number</exception>
        /// <exception cref="InvalidLoginException">when given login does not exists in database</exception>
        /// <exception cref="InvalidPasswordException">when password for user is invalid</exception>
        public ApplicationUser Authenticate(string emailOrPhone, string password);

        /// <summary>
        /// Creates new user and adds it to database.
        /// For adding a new user, please use <see cref="AuthorizationService.AddPerson{T}(T, string)"/>
        /// </summary>
        /// <param name="email"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="password"></param>
        /// <returns>added user</returns>
        public ApplicationUser AddNewUser(string? email, string? phoneNumber, string password);

        /// <summary>
        /// Only creates a new user and returns it, DOES NOT ADD IT TO THE DATABASE!
        /// For adding a new user, please use <see cref="AuthorizationService.AddPerson{T}(T, string)"/>
        /// </summary>
        /// <param name="email"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="password"></param>
        /// <returns>created user</returns>
        /// <exception cref="InvalidLoginException">when given login does not exists in database</exception>
        public ApplicationUser CreateNewUser(string? email, string? phoneNumber, string password);

        /// <summary>
        /// Changes password for given user.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="newPassword"></param>
        /// <returns>user with changed password</returns>
        /// <exception cref="InvalidPasswordException">when password is identical to previous one</exception>
        public ApplicationUser ChangePasswordForUser(ApplicationUser user, string newPassword);

        /// <summary>
        /// Changes password for given user.
        /// </summary>
        /// <param name="emailOrPhone"></param>
        /// <param name="newPassword"></param>
        /// <returns>user with changed password</returns>
        /// <exception cref="InvalidPasswordException">when password is identical to previous one</exception>
        /// <exception cref="ArgumentException">when given login is not a valid email address or phone number</exception>
        /// <exception cref="InvalidLoginException">when given login does not exist in the database</exception>
        public ApplicationUser ChangePasswordForUser(string emailOrPhone, string newPassword);

        /// <summary>
        /// Changes user's email address and/or phone number. 
        /// </summary>
        /// <param name="user"></param>
        /// <param name="newEmail"></param>
        /// <param name="newPhoneNumber"></param>
        /// <returns>user with changed data</returns>
        public ApplicationUser ChangeUserData(ApplicationUser user, string? newEmail, string? newPhoneNumber);

        /// <summary>
        /// Changes user's email address and/or phone number. 
        /// </summary>
        /// <param name="emailOrPhone"></param>
        /// <param name="newEmail"></param>
        /// <param name="newPhoneNumber"></param>
        /// <returns>user with changed data</returns>
        public ApplicationUser ChangeUserData(string emailOrPhone, string? newEmail, string? newPhoneNumber);
    }
}
