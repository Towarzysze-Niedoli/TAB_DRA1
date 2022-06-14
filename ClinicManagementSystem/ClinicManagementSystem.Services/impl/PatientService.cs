using ClinicManagementSystem.Entities;
using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;

namespace ClinicManagementSystem.Services.impl
{
    public class PatientService : IPatientService, IDisposable
    {
        private ISystemContext context;

        public PatientService(ISystemContext context)
        {
            this.context = context;
        }

        public void DeletePatient(int patientId)
        {
            Patient patient = context.Patients.Find(patientId);
            context.Patients.Remove(patient);
        }

        public IEnumerable<Patient> GetPatients()
        {
            return context.Patients;
        }

        public Patient GetPatientByID(int patientId)
        {
            return context.Patients.Find(patientId);
        }

        public void InsertPatient(Patient patient)
        {
            context.Patients.Add(patient);
            Save();
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdatePatient(Patient patient)
        {
            context.Patients.Attach(patient);
            context.Entry(patient).State = System.Data.Entity.EntityState.Modified;
            Save();
        }

        public Patient GetPatientByPersonalIdentityNumber(string personalIdentityNumber)
        {
            return string.IsNullOrWhiteSpace(personalIdentityNumber) ? null : context.Patients.Where(p => p.PersonalIdentityNumber.Equals(personalIdentityNumber)).FirstOrDefault();
        }

        public Patient GetPatientByName(string firstName, string lastName)
        {
            return context.Patients.Include(p => p.Address).Where(p => p.FirstName.ToLower().Equals(firstName.ToLower()) && p.LastName.ToLower().Equals(lastName.ToLower())).FirstOrDefault();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        
    }
}
