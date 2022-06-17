using ClinicManagementSystem.Entities;
using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Services.impl
{
    public class ExaminationService: BaseService, IExaminationService
    {
        public ExaminationService(ISystemContext context) : base(context)
        {
            
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

        public void UpdateExamination(Examination examination)
        {
            context.Entry(examination).State = System.Data.Entity.EntityState.Modified;
        }

    }
}
