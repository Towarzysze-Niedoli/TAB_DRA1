using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Entities.Repositories.impl
{
    public class DoctorRepository : IDoctorRepository, IDisposable
    {
        private SystemContext context;

        public DoctorRepository(SystemContext context)
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

        public Doctor GetDoctortByID(int doctorId)
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
