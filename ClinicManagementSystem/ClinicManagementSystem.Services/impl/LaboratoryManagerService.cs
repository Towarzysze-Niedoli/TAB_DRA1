using ClinicManagementSystem.Auth.Services;
using ClinicManagementSystem.Entities;
using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Services.impl
{
    public class LaboratoryManagerService : BaseService, ILaboratoryManagerService
    {
        private readonly IAuthorizationService authorizationService;

        public LaboratoryManagerService(IAuthorizationService service, ISystemContext context) : base(context)
        {
            authorizationService = service;
        }

        public IEnumerable<LaboratoryManager> GetLaboratoryManagers()
        {
            return context.LaboratoryManagers;
        }

        public LaboratoryManager GetLaboratoryManagerByID(int laboratoryManagerId)
        {
            return context.LaboratoryManagers.Find(laboratoryManagerId);
        }

        public LaboratoryManager InsertLaboratoryManager(LaboratoryManager laboratoryManager, string password)
        {
            return authorizationService.AddPerson(laboratoryManager, password);
        }

        public void UpdateLaboratoryManager(LaboratoryManager laboratoryManager, string password = null)
        {
            authorizationService.UpdatePerson(laboratoryManager, password);
        }

        public void DisableLaboratoryManagerAccount(int laboratoryManagerId)
        {
            authorizationService.DisablePersonAccount<LaboratoryTechnician>(laboratoryManagerId);
        }

        public void EnableLaboratoryManagerAccount(int laboratoryManagerId)
        {
            authorizationService.EnablePersonAccount<LaboratoryTechnician>(laboratoryManagerId);
        }
    }
}
