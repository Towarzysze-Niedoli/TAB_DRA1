using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServer;
using System.Text;

namespace ClinicManagementSystem.Entities.Models
{
    class SystemDBConfiguration : DbConfiguration
    {
        public SystemDBConfiguration()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new DefaultExecutionStrategy());
            SetDefaultConnectionFactory(new SqlConnectionFactory("Data Source=localhost;Persist Security Info=True;User ID=user;Password=123"));
        }
    }
}
