using ClinicManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Services.impl
{
    public abstract class BaseService : IBaseService
    {
        protected ISystemContext context;
        private bool disposed = false;

        public BaseService(ISystemContext context)
        {
            this.context = context;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose(); // PR: nie wiem czy powinno być skoro tym też zarządza provider
                }
                disposed = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
