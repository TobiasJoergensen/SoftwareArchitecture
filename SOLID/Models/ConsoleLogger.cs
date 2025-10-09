using SOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Models
{
    //Single-Responsibility principles. This class has just a single responsibility, which is to function as a logger.
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }

        public void Close()
        {
            Console.ReadKey();
        }
    }
}
