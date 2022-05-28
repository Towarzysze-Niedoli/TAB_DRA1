using ClinicManagementSystem.Entities;
using ClinicManagementSystem.Entities.Models;
using ClinicManagementSystem.Repositories.Repositories.impl;
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
            services.AddSingleton<ISystemContext, SystemContext>()
                    .AddSingleton<IPasswordHasher, PasswordHasher>()
                    .AddScoped<IAuthenticationService, AuthenticationService>()
                    .AddScoped<IAuthorizationService, AuthorizationService>();
                    
            //.AddLogging(configure => configure.AddConsole())
        }
    }
}
