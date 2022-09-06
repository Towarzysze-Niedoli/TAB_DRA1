using ClinicManagementSystem.Entities;
using ClinicManagementSystem.Entities.Enums;
using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
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
            LaboratoryExam laboratoryExam = GetLaboratoryExamByID(laboratoryExamId);
            context.LaboratoryExams.Remove(laboratoryExam);
            Save();
        }

        public LaboratoryExam GetLaboratoryExamByID(int laboratoryExamId)
        {
            return context.LaboratoryExams.Find(laboratoryExamId);
        }

        public IEnumerable<LaboratoryExam> GetLaboratoryExams()
        {
            return GetLE();
        }

        public IList<LaboratoryExam> GetLaboratoryExamsByStatus(TestStatus? testStatus)
        {
            return testStatus is null
                ? GetLE().ToList()
                : GetLE().Where(e => e.Status == testStatus).ToList();
        }

        public void InsertLaboratoryExam(LaboratoryExam laboratoryExam)
        {
            context.LaboratoryExams.Add(laboratoryExam);
            Save();
        }

        public void UpdateLaboratoryExam(LaboratoryExam laboratoryExam)
        {
            context.Entry(laboratoryExam).State = System.Data.Entity.EntityState.Modified;
            Save();
        }


        private IEnumerable<LaboratoryExam> GetLE()
        {
            return context.LaboratoryExams
                .Include(e => e.Examination)
                .Include(e => e.Appointment).Include(e => e.Appointment.Patient).Include(e => e.Appointment.Doctor)
                .Include(e => e.LaboratoryTechnician)
                .Include(e => e.LaboratoryManager);
        }
    }
}
