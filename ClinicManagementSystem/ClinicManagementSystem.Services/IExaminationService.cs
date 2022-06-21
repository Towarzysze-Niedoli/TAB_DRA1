using ClinicManagementSystem.Entities.Enums;
using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Services
{
    public interface IExaminationService: IBaseService
    {
        IEnumerable<Examination> GetExaminations();
        IEnumerable<Examination> GetExaminationsByType(ExaminationType examinationType);
        Examination GetExaminationByID(int examinationId);
        void InsertExamination(Examination examination);
        void DeleteExamination(int examinationId);
        void UpdateExamination(Examination examination);
    }
}
