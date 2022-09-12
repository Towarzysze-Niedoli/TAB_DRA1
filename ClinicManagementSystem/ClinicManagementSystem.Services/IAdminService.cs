using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Services
{
    public interface IAdminService : IBaseService
    {
        IEnumerable<Admin> GetAdmins();
        Admin GetAdminByID(int adminId);
        Admin InsertAdmin(Admin admin, string password);
        void UpdateAdmin(Admin admin, string password = null);
        void DisableAdminAccount(int adminId);
        void EnableAdminAccount(int adminId);
    }
}
