using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Services
{
    public interface ILaboratoryTechnicianService : IDisposable
    {
        IEnumerable<LaboratoryTechnician> GetLaboratoryTechnicians();
        LaboratoryTechnician GetLaboratoryTechniciantByID(int LaboratoryTechnicianId);
        void InsertLaboratoryTechnician(LaboratoryTechnician LaboratoryTechnician);
        void DeleteLaboratoryTechnician(int LaboratoryTechnicianId);
        void UpdateLaboratoryTechnician(LaboratoryTechnician LaboratoryTechnician);
        void Save();
    }
}
