using ClinicManagementSystem.Auth.Services;
using ClinicManagementSystem.Entities;
using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicManagementSystem.Services.impl
{
    public class AdminService : BaseService, IAdminService
    {
        private readonly IAuthorizationService authorizationService;

        public AdminService(IAuthorizationService service, ISystemContext context) : base(context)
        {
            authorizationService = service;
        }

        public IEnumerable<Admin> GetAdmins()
        {
            return context.SystemAdministrators;
        }

        public Admin GetAdminByID(int adminId)
        {
            return context.SystemAdministrators.Find(adminId);
        }

        public Admin InsertAdmin(Admin admin, string password)
        {
            return authorizationService.AddPerson(admin, password);
        }

        public void UpdateAdmin(Admin admin, string password)
        {
            authorizationService.UpdatePerson(admin, password);
        }

        public void DisableAdminAccount(int adminId)
        {
            // if there's just 1 admin or just 1 admin has active account, do not disable the only admin account!
            if (context.SystemAdministrators.Count() == 1
                || context.SystemAdministrators.Where(a => !(context.ApplicationUsers.Single(u => a.Email != null ? a.Email == u.Email : a.PhoneNumber == u.PhoneNumber).IsDisabled)).Count() == 1)
                throw new InvalidOperationException("Cannot disable the only active administrator account");
            authorizationService.DisablePersonAccount<Admin>(adminId);
        }
        public void EnableAdminAccount(int adminId)
        {
            authorizationService.EnablePersonAccount<Admin>(adminId);
        }
    }
}

