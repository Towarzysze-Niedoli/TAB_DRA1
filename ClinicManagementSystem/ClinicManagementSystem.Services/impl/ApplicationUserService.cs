using ClinicManagementSystem.Entities;
using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ClinicManagementSystem.Services.impl
{
    public class ApplicationUserService : BaseService, IApplicationUserService
    {
        public ApplicationUserService(ISystemContext context) : base(context){}

        public ApplicationUser GetAccountStatus(string email)
        {
            return context.ApplicationUsers.Where(u => u.Email.Equals(email)).FirstOrDefault();
        }
    }
}
