using ClinicManagementSystem.Entities;
using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Services.impl
{
    public class PhysicalExamService: BaseService, IPhysicalExamService
    {

        public PhysicalExamService(ISystemContext context) : base(context)
        {
            
        }

        public void DeletePhysicalExam(int physicalExamId)
        {
            PhysicalExam physicalExam = context.PhysicalExams.Find(physicalExamId);
            context.PhysicalExams.Remove(physicalExam);
            Save();
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
            Save();
        }

        public void UpdatePhysicalExam(PhysicalExam physicalExam)
        {
            context.Entry(physicalExam).State = System.Data.Entity.EntityState.Modified;
            Save();
        }

    }
}
