using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Repositories.Repositories
{
    internal interface IAppointmentRepository: IDisposable
    {
        IEnumerable<Appointment> GetAppointments();
        Appointment GetAppointmenttByID(int appointmentId);
        void InsertAppointment(Appointment appointment);
        void DeleteAppointment(int appointmentId);
        void UpdateAppointment(Appointment appointment);
        void Save();
        void GetAppointmentForDoctor(Doctor doctor);
    }
}
