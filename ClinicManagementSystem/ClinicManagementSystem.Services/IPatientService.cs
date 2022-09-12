using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Services
{
    public interface IPatientService: IBaseService
    {
        IEnumerable<Patient> GetPatients();
        Patient GetPatientByID(int patientId);
        Patient GetPatientByPersonalIdentityNumber(string personalIdentityNumber);
        IEnumerable<Patient> GetPatientsByName(string firstName, string lastName);
        Patient GetPatientByName(string firstName, string lastName);
        void InsertPatient(Patient patient);
        void DeletePatient(int patientId);
        void UpdatePatient(Patient patient);
    }
}
