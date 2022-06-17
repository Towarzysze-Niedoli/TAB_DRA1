using ClinicManagementSystem.Entities;
using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Services.impl
{
    public class LaboratoryExamService: BaseService, ILaboratoryExamService
    {

        public LaboratoryExamService(ISystemContext context) : base(context)
        {
        
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

        public void UpdateLaboratoryExam(LaboratoryExam laboratoryExam)
        {
            context.Entry(laboratoryExam).State = System.Data.Entity.EntityState.Modified;
        }

    }
}
