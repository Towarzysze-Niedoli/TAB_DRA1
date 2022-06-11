using ClinicManagementSystem.Entities;
using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Services.impl
{
    public class LaboratoryExamService: ILaboratoryExamService, IDisposable
    {

        private ISystemContext context;

        public LaboratoryExamService(ISystemContext context)
        {
            this.context = context;
        }

        public void DeleteLaboratoryExam(int laboratoryExamId)
        {
            LaboratoryExam laboratoryExam = context.LaboratoryExams.Find(laboratoryExamId);
            context.LaboratoryExams.Remove(laboratoryExam);
        }

        public LaboratoryExam GetLaboratoryExamByID(int laboratoryExamId)
        {
            return context.LaboratoryExams.Find(laboratoryExamId);
        }

        public IEnumerable<LaboratoryExam> GetLaboratoryExams()
        {
            return context.LaboratoryExams;
        }


        public void InsertLaboratoryExam(LaboratoryExam laboratoryExam)
        {
            context.LaboratoryExams.Add(laboratoryExam);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateLaboratoryExam(LaboratoryExam laboratoryExam)
        {
            context.Entry(laboratoryExam).State = System.Data.Entity.EntityState.Modified;
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
