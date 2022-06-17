using ClinicManagementSystem.Entities;
using ClinicManagementSystem.Entities.Enums;
using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace ClinicManagementSystem.Services.impl
{
    public class AppointmentService : BaseService, IAppointmentService
    {
        public Appointment CurrentAppointment { get; set; }

        public AppointmentService(ISystemContext context) : base(context)
        {
            
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
            return context.Appointments.ToList().Where(a => a.Patient == patient && a.AppointmentStatus == Entities.Enums.AppointmentStatus.Accepted);
        }

        public IEnumerable<Appointment> GetAppointmentsForPatient(Patient patient)
        {
            return context.Appointments.ToList().Where(a => a.Patient == patient);
        }

        public IEnumerable<Appointment> GetAppointmentsByCompletionDate(DateTime completionDate)
        {
            return context.Appointments.Where(a => a.CompletionDate == completionDate);
        }

        public IEnumerable<Appointment> GetAppointments()
        {
            return context.Appointments.Include(a => a.Patient).Include(a => a.Doctor);
        }

        public Appointment GetAppointmentByID(int appointmentId)
        {
            return context.Appointments.Find(appointmentId);
        }

        public Appointment GetAppointmentForPatientByCompletionDate(Patient patient, DateTime completionDate)
        {
            return context.Appointments.Where(a => a.Patient == patient).Where(a => a.CompletionDate == completionDate).FirstOrDefault();
        }

        public IEnumerable<Appointment> GetAppointmentsByStatus(AppointmentStatus status)
        {
            return context.Appointments.Where(a => a.AppointmentStatus == status).ToList();
        }

        public IEnumerable<Appointment> GetAppointmentsByPatientAndStatus(Patient patient, AppointmentStatus status)
        {
            return context.Appointments.ToList().Where(a => a.Patient == patient && a.AppointmentStatus == status);
        }
        public DateTime? GetLastAppointmentDateForPatient(Patient patient)
        {
            Appointment a = context.Appointments.ToList().Where(a => a.Patient == patient).OrderByDescending(a => a.CompletionDate).FirstOrDefault(); // todo completion date or other date here?
            if (a != null)
                return a.CompletionDate;
            return null;
        }

        public void InsertAppointment(Appointment appointment)
        {
            context.Appointments.Add(appointment);
            Save();
        }

        public void UpdateAppointment(Appointment appointment)
        {
            context.Entry(appointment).State = EntityState.Modified;
            Save();
        }
    }
}
