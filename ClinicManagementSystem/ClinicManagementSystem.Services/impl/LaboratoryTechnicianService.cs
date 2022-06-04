using ClinicManagementSystem.Auth.Services;
using ClinicManagementSystem.Entities;
using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Services.impl
{
    public class LaboratoryTechnicianService: ILaboratoryTechnicianService, IDisposable
    {
        private ISystemContext context;
        private IAuthorizationService authorizationService;

        public LaboratoryTechnicianService(IAuthorizationService service, ISystemContext context)
        {
            this.context = context;
            authorizationService = service;
        }

        public void DeleteLaboratoryTechnician(int LaboratoryTechnicianId)
        {
            LaboratoryTechnician laboratoryTechnician = context.LaboratoryTechnicians.Find(LaboratoryTechnicianId);
            context.LaboratoryTechnicians.Remove(laboratoryTechnician);
        }


        public IEnumerable<LaboratoryTechnician> GetLaboratoryTechnicians()
        {
            return context.LaboratoryTechnicians;
        }

        public LaboratoryTechnician GetLaboratoryTechniciantByID(int LaboratoryTechnicianId)
        {
            return context.LaboratoryTechnicians.Find(LaboratoryTechnicianId);
        }

        public void InsertLaboratoryTechnician(LaboratoryTechnician LaboratoryTechnician, string password)
        {
            authorizationService.AddPerson(LaboratoryTechnician, password);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateLaboratoryTechnician(LaboratoryTechnician LaboratoryTechnician, string password)
        {
            authorizationService.UpdatePerson(LaboratoryTechnician, password);
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
