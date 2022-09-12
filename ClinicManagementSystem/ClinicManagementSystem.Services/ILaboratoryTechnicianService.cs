using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Services
{
    public interface ILaboratoryTechnicianService : IBaseService
    {
        IEnumerable<LaboratoryTechnician> GetLaboratoryTechnicians();
        LaboratoryTechnician GetLaboratoryTechnicianByID(int laboratoryTechnicianId);
        LaboratoryTechnician InsertLaboratoryTechnician(LaboratoryTechnician laboratoryTechnician, string password);
        void UpdateLaboratoryTechnician(LaboratoryTechnician laboratoryTechnician, string password = null);
        void DisableLaboratoryTechnicianAccount(int laboratoryTechnicianId);
        void EnableLaboratoryTechnicianAccount(int laboratoryTechnicianId);
        LaboratoryTechnician GetLaboratoryTechnicianByName(string firstName, string lastName);
    }
}
