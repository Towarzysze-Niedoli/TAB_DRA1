using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Repositories.Repositories
{
    internal interface IDoctorRepository : IDisposable
    {
        IEnumerable<Doctor> GetDoctors();
        Doctor GetDoctorByID(int doctorId);
        void InsertDoctor(Doctor doctor);
        void DeleteDoctor(int doctorId);
        void UpdateDoctor(Doctor doctor);
        void Save();
    }
}
