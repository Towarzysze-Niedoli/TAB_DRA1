using ClinicManagementSystem.Entities;
using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Repositories.Repositories.impl
{
    public class PatientRepository : IPatientRepository, IDisposable
    {
        private SystemContext context;

        public PatientRepository(SystemContext context)
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
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdatePatient(Patient patient)
        {
            context.Entry(patient).State = System.Data.Entity.EntityState.Modified;
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
