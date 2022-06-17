using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Services
{
    internal interface IExaminationService: IBaseService
    {
        IEnumerable<Examination> GetExaminations();
        Examination GetExaminationByID(int examinationId);
        void InsertExamination(Examination examination);
        void DeleteExamination(int examinationId);
        void UpdateExamination(Examination examination);
    }
}
