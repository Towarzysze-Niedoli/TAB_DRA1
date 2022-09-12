using ClinicManagementSystem.Entities;
using ClinicManagementSystem.Entities.Enums;
using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
            Save();
        }

        public Examination GetExaminationByCode(string examinationCode)
        {
            return context.Examinations.Find(examinationCode); // PR: kod jest kluczem
            //return context.Examinations.Where(e => e.Code == examinationCode).FirstOrDefault();
        }

        public IList<Examination> GetExaminations()
        {
            return context.Examinations.ToList();
        }

        public IEnumerable<Examination> GetExaminationsByType(ExaminationType examinationType)
        {
            return context.Examinations.Where(e => e.ExamType == examinationType);
        }

        public void InsertExamination(Examination examination)
        {
            context.Examinations.Add(examination);
            Save();
        }

        public void UpdateExamination(Examination examination)
        {
            context.Entry(examination).State = System.Data.Entity.EntityState.Modified;
            Save();
        }

    }
}
