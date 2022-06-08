using ClinicManagementSystem.Auth.Services;
using ClinicManagementSystem.Entities;
using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Services.impl
{
    public class LaboratoryTechnicianService : BaseService, ILaboratoryTechnicianService
    {
        private readonly IAuthorizationService authorizationService;
        
        public LaboratoryTechnicianService(IAuthorizationService service, ISystemContext context) : base(context)
        {
            authorizationService = service;
        }

        public IEnumerable<LaboratoryTechnician> GetLaboratoryTechnicians()
        {
            return context.LaboratoryTechnicians;
        }

        public LaboratoryTechnician GetLaboratoryTechnicianByID(int laboratoryTechnicianId)
        {
            return context.LaboratoryTechnicians.Find(laboratoryTechnicianId);
        }

        public LaboratoryTechnician InsertLaboratoryTechnician(LaboratoryTechnician laboratoryTechnician, string password)
        {
            return authorizationService.AddPerson(laboratoryTechnician, password);
        }

        public void UpdateLaboratoryTechnician(LaboratoryTechnician laboratoryTechnician, string password)
        {
            authorizationService.UpdatePerson(laboratoryTechnician, password);
        }

        public void DisableLaboratoryTechnicianAccount(int laboratoryTechnicianId)
        {
            authorizationService.DisablePersonAccount<LaboratoryTechnician>(laboratoryTechnicianId);
        }
        public void EnableLaboratoryTechnicianAccount(int laboratoryTechnicianId)
        {
            authorizationService.EnablePersonAccount<LaboratoryTechnician>(laboratoryTechnicianId);
        }
    }
}
