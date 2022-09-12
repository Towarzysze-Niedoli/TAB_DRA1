using ClinicManagementSystem.Entities.Enums;
using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Services
{
    public interface IAppointmentService: IBaseService
    {
        IList<Appointment> GetAppointments();
        Appointment GetAppointmentByID(int appointmentId);
        Appointment GetAppointmentForPatientByCompletionDate(Patient patient, DateTime completionDate); // assuming there is only one appointment per day for a given patient 
        void InsertAppointment(Appointment appointment);
        void DeleteAppointment(int appointmentId);
        void UpdateAppointment(Appointment appointment);

        /// <summary>
        /// Returns appointments with given parameters. If you don't want to filter by some parameters, leave them null.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="doctor"></param>
        /// <param name="patient"></param>
        /// <returns></returns>
        IList<Appointment> GetAppointments(AppointmentStatus? status, DateTime? date, Doctor doctor = null, Patient patient = null);

        /// <summary>
        /// Returns appointments with given parameters. If you don't want to filter by some parameters, leave them null.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="doctor"></param>
        /// <param name="patient"></param>
        /// <returns></returns>
        IEnumerable<Appointment> GetAppointmentsAsEnumerable(AppointmentStatus? status, DateTime? date, Doctor doctor = null, Patient patient = null);

        IList<Appointment> GetAppointmentsByCompletionDate(DateTime completionDate);
        DateTime? GetLastAppointmentDateForPatient(Patient patient);
        IList<Appointment> GetAppointmentsByScheduledDate(DateTime date);

        bool IsDoctorAvailable(DateTime date, Doctor doctor);
    }
}
