﻿using ClinicManagementSystem.Entities;
using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using System.Linq;
using ClinicManagementSystem.Auth.Services;

namespace ClinicManagementSystem.Services.impl
{
    public class DoctorService : BaseService, IDoctorService
    {
        private readonly IAuthorizationService authorizationService;

        public DoctorService(IAuthorizationService service, ISystemContext context) : base(context)
        {
            authorizationService = service;
        }

        public IEnumerable<Doctor> GetDoctors()
        {
            return context.Doctors;
        }

        public Doctor GetDoctorByID(int doctorId)
        {
            return context.Doctors.Find(doctorId);
        }
        public Doctor InsertDoctor(Doctor doctor, string password)
        {
            return authorizationService.AddPerson(doctor, password);
        }

        public void UpdateDoctor(Doctor doctor, string password)
        {
            authorizationService.UpdatePerson(doctor, password);
        }

        public void DisableDoctorAccount(int doctorId)
        {
            authorizationService.DisablePersonAccount<Doctor>(doctorId);
        }

        public void EnableDoctorAccount(int doctorId)
        {
            authorizationService.EnablePersonAccount<Doctor>(doctorId);
        }

        public Doctor GetDoctorByName(string firstName, string lastName)
        {
            List<Doctor> doctors = context.Doctors.Include(d => d.Address).Where(d => d.FirstName.Equals(firstName) && d.LastName.Equals(lastName)).ToList();
            return doctors.Count() != 0 ? doctors.First() : null;
        }
    }
}