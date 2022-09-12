using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Forms
{
    public enum UserLevel
    {
        Undetermined,
        Receptionist,
        Doctor,
        Laborant,
        HeadOfLab,
        Manager
    }

    public static class PersonToUserLevel
    {
        private static readonly IReadOnlyDictionary<Type, UserLevel> dict = new Dictionary<Type, UserLevel>()
        {
            { typeof(Admin), UserLevel.Manager },
            { typeof(Doctor), UserLevel.Doctor },
            { typeof(LaboratoryManager), UserLevel.HeadOfLab },
            { typeof(LaboratoryTechnician), UserLevel.Laborant },
            { typeof(Receptionist), UserLevel.Receptionist },
            { typeof(Patient), UserLevel.Undetermined }
        };

        public static UserLevel GetLevel(Type personType)
        {
            return dict.GetValueOrDefault(personType, UserLevel.Undetermined);
        }
    }
}
