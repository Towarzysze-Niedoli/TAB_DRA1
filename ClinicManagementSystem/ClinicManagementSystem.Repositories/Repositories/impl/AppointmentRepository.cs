using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Repositories.Repositories.impl
{
    public class AppointmentRepository : IAppointmentRepository, IDisposable
    {
        public void DeleteAppointment(int appointmentId)
        {
            throw new NotImplementedException();
        }

       
        public void GetAppointmentForDoctor(Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Appointment> GetAppointments()
        {
            throw new NotImplementedException();
        }

        public Appointment GetAppointmenttByID(int appointmentId)
        {
            throw new NotImplementedException();
        }

        public void InsertAppointment(Appointment appointment)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void UpdateAppointment(Appointment appointment)
        {
            throw new NotImplementedException();
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
