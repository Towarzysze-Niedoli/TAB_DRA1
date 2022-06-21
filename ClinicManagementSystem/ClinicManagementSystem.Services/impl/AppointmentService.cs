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
            Save();
        }

        public IEnumerable<Appointment> GetAppointmentsForDoctor(Doctor doctor)
        {
            return GetAppointments().Where(a => a.Doctor == doctor);
        }

        public IEnumerable<Appointment> GetAcceptedAppointmentsForPatient(Patient patient)
        {
            return GetAppointments().ToList().Where(a => a.Patient == patient && a.AppointmentStatus == Entities.Enums.AppointmentStatus.Accepted);
        }

        public IEnumerable<Appointment> GetAppointmentsForPatient(Patient patient)
        {
            return GetAppointments().ToList().Where(a => a.Patient == patient);
        }

        public IEnumerable<Appointment> GetAppointmentsByCompletionDate(DateTime completionDate)
        {
            return GetAppointments().Where(a => a.CompletionDate == completionDate);
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
            return GetAppointments().Where(a => a.Patient == patient).Where(a => a.CompletionDate == completionDate).FirstOrDefault();
        }

        public IEnumerable<Appointment> GetAppointmentsByStatus(AppointmentStatus status)
        {
            return GetAppointments().Where(a => a.AppointmentStatus == status).ToList();
        }

        public IEnumerable<Appointment> GetAppointmentsByPatientAndStatus(Patient patient, AppointmentStatus status)
        {
            return GetAppointments().ToList().Where(a => a.Patient == patient && a.AppointmentStatus == status);
        }
        public DateTime? GetLastAppointmentDateForPatient(Patient patient)
        {
            Appointment a = GetAppointments().ToList().Where(a => a.Patient == patient).OrderByDescending(a => a.ScheduledDate).FirstOrDefault();
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

        public IEnumerable<Appointment> GetAppointmentsByStatusAndDoctor(AppointmentStatus status, Doctor doctor)
        {
            return GetAppointments().Where(a => a.AppointmentStatus == status && a.Doctor == doctor);
        }

        public IEnumerable<Appointment> GetAppointmentsByScheduledDate(DateTime date)
        {
            return context.Appointments.ToList().Where(a => a.ScheduledDate.Date.Equals(date));
        }

        public IEnumerable<Appointment> GetAppointments(AppointmentStatus? status, Doctor doctor, Patient patient)
        {
            // PR: takie skladanie where pozornie wyglada na malo wydajne, ale dla EF/LINQ wydaje sie nie miec znaczenia, a mamy jedna krotka funkcje na wszystko
            IEnumerable<Appointment> appointments = GetAppointments();

            if (status != null)
                appointments = appointments.Where(a => a.AppointmentStatus == status);
            if (doctor != null)
                appointments = appointments.Where(a => a.Doctor == doctor);
            if (patient != null)
                appointments = appointments.Where(a => a.Patient == patient);

            return appointments;
        }
    }
}
