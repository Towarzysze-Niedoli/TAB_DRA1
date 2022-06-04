using ClinicManagementSystem.Entities;
using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Services.impl
{
    public class ReceptionistService : IReceptionistService, IDisposable
    {
        private ISystemContext context;

        public ReceptionistService(ISystemContext context)
        {
            this.context = context;
        }

        public void DeleteReceptionist(int receptionistId)
        {
            Receptionist receptionist = context.Receptionists.Find(receptionistId);
            context.Receptionists.Remove(receptionist);
        }


        public IEnumerable<Receptionist> GetReceptionists()
        {
            return context.Receptionists;
        }

        public Receptionist GetReceptionistByID(int receptionistId)
        {
            return context.Receptionists.Find(receptionistId);
        }

        public void InsertReceptionist(Receptionist receptionist)
        {
            context.Receptionists.Add(receptionist);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateReceptionist(Receptionist receptionist)
        {
            context.Entry(receptionist).State = System.Data.Entity.EntityState.Modified;
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
