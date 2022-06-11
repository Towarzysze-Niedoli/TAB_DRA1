using ClinicManagementSystem.Entities;
using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Services.impl
{
    public class PhysicalExamService: IPhysicalExamService, IDisposable
    {

        private ISystemContext context;

        public PhysicalExamService(ISystemContext context)
        {
            this.context = context;
        }

        public void DeletePhysicalExam(int physicalExamId)
        {
            PhysicalExam physicalExam = context.PhysicalExams.Find(physicalExamId);
            context.PhysicalExams.Remove(physicalExam);
        }

        public PhysicalExam GetPhysicalExamByID(int physicalExamId)
        {
            return context.PhysicalExams.Find(physicalExamId);
        }

        public IEnumerable<PhysicalExam> GetPhysicalExams()
        {
            return context.PhysicalExams;
        }

        public void InsertPhysicalExam(PhysicalExam physicalExam)
        {
            context.PhysicalExams.Add(physicalExam);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdatePhysicalExam(PhysicalExam physicalExam)
        {
            context.Entry(physicalExam).State = System.Data.Entity.EntityState.Modified;
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
