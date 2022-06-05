using ClinicManagementSystem.Entities;
using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Services.impl
{
    public class ExaminationService: IExaminationService, IDisposable
    {
        private ISystemContext context;

        public ExaminationService(ISystemContext context)
        {
            this.context = context;
        }

        public void DeleteExamination(int examinationId)
        {
            Examination examination = context.Examinations.Find(examinationId);
            context.Examinations.Remove(examination);
        }

        

        public Examination GetExaminationByID(int examinationId)
        {
            return context.Examinations.Find(examinationId);
        }

        public IEnumerable<Examination> GetExaminations()
        {
            return context.Examinations;
        }


        public void InsertExamination(Examination examination)
        {
            context.Examinations.Add(examination);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateExamination(Examination examination)
        {
            context.Entry(examination).State = System.Data.Entity.EntityState.Modified;
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
