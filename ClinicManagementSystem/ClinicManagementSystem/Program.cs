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
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace ClinicManagementSystem
{
    static class Program
    {
        private static IConfigurationRoot _configuration;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            _configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", false, true)
                .Build();
            SystemDBConfiguration.ConnectionString = _configuration["database:connectionString"];

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);
            var provider = services.BuildServiceProvider();

            Application.Run(new MainWindow(provider, Forms.UserLevel.Undetermined, _configuration));
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ISystemContext, SystemContext>()
                    // authentication, authorization:
                    .AddSingleton<IPasswordHasher, PasswordHasher>()
                    .AddScoped<IAuthenticationService, AuthenticationService>(sp => new AuthenticationService(sp.GetRequiredService<IPasswordHasher>(), sp.GetRequiredService<ISystemContext>(), int.Parse(_configuration["database:connectionTimeout"])))
                    .AddScoped<IAuthorizationService, AuthorizationService>()
                    // people, users:
                    .AddScoped<IDoctorService, DoctorService>()
                    .AddScoped<ILaboratoryTechnicianService, LaboratoryTechnicianService>()
                    .AddScoped<ILaboratoryManagerService, LaboratoryManagerService>()
                    .AddScoped<IPatientService, PatientService>()
                    .AddScoped<IReceptionistService, ReceptionistService>()
                    // appointments:
                    .AddScoped<IAppointmentService, AppointmentService>()
                    // examinations:
                    .AddScoped<IExaminationService, ExaminationService>()
                    .AddScoped<ILaboratoryExamService, LaboratoryExamService>()
                    .AddScoped<IPhysicalExamService, PhysicalExamService>()
                    .AddScoped<IApplicationUserService, ApplicationUserService>();

            //.AddLogging(configure => configure.AddConsole())
        }
    }
}
