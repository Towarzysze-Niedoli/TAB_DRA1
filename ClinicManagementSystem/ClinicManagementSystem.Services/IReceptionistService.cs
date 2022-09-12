using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Services
{
    public interface IReceptionistService : IBaseService
    {
        IEnumerable<Receptionist> GetReceptionists();
        Receptionist GetReceptionistByID(int receptionistId);
        Receptionist InsertReceptionist(Receptionist receptionist, string password);
        void UpdateReceptionist(Receptionist receptionist, string password = null);
        void DisableReceptionistAccount(int receptionistId);
        void EnableReceptionistAccount(int receptionistId);
        Receptionist GetReceptionistByName(string firstName, string lastName);
    }
}
