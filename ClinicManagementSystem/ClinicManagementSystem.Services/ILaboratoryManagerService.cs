using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Services
{
    public interface ILaboratoryManagerService : IBaseService
    {
        IEnumerable<LaboratoryManager> GetLaboratoryManagers();
        LaboratoryManager GetLaboratoryManagerByID(int laboratoryManagerId);
        LaboratoryManager InsertLaboratoryManager(LaboratoryManager laboratoryManager, string password);
        void UpdateLaboratoryManager(LaboratoryManager laboratoryManager, string password = null);
        void DisableLaboratoryManagerAccount(int laboratoryManagerId);
        void EnableLaboratoryManagerAccount(int laboratoryManagerId);
        LaboratoryManager GetLaboratoryManagerByName(string firstName, string lastName);
    }
}
