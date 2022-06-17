using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Services
{
    internal interface IPhysicalExamService: IBaseService
    {
        IEnumerable<PhysicalExam> GetPhysicalExams();
        PhysicalExam GetPhysicalExamByID(int physicalExamId);
        void InsertPhysicalExam(PhysicalExam physicalExam);
        void DeletePhysicalExam(int physicalExamId);
        void UpdatePhysicalExam(PhysicalExam physicalExam);
    }
}
