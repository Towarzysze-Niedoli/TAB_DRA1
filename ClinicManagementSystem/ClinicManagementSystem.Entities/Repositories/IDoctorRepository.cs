using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Entities.Repositories
{
    internal interface IDoctorRepository : IDisposable
    {
        IEnumerable<Doctor> GetDoctors();
        Doctor GetDoctortByID(int doctorId);
        void InsertDoctor(Doctor doctor);
        void DeleteDoctor(int doctorId);
        void UpdateDoctor(Doctor doctor);
        void Save();
    }
}
