using ClinicManagementSystem.Entities.Enums;
using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Services
{
    public interface IAppointmentService: IBaseService
    {
        Appointment CurrentAppointment { get; set; }
        IEnumerable<Appointment> GetAppointments();
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
        IEnumerable<Appointment> GetAppointments(AppointmentStatus? status, Doctor doctor = null, Patient patient = null);

        IEnumerable<Appointment> GetAppointmentsByCompletionDate(DateTime completionDate);
        IEnumerable<Appointment> GetAppointmentsByStatus(AppointmentStatus status);
        IEnumerable<Appointment> GetAppointmentsByStatusAndDoctor(AppointmentStatus status, Doctor doctor);
        IEnumerable<Appointment> GetAppointmentsByPatientAndStatus(Patient patient, AppointmentStatus status);
        IEnumerable<Appointment> GetAppointmentsForPatient(Patient patient);
        DateTime? GetLastAppointmentDateForPatient(Patient patient);
        IEnumerable<Appointment> GetAppointmentsByScheduledDate(DateTime date);
    }
}
