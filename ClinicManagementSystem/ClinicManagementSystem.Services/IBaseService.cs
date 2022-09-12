using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Services
{
    public interface IBaseService : IDisposable
    {
        void Save();
    }
}
