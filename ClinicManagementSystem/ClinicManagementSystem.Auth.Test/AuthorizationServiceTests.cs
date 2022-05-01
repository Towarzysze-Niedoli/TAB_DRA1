﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    public class AuthorizationServiceTests
    {
        readonly AuthorizationService authorizationService = new AuthorizationService();

        const int n = 5;
        readonly static string[] firstnames = new string[n] { "Jan", "Jan", "Anna Maria", "Zażółćgęśląjaźń", "Jan" };
        readonly static string[] lastnames = new string[n] { "Kowalski", "Nowak", "Kowalska-Nowak", "Zażółćgęśląjaźń", "Nowak" };
        readonly static string[] emails = new string[n] { "email@email.com", "second@different.pl", "another@some.com.pl", null, null };
        readonly static string[] phones = new string[n] { "123456789", "322427042", null, "+48258147369", null };
        readonly static string[] passwords = new string[n] { "TAB_DRA1", "qwerty 123", "G33DqSg@fgmU9CJK", "#6j@&@7gQWEzck8V", "T3*w8$ijtPA$Uzz2" };
        readonly static Address[] addresses = new Address[n] { 
            new Address()
            {
                City = "Gliwice",
                Street = "Akademicka",
                HomeNumber = "16",
                ZipCode = "44-100"
            },
            new Address()
            {
                City = "Ruda Śląska",
                Street = "Solidarności",
                HomeNumber = "1/10",
                ZipCode = "41-706"
            },
            null, 
            null, 
            null 
        };

        static readonly Admin[] admins = new Admin[n];
        static readonly Doctor[] doctors = new Doctor[n];
        static readonly LaboratoryManager[] laboratoryManagers = new LaboratoryManager[n];
        static readonly LaboratoryTechnician[] laboratoryTechnicians = new LaboratoryTechnician[n];
        static readonly Receptionist[] receptionists = new Receptionist[n];

        [ClassInitialize]
        public static void InitializeClass(TestContext testContext)
        {
            for (int i = 0; i < n; i++)
            {
                admins[i] = new Admin()
                {
                    FirstName = firstnames[i],
                    LastName = lastnames[i],
                    Email = emails[i],
                    PhoneNumber = phones[i]
                };
                doctors[i] = new Doctor()
                {
                    FirstName = firstnames[i],
                    LastName = lastnames[i],
                    Email = emails[i],
                    PhoneNumber = phones[i],
                    Address = addresses[i],
                    LicenseNumber = 1234567
                };
                laboratoryManagers[i] = new LaboratoryManager()
                {
                    FirstName = firstnames[i],
                    LastName = lastnames[i],
                    Email = emails[i],
                    PhoneNumber = phones[i],
                    Address = addresses[i]
                };
                laboratoryTechnicians[i] = new LaboratoryTechnician()
                {
                    FirstName = firstnames[i],
                    LastName = lastnames[i],
                    Email = emails[i],
                    PhoneNumber = phones[i],
                    Address = addresses[i],
                };
                receptionists[i] = new Receptionist()
                {
                    FirstName = firstnames[i],
                    LastName = lastnames[i],
                    Email = emails[i],
                    PhoneNumber = phones[i],
                    Address = addresses[i],
                };
            }
        }

        private static int RemoveEntries()
        {
            using SystemContext dbContext = new SystemContext();
            // remove necessary existing entries:
            dbContext.ApplicationUsers.RemoveRange(
                dbContext.ApplicationUsers.Where(user => emails.Contains(user.Email) || phones.Contains(user.PhoneNumber))
            );
            dbContext.SystemAdministrators.RemoveRange(
                dbContext.SystemAdministrators.Where(user => emails.Contains(user.Email) || phones.Contains(user.PhoneNumber))
            );
            dbContext.Doctors.RemoveRange(
                dbContext.Doctors.Where(user => emails.Contains(user.Email) || phones.Contains(user.PhoneNumber))
            );
            dbContext.LaboratoryManagers.RemoveRange(
                dbContext.LaboratoryManagers.Where(user => emails.Contains(user.Email) || phones.Contains(user.PhoneNumber))
            );
            dbContext.LaboratoryTechnicians.RemoveRange(
                dbContext.LaboratoryTechnicians.Where(user => emails.Contains(user.Email) || phones.Contains(user.PhoneNumber))
            );
            dbContext.Receptionists.RemoveRange(
                dbContext.Receptionists.Where(user => emails.Contains(user.Email) || phones.Contains(user.PhoneNumber))
            );
            return dbContext.SaveChanges();
        }


        public void AddUserTestHelper<T>(T[] people) where T : Person, new()
        {
            if (people.Length != n)
                throw new ArgumentException("people.Length != n");

            using SystemContext dbContext = new SystemContext();
            RemoveEntries();
            for (int i = 0; i < n; i++)
            {
                if (people[i].Email == null && people[i].PhoneNumber == null)
                    Assert.ThrowsException<ArgumentNullException>(() => authorizationService.AddPerson<T>(people[i], passwords[i]));
                else
                {
                    T addedPerson = authorizationService.AddPerson<T>(people[i], passwords[i]);
                    T foundPerson = dbContext.Set<T>().Find(addedPerson.Id);
                    Assert.AreEqual(firstnames[i], foundPerson.FirstName);
                    Assert.AreEqual(lastnames[i], foundPerson.LastName);
                    Assert.AreEqual(emails[i], foundPerson.Email);
                    Assert.AreEqual(phones[i], foundPerson.PhoneNumber);
                    // double insertion:
                    Assert.ThrowsException<InvalidLoginException>(() => authorizationService.AddPerson<T>(people[i], passwords[i]));
                }
            }
        }

        [TestMethod]
        public void AddAdminTest()
        {
            AddUserTestHelper<Admin>(admins);
        }

        [TestMethod]
        public void AddDoctorTest()
        {
            AddUserTestHelper<Doctor>(doctors);
        }

        [TestMethod]
        public void AddLabManagerTest()
        {
            AddUserTestHelper<LaboratoryManager>(laboratoryManagers);
        }

        [TestMethod]
        public void AddLabTechnicianTest()
        {
            AddUserTestHelper<LaboratoryTechnician>(laboratoryTechnicians);
        }

        [TestMethod]
        public void AddReceptionistTest()
        {
            AddUserTestHelper<Receptionist>(receptionists);
        }


        public void IsPersonTestHelper<T>(T[] people) where T : Person, new()
        {
            if (people.Length != n)
                throw new ArgumentException("people.Length != n");

            using SystemContext dbContext = new SystemContext();
            RemoveEntries();
            for (int i = 0; i < n; i++)
            {
                if (people[i].Email != null || people[i].PhoneNumber != null)
                {
                    T addedPerson = authorizationService.AddPerson<T>(people[i], passwords[i]);

                    ApplicationUser user = new ApplicationUser()
                    {
                        Email = people[i].Email,
                        PhoneNumber = people[i].PhoneNumber,
                        Password = passwords[i]
                    };
                    Assert.IsNotNull(authorizationService.IsType<T>(user));
                    if (typeof(T) != typeof(Admin))
                        Assert.IsNull(authorizationService.IsType<Admin>(user));
                    else
                        Assert.IsNull(authorizationService.IsType<Doctor>(user));
                }
            }
        }

        [TestMethod]
        public void IsAdminTest()
        {
            IsPersonTestHelper<Admin>(admins);
        }

        [TestMethod]
        public void IsDoctorTest()
        {
            IsPersonTestHelper<Doctor>(doctors);
        }

        [TestMethod]
        public void IsLabManagerTest()
        {
            IsPersonTestHelper<LaboratoryManager>(laboratoryManagers);
        }

        [TestMethod]
        public void IsLabTechnicianTest()
        {
            IsPersonTestHelper<LaboratoryTechnician>(laboratoryTechnicians);
        }

        [TestMethod]
        public void IsReceptionistTest()
        {
            IsPersonTestHelper<Receptionist>(receptionists);
        }


        private void UserToPersonTestHelper<T>(T[] people) where T : Person, new()
        {
            using SystemContext dbContext = new SystemContext();
            RemoveEntries();
            for (int i = 0; i < n; i++)
            {
                if (people[i].Email != null || people[i].PhoneNumber != null)
                {
                    _ = authorizationService.AddPerson<T>(people[i], passwords[i]);
                    ApplicationUser user = new ApplicationUser()
                    {
                        Email = people[i].Email,
                        PhoneNumber = people[i].PhoneNumber,
                        Password = passwords[i]
                    };
                    Person person = authorizationService.UserToPerson(user);
                    Assert.IsNotNull(person);
                    Assert.AreEqual(people[i].FirstName, person.FirstName);
                    Assert.AreEqual(people[i].LastName, person.LastName);
                    Assert.AreEqual(people[i].Email, person.Email);
                    Assert.AreEqual(people[i].PhoneNumber, person.PhoneNumber);
                    if (typeof(T) == typeof(Doctor))
                    {
                        Doctor doc = person as Doctor;
                        Assert.AreEqual(1234567, doc.LicenseNumber);
                    }
                }
            }
        }

        [TestMethod]
        public void UserToAdminTest()
        {
            UserToPersonTestHelper<Admin>(admins);
        }

        [TestMethod]
        public void UserToDoctorTest()
        {
            UserToPersonTestHelper<Doctor>(doctors);
        }

        [TestMethod]
        public void UserToLabManagerTest()
        {
            UserToPersonTestHelper<LaboratoryManager>(laboratoryManagers);
        }

        [TestMethod]
        public void UserToLabTechnicianTest()
        {
            UserToPersonTestHelper<LaboratoryTechnician>(laboratoryTechnicians);
        }

        [TestMethod]
        public void UserToReceptionistTest()
        {
            IsPersonTestHelper<Receptionist>(receptionists);
        }
    }
}
