using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Services
{
    internal interface ILaboratoryExamService: IDisposable
    {
        IEnumerable<LaboratoryExam> GetLaboratoryExams();
        LaboratoryExam GetLaboratoryExamByID(int laboratoryExamId);
        void InsertLaboratoryExam(LaboratoryExam laboratoryExam);
        void DeleteLaboratoryExam(int laboratoryExamId);
        void UpdateLaboratoryExam(LaboratoryExam laboratoryExam);
        void Save();
    }
}

