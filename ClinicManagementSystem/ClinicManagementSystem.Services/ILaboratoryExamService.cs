using ClinicManagementSystem.Entities.Enums;
using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Services
{
    public interface ILaboratoryExamService: IBaseService
    {
        IEnumerable<LaboratoryExam> GetLaboratoryExams();
        IList<LaboratoryExam> GetLaboratoryExamsByStatus(TestStatus? testStatus);
        LaboratoryExam GetLaboratoryExamByID(int laboratoryExamId);
        void InsertLaboratoryExam(LaboratoryExam laboratoryExam);
        void DeleteLaboratoryExam(int laboratoryExamId);
        void UpdateLaboratoryExam(LaboratoryExam laboratoryExam);
    }
}

