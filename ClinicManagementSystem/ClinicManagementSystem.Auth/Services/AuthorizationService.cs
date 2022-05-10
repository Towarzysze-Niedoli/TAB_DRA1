using ClinicManagementSystem.Entities;
using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace ClinicManagementSystem.Auth.Services
{
    public class AuthorizationService : IAuthorizationService
    {
        private readonly IAuthenticationService authenticationService;
        private readonly SystemContext dbContext;

        public AuthorizationService(IAuthenticationService _authenticationService, SystemContext systemContext)
        {
            authenticationService = _authenticationService;
            dbContext = systemContext;
        }

        public T? IsType<T>(ApplicationUser user, Func<Person, bool>? personPredicate = null) where T : Person
        {
            if (personPredicate == null)
                personPredicate = GetPersonPredicate(user.Email ?? user.PhoneNumber ?? throw new ArgumentNullException("email && phoneNumber"));

            IEnumerable<T> queryResult = dbContext.Set<T>().Where<T>(personPredicate);
            if (queryResult.Count() == 1)
                return queryResult.Single();
            return null;
        }

        public T AddPerson<T>(T person, string password) where T : Person
        {
            if (person == null)
                throw new ArgumentNullException("person");
            if (person.Email == null && person.PhoneNumber == null)
                throw new ArgumentNullException("email && phoneNumber");
            if (password == null)
                throw new ArgumentNullException("password");

            using (SystemContext dbContext = new SystemContext())
            {
                ApplicationUser createdUser = authenticationService.CreateNewUser(person.Email, person.PhoneNumber, password);

                // link address if exists (EF creates a new entry by default)
                if (person.Address != null)
                {
                    var addresses = dbContext.Addresses.Where(a => a.Street == person.Address.Street
                                                        && a.HomeNumber == person.Address.HomeNumber
                                                        && a.ZipCode == person.Address.ZipCode
                                                        && a.City == person.Address.City);
                    if (addresses.Count() == 1)
                        person.Address = addresses.Single();
                }
                
                DbContextTransaction transaction = dbContext.Database.BeginTransaction();
                dbContext.ApplicationUsers.Add(createdUser);
                T addedPerson = dbContext.Set<T>().Add(person);
                dbContext.SaveChanges();
                transaction.Commit();
                return addedPerson;
            }
        }

        public Person? UserToPerson(ApplicationUser user)
        {
            var personPredicate = GetPersonPredicate(user.Email ?? user.PhoneNumber ?? throw new ArgumentNullException("email && phoneNumber"));

            Person? person = IsType<Admin>(user, personPredicate);
            if (person != null)
                return person;
            person = IsType<Doctor>(user, personPredicate);
            if (person != null)
                return person;
            person = IsType<LaboratoryManager>(user, personPredicate);
            if (person != null)
                return person;
            person = IsType<LaboratoryTechnician>(user, personPredicate);
            if (person != null)
                return person;
            person = IsType<Receptionist>(user, personPredicate);
            if (person != null)
                return person;
            return null;
        }


        private Func<Person, bool> GetPersonPredicate(string emailOrPhone)
        {
            if (new EmailAddressAttribute().IsValid(emailOrPhone))
            {
                return person => person.Email != null && person.Email.Equals(emailOrPhone);
            }
            else if (new PhoneAttribute().IsValid(emailOrPhone))
            {
                return person => person.PhoneNumber != null && person.PhoneNumber.Equals(emailOrPhone);
            }
            else
            {
                throw new ArgumentException($"{emailOrPhone} is not a valid email address or phone number", nameof(emailOrPhone));
            }
        }
    }
}
