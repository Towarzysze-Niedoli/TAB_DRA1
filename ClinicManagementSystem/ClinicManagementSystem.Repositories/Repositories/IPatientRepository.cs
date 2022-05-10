using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Repositories.Repositories
{
    internal interface IPatientRepository
    {
        IEnumerable<Patient> GetPatients();
        Patient GetPatientByID(int patientId);
        Patient GetPatientByPersonalIdentityNumber(string personalIdentityNumber);
        void InsertPatient(Patient patient);
        void DeletePatient(int patientId);
        void UpdatePatient(Patient patient);
        void Save();
    }
}
