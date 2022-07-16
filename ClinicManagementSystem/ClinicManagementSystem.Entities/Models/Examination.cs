using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using ClinicManagementSystem.Entities.Enums;

namespace ClinicManagementSystem.Entities.Models
{
    public class Examination
    {
        /// <summary>
        /// Recommended ICD-10-PCS or ICD-10-CM code, eg. 4A0ZXKZ or Z46.3.
        /// See <a href="https://www.icd10data.com/ICD10PCS/Codes">list of PCS codes</a>, <a href="https://www.icd10data.com/ICD10CM/Codes/Z00-Z99/Z00-Z13">list of CM codes</a>
        /// </summary>
        [Key]
        [Required(ErrorMessage = "Examination code is required")]
        [StringLength(8, MinimumLength = 3, ErrorMessage = "Examination code should be 3-8 characters long")]
        //[RegularExpression(@"(^[Zz][0-9]{2}\.[0-9]$)|(^[0-9BbCcDdFfGgHhXx][a-hj-np-zA-HJ-NP-Z0-9]{6}$)", ErrorMessage = "Examination code is not a valid ICD-10-PCS or ICD-10 code, eg. 4A0ZXKZ or Z46.3")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Examination type is required")]
        public ExaminationType ExamType { get; set; }

        [Required(ErrorMessage = "Examination name is required")]
        public string ExaminationName { get; set; }

        /// <summary>
        /// "[Code] ExaminationName"
        /// </summary>
        public string FormattedName => $"[{this.Code}] {this.ExaminationName}";


/*        public static Examination TemperatureExamination = new Examination()
        {
            Code = "4A0ZXKZ",
            ExamType = ExaminationType.Physical,
            ExaminationName = "Measurement of Temperature, External Approach"
        };

        public static Examination BloodPressureExamination = new Examination()
        {
            Code = "4A03XB1",
            ExamType = ExaminationType.Physical,
            ExaminationName = "Measurement of Arterial Pressure, Peripheral, External Approach"
        };

        public static Examination SugarLevelExamination = new Examination()
        {
            Code = "Z13.1",
            ExamType = ExaminationType.Physical,
            ExaminationName = "Encounter for screening for diabetes mellitus"
        };*/
    }
}
