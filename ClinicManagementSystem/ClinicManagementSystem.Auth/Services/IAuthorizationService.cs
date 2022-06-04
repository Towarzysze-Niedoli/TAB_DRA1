using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Auth.Services
{
    public interface IAuthorizationService
    {
        /// <summary>
        /// Checks if user is a person of given class.
        /// </summary>
        /// <typeparam name="T">class derived from Person</typeparam>
        /// <param name="user"></param>
        /// <param name="personPredicate">leave null</param>
        /// <returns>object of given class, if user is a person of given class, null otherwise</returns>
        /// <exception cref="ArgumentException">when user's login (email or phone number) is not a valid email address or phone number</exception>
        /// <exception cref="ArgumentNullException">when user does not have email address nor phone number</exception>
        public T? IsType<T>(ApplicationUser user, Func<Person, bool>? personPredicate = null) where T : Person;

        /// <summary>
        /// Adds a new person and their account.
        /// </summary>
        /// <typeparam name="T">class derived from Person</typeparam>
        /// <param name="person"></param>
        /// <param name="password"></param>
        /// <returns>created person</returns>
        /// <exception cref="ArgumentNullException">when user does not have email address nor phone number, or one of the parameters is null</exception>
        public T AddPerson<T>(T person, string password) where T : Person;

        /// <summary>
        /// Searches a Person instance for given user.
        /// </summary>
        /// <param name="user"></param>
        /// <returns>person corresponding to user, null if not found</returns>
        /// <exception cref="ArgumentException">when user's login (email or phone number) is not a valid email address or phone number</exception>
        /// <exception cref="ArgumentNullException">when user does not have email address nor phone number</exception>
        public Person? UserToPerson(ApplicationUser user);

        /// <summary>
        /// Updates person data and their account.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="person">must include person id</param>
        /// <param name="password">null if no change</param>
        /// <returns></returns>
        public T UpdatePerson<T>(T person, string? password = null) where T : Person;
    }
}
