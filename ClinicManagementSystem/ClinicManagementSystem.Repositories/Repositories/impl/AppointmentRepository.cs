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
            Appointment appointment = context.Appointments.Find(appointmentId);
            context.Appointments.Remove(appointment);
        }

        public IEnumerable<Appointment> GetAppointmentsForDoctor(Doctor doctor)
        {
            return context.Appointments.Where(a => a.Doctor == doctor);
        }

        public IEnumerable<Appointment> GetAcceptedAppointmentsForPatient(Patient patient)
        {
            return context.Appointments.Where(a => a.Patient == patient).Where(a => a.AppointmentStatus == Entities.Enums.AppointmentStatus.Accepted);
        }

        public IEnumerable<Appointment> GetAppointmentsByCompletionDate(DateTime date)
        {
            return context.Appointments.Where(a => a.CompletionDate == date);
        }

        public IEnumerable<Appointment> GetAppointments()
        {
            return context.Appointments;
        }

        public Appointment GetAppointmenttByID(int appointmentId)
        {
            return context.Appointments.Find(appointmentId);
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
            context.Entry(appointment).State = System.Data.Entity.EntityState.Modified;
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
