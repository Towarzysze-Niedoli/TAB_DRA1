using ClinicManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClinicManagementSystem.Entities
{
    public interface ISystemContext: IDisposable, IObjectContextAdapter
    {
        DbSet<Patient> Patients { get; set; }
        DbSet<Address> Addresses { get; set; }
        DbSet<Receptionist> Receptionists { get; set; }
        DbSet<Doctor> Doctors { get; set; }
        DbSet<Appointment> Appointments { get; set; }
        DbSet<LaboratoryExam> LaboratoryExams { get; set; }
        DbSet<PhysicalExam> PhysicalExams { get; set; }
        DbSet<Examination> Examinations { get; set; }
        DbSet<LaboratoryTechnician> LaboratoryTechnicians { get; set; }
        DbSet<LaboratoryManager> LaboratoryManagers { get; set; }
        DbSet<Admin> SystemAdministrators { get; set; }
        DbSet<ApplicationUser> ApplicationUsers { get; set; }

        Database Database { get; }
        DbChangeTracker ChangeTracker { get; }
        DbContextConfiguration Configuration { get; }

        Task DbConnectionInitialization { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        int SaveChanges();
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        DbEntityEntry Entry(object entity);
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        IEnumerable<DbEntityValidationResult> GetValidationErrors();

    }
}
