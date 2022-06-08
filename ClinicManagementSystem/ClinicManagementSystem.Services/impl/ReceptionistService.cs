using ClinicManagementSystem.Auth.Services;
using ClinicManagementSystem.Entities;
using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using System.Linq;

namespace ClinicManagementSystem.Services.impl
{
    public class ReceptionistService : BaseService, IReceptionistService
    {
        private readonly IAuthorizationService authorizationService;

        public ReceptionistService(IAuthorizationService service, ISystemContext context) : base(context)
        {
            authorizationService = service;
        }

        public IEnumerable<Receptionist> GetReceptionists()
        {
            return context.Receptionists;
        }

        public Receptionist GetReceptionistByID(int receptionistId)
        {
            return context.Receptionists.Find(receptionistId);
        }

        public Receptionist InsertReceptionist(Receptionist receptionist, string password)
        {
            return authorizationService.AddPerson(receptionist, password);
        }

        public void UpdateReceptionist(Receptionist receptionist, string password)
        {
            authorizationService.UpdatePerson(receptionist, password);
        }

        public void DisableReceptionistAccount(int receptionistId)
        {
            authorizationService.DisablePersonAccount<Receptionist>(receptionistId);
        }

        public void EnableReceptionistAccount(int receptionistId)
        {
            authorizationService.EnablePersonAccount<Receptionist>(receptionistId);
        }

        public Receptionist GetReceptionistByName(string firstName, string lastName)
        {
            List<Receptionist> receptionists = context.Receptionists.Include(r => r.Address).Where(r => r.FirstName.Equals(firstName) && r.LastName.Equals(lastName)).ToList();
            return receptionists.Count() != 0 ? receptionists.First() : null;
        }

        
    }
}
