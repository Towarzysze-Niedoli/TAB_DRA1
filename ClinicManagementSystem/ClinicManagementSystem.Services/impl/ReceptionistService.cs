using ClinicManagementSystem.Auth.Services;
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
        private IAuthorizationService authorizationService;

        public ReceptionistService(IAuthorizationService service, ISystemContext context)
        {
            this.context = context;
            authorizationService = service;
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

        public void InsertReceptionist(Receptionist receptionist, string password)
        {
            authorizationService.AddPerson(receptionist, password);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateReceptionist(Receptionist receptionist, string password)
        {
            authorizationService.UpdatePerson(receptionist, password);
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
