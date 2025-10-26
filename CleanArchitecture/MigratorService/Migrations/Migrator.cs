using DbUp;
using DbUp.Helpers;
using System.Reflection;

namespace MigratorService.Migrations
{
    public static class Migrator
    {
        public static void PerformMigrations(string connectionString)
        {
            var upgrader = DeployChanges.To
                .SqlDatabase(connectionString)
                .WithExecutionTimeout(new TimeSpan(1, 1, 1))
                .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
                .LogToConsole();

            upgrader.JournalTo(new NullJournal());

            var result = upgrader.Build().PerformUpgrade();
        }
    }
}
