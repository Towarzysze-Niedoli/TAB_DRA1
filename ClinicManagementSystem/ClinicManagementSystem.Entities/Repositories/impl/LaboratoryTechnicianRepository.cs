using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Entities.Repositories.impl
{
    internal class LaboratoryTechnicianRepository: ILaboratoryTechnicianRepository, IDisposable
    {
        private SystemContext context;

        public LaboratoryTechnicianRepository(SystemContext context)
        {
            this.context = context;
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

        public void InsertLaboratoryTechnician(LaboratoryTechnician LaboratoryTechnician)
        {
            context.LaboratoryTechnicians.Add(LaboratoryTechnician);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateLaboratoryTechnician(LaboratoryTechnician LaboratoryTechnician)
        {
            context.Entry(LaboratoryTechnician).State = System.Data.Entity.EntityState.Modified;
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
