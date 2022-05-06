using ClinicManagementSystem.Entities;
using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicManagementSystem.Repositories.Repositories.impl
{
    public class AppointmentRepository : IAppointmentRepository, IDisposable
    {
        private SystemContext context;

        public AppointmentRepository(SystemContext context)
        {
            this.context = context;
        }

        public void DeleteAppointment(int appointmentId)
        {
            throw new NotImplementedException();
        }

       
        public IEnumerable<Appointment> GetAppointmentsForDoctor(Doctor doctor)
        {
            return context.Appointments.Where(a => a.Doctor == doctor);
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
            context.Appointments.Add(appointment);
        }

        public void Save()
        {
            context.SaveChanges();
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
