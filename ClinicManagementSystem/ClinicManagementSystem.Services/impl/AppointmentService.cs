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

        public AppointmentService(ISystemContext context) : base(context)
        {
            
        }

        private IEnumerable<Appointment> _getAppointments()
        {
            return context.Appointments.Include(a => a.Patient).Include(a => a.Doctor);
        }

        public void DeleteAppointment(int appointmentId)
        {
            Appointment appointment = context.Appointments.Find(appointmentId);
            context.Appointments.Remove(appointment);
            Save();
        }

        public IList<Appointment> GetAppointmentsByCompletionDate(DateTime completionDate)
        {
            return _getAppointments().Where(a => a.CompletionDate == completionDate).ToList();
        }

        public IList<Appointment> GetAppointments()
        {
            return context.Appointments.Include(a => a.Patient).Include(a => a.Doctor).ToList();
        }

        public Appointment GetAppointmentByID(int appointmentId)
        {
            return context.Appointments.Find(appointmentId);
        }

        public Appointment GetAppointmentForPatientByCompletionDate(Patient patient, DateTime completionDate)
        {
            return _getAppointments().Where(a => a.Patient == patient).Where(a => a.CompletionDate == completionDate).FirstOrDefault();
        }

        public DateTime? GetLastAppointmentDateForPatient(Patient patient)
        {
            Appointment a = _getAppointments().Where(a => a.Patient == patient).OrderByDescending(a => a.ScheduledDate).FirstOrDefault();
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

        public IList<Appointment> GetAppointmentsByScheduledDate(DateTime date)
        {
            return context.Appointments.Where(a => a.ScheduledDate.Date.Equals(date)).ToList();
        }

        public IEnumerable<Appointment> GetAppointmentsAsEnumerable(AppointmentStatus? status, DateTime? date, Doctor doctor, Patient patient)
        {
            // PR: takie skladanie where pozornie wyglada na malo wydajne, ale dla EF/LINQ wydaje sie nie miec znaczenia, a mamy jedna krotka funkcje na wszystko
            IEnumerable<Appointment> appointments = context.Appointments.Include(a => a.Patient).Include(a => a.Doctor);

            if (status != null)
                appointments = appointments.Where(a => a.AppointmentStatus == status);
            if (doctor != null)
                appointments = appointments.Where(a => a.Doctor == doctor);
            if (patient != null)
                appointments = appointments.Where(a => a.Patient == patient);
            if (date != null)
                appointments = appointments.Where(a => a.ScheduledDate.Date.Equals(date));

            return appointments;
        }

        public IList<Appointment> GetAppointments(AppointmentStatus? status, DateTime? date, Doctor doctor, Patient patient)
        {
            return GetAppointmentsAsEnumerable(status, date, doctor, patient).ToList();
        }
    }
}
