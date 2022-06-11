using ClinicManagementSystem.Entities;
using ClinicManagementSystem.Entities.Models;
using ClinicManagementSystem.Services.impl;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicManagementSystem.Forms.MainForms;
using ClinicManagementSystem.Auth.Services;
using ClinicManagementSystem.Auth;
using System.Data.Entity;
using ClinicManagementSystem.Services;

namespace ClinicManagementSystem
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);
            var provider = services.BuildServiceProvider();

            Application.Run(new MainWindow(provider, Forms.UserLevel.Undetermined));
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ISystemContext, SystemContext>()
                    .AddSingleton<IPasswordHasher, PasswordHasher>()
                    .AddScoped<IAuthenticationService, AuthenticationService>()
                    .AddScoped<IAuthorizationService, AuthorizationService>()
                    .AddScoped<IAppointmentService, AppointmentService>()
                    .AddScoped<IDoctorService, DoctorService>()
                    .AddScoped<ILaboratoryTechnicianService, LaboratoryTechnicianService>()
                    .AddScoped<ILaboratoryManagerService, LaboratoryManagerService>()
                    .AddScoped<IPatientService, PatientService>()
                    .AddScoped<IReceptionistService, ReceptionistService>();
                    
            //.AddLogging(configure => configure.AddConsole())
        }
    }
}
