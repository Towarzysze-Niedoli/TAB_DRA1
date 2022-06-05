﻿using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Services
{
    public interface IDoctorService : IDisposable
    {
        IEnumerable<Doctor> GetDoctors();
        Doctor GetDoctorByID(int doctorId);
        void InsertDoctor(Doctor doctor);
        void DeleteDoctor(int doctorId);
        void UpdateDoctor(Doctor doctor);
        Doctor GetDoctorByName(string firstName, string lastName);
        void Save();
    }
}
