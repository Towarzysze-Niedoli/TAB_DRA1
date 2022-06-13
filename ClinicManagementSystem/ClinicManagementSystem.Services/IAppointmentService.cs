using ClinicManagementSystem.Entities.Enums;
using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Services
{
    public interface IAppointmentService: IDisposable
    {
        IEnumerable<Appointment> GetAppointments();
        Appointment GetAppointmentByID(int appointmentId);
        Appointment GetAppointmentForPatientByCompletionDate(Patient patient, DateTime completionDate); // assuming there is only one appointment per day for a given patient 
        void InsertAppointment(Appointment appointment);
        void DeleteAppointment(int appointmentId);
        void UpdateAppointment(Appointment appointment);
        void Save();
        IEnumerable<Appointment> GetAppointmentsForDoctor(Doctor doctor);
        IEnumerable<Appointment> GetAcceptedAppointmentsForPatient(Patient patient);
        IEnumerable<Appointment> GetAppointmentsByCompletionDate(DateTime completionDate);
        IEnumerable<Appointment> GetAppointmentsByStatus(AppointmentStatus status);
        IEnumerable<Appointment> GetAppointmentsByPatientAndStatus(Patient patient, AppointmentStatus status);
        IEnumerable<Appointment> GetAppointmentsForPatient(Patient patient);
    }
}
