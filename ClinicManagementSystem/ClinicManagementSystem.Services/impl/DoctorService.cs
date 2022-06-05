using ClinicManagementSystem.Entities;
using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using System.Linq;

namespace ClinicManagementSystem.Services.impl
{
    public class DoctorService : IDoctorService, IDisposable
    {
        private ISystemContext context;

        public DoctorService(ISystemContext context)
        {
            this.context = context;
        }

        public void DeleteDoctor(int doctorId)
        {
            Doctor doctor = context.Doctors.Find(doctorId);
            context.Doctors.Remove(doctor);
        }

        public IEnumerable<Doctor> GetDoctors()
        {
            return context.Doctors;
        }

        public Doctor GetDoctorByID(int doctorId)
        {
            return context.Doctors.Find(doctorId);
        }

        public void InsertDoctor(Doctor doctor)
        {
            context.Doctors.Add(doctor);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateDoctor(Doctor doctor)
        {
            context.Entry(doctor).State = System.Data.Entity.EntityState.Modified;
        }

        public Doctor GetDoctorByName(string firstName, string lastName)
        {
            List<Doctor> doctors = context.Doctors.Include(d => d.Address).Where(d => d.FirstName.Equals(firstName) && d.LastName.Equals(lastName)).ToList();
            return doctors.Count() != 0 ? doctors.First() : null;
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
