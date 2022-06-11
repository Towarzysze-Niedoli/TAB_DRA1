using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Services
{
    public interface IDoctorService : IBaseService
    {
        IEnumerable<Doctor> GetDoctors();
        Doctor GetDoctorByID(int doctorId);
        Doctor InsertDoctor(Doctor doctor, string password);
        void UpdateDoctor(Doctor doctor, string password = null);
        void DisableDoctorAccount(int doctorId);
        void EnableDoctorAccount(int doctorId);
        Doctor GetDoctorByName(string firstName, string lastName);
        Doctor GetDoctorByLicenceNumber(string licenceNumber);
    }
}
