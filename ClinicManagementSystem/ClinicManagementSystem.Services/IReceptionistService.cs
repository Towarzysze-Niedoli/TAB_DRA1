using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Services
{
    public interface IReceptionistService
    {
        IEnumerable<Receptionist> GetReceptionists();
        Receptionist GetReceptionistByID(int receptionistId);
        void InsertReceptionist(Receptionist receptionist, string password);
        void DeleteReceptionist(int receptionistId);
        void UpdateReceptionist(Receptionist receptionist, string password = null);
        void Save();
    }
}
