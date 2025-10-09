using SOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Models
{
    //Single-Responsibility principles. This class has just a single responsibility, which is to function as a calculator.
    public class Calculator : ICalculator
    {
        public int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}
