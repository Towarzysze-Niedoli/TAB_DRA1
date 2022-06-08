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
        private readonly ISystemContext dbContext;
        private PersonWithAccount? currentlyLoggedPerson;

        public AuthorizationService(IAuthenticationService _authenticationService, ISystemContext systemContext)
        {
            authenticationService = _authenticationService;
            dbContext = systemContext;
        }

        public T? IsType<T>(ApplicationUser user, Func<PersonWithAccount, bool>? personPredicate = null) where T : PersonWithAccount
        {
            if (personPredicate == null)
                personPredicate = GetPersonPredicate(user.Email ?? user.PhoneNumber ?? throw new ArgumentNullException("email && phoneNumber"));

            IEnumerable<T> queryResult = dbContext.Set<T>().Where<T>(personPredicate);
            if (queryResult.Count() == 1)
                return queryResult.Single();
            return null;
        }

        public T AddPerson<T>(T person, string password) where T : PersonWithAccount
        {
            if (person == null)
                throw new ArgumentNullException("person");
            if (person.Email == null && person.PhoneNumber == null)
                throw new ArgumentNullException("email && phoneNumber");
            if (password == null)
                throw new ArgumentNullException("password");

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

        public T UpdatePerson<T>(T person, string? password) where T : PersonWithAccount
        {
            if (person == null)
                throw new ArgumentNullException("person");

            T oldPerson = dbContext.Set<T>().Find(person.Id);

            DbContextTransaction transaction = dbContext.Database.BeginTransaction();

            if (person.Email != oldPerson.Email || person.PhoneNumber != oldPerson.PhoneNumber)
                authenticationService.ChangeUserData(oldPerson.Email ?? oldPerson.PhoneNumber ?? "shouldNotHappen", person.Email, person.PhoneNumber);
            if (password != null)
                authenticationService.ChangePasswordForUser(oldPerson.Email ?? oldPerson.PhoneNumber ?? "shouldNotHappen", password);

            // link address if changed and exists (EF creates a new entry by default)
            if (person.Address == null)
                oldPerson.Address = null;
            else if (person.Address != oldPerson.Address)
            {
                var addresses = dbContext.Addresses.Where(a => a.Street == person.Address.Street
                                                    && a.HomeNumber == person.Address.HomeNumber
                                                    && a.ZipCode == person.Address.ZipCode
                                                    && a.City == person.Address.City);
                if (addresses.Count() == 1)
                    person.Address = addresses.Single();
            }
            dbContext.Entry(oldPerson).CurrentValues.SetValues(person);

            dbContext.SaveChanges();
            transaction.Commit();
            return person;
        }

        public ApplicationUser DisablePersonAccount<T>(int id) where T : PersonWithAccount
        {
            return SetAccountDisabled<T>(id, true);
        }

        public ApplicationUser EnablePersonAccount<T>(int id) where T : PersonWithAccount
        {
            return SetAccountDisabled<T>(id, false);
        }

        private ApplicationUser SetAccountDisabled<T>(int personId, bool disabled) where T : PersonWithAccount
        {
            T person = dbContext.Set<T>().Find(personId);
            if (person.Email != null)
                return disabled ? authenticationService.DisableAccountWithEmail(person.Email) : authenticationService.EnableAccountWithEmail(person.Email);
            else if (person.PhoneNumber != null)
                return disabled ? authenticationService.DisableAccountWithPhoneNumber(person.PhoneNumber) : authenticationService.EnableAccountWithPhoneNumber(person.PhoneNumber);
            else
                throw new InvalidOperationException("person.Email == null && person.PhoneNumber == null");

        }

        public PersonWithAccount? UserLogin(ApplicationUser user)
        {
            currentlyLoggedPerson = UserToPerson(user);
            return currentlyLoggedPerson;
        }

        public void UserLogout()
        {
            authenticationService.UserLogout();
            currentlyLoggedPerson = null;
        }

        public PersonWithAccount? UserToPerson(ApplicationUser user)
        {
            var personPredicate = GetPersonPredicate(user.Email ?? user.PhoneNumber ?? throw new ArgumentNullException("email && phoneNumber"));

            PersonWithAccount? person = IsType<Admin>(user, personPredicate);
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


        private Func<PersonWithAccount, bool> GetPersonPredicate(string emailOrPhone)
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
