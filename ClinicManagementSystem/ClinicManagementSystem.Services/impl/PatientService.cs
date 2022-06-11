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
            context.Entry(patient).State = System.Data.Entity.EntityState.Modified;
        }

        public Patient GetPatientByPersonalIdentityNumber(string personalIdentityNumber)
        {
            List<Patient> patients = context.Patients.Where(p => p.PersonalIdentityNumber.Equals(personalIdentityNumber)).ToList();
            return patients.Count() != 0 ? patients.First() : null;

        }

        public Patient GetPatientByName(string firstName, string lastName)
        {
            List<Patient> patients = context.Patients.Include(p => p.Address).Where(p => p.FirstName.Equals(firstName) && p.LastName.Equals(lastName)).ToList();
            return patients.Count() != 0 ? patients.First() : null;
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
