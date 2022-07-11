using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Services
{
    public interface IApplicationUserService
    {
        public ApplicationUser GetAccountStatus(string email);
    }
}
