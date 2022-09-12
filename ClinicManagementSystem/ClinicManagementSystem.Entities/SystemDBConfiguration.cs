using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServer;
using System.Text;

namespace ClinicManagementSystem.Entities.Models
{
    public class SystemDBConfiguration : DbConfiguration
    {
        public static string ConnectionString { get; set; }

        public SystemDBConfiguration()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new DefaultExecutionStrategy());
            //SetDefaultConnectionFactory(new SqlConnectionFactory("Data Source=localhost;Persist Security Info=True;User ID=user;Password=123")); // wersja Ani
            //SetDefaultConnectionFactory(new SqlConnectionFactory("Data Source=localhost;Persist Security Info=True;User ID=sa;Password=TAB_DRA1"));
            SetDefaultConnectionFactory(new SqlConnectionFactory(ConnectionString)); // from appsettings.json
        }
    }
}
