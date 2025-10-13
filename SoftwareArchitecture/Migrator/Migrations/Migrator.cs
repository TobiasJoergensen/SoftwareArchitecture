using DbUp;
using DbUp.Helpers;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Services.Migrations
{
    public static class Migrator
    {
        public static void PerformMigrations()
        {
            ConfigurationManager.Set


            var upgrader = DeployChanges.To
                .SqlDatabase(_applicationDBContext.ConnectionString)
                .WithExecutionTimeout(new TimeSpan(1, 1, 1))
                .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
                .LogToConsole();

            upgrader.JournalTo(new NullJournal());
        }
    }
}
