using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Repositories.Repositories
{
    internal interface IReceptionistRepository
    {
        IEnumerable<Receptionist> GetReceptionists();
        Receptionist GetReceptionistByID(int receptionistId);
        void InsertReceptionist(Receptionist receptionist);
        void DeleteReceptionist(int receptionistId);
        void UpdateReceptionist(Receptionist receptionist);
        void Save();
    }
}
