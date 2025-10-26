using Microsoft.Extensions.Configuration;

namespace Infrastructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            Console.WriteLine("Hello, World!");
        }
    }
}