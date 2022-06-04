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
        void InsertReceptionist(Receptionist receptionist);
        void DeleteReceptionist(int receptionistId);
        void UpdateReceptionist(Receptionist receptionist);
        void Save();
    }
}
