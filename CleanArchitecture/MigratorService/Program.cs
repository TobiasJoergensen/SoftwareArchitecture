using Microsoft.Extensions.Configuration;
using MigratorService.Migrations;

namespace MigratorService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            var test = config.GetConnectionString("LocalDB");
            Migrator.PerformMigrations(test);

        }
    }
}
