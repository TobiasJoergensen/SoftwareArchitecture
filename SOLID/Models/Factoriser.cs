using SOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Models
{
    //Single-Responsibility principles. This class has just a single responsibility, which is to factorise.
    //Uses Liskov Substitution Principle to use derived classes without knowing them and without making the software crash... 
    //Cont: ... In this instance, any class implementing the ICalculater is acceptable as they will implement the underlying functionality of i.e. Multiply, in which the substitution will not cause a crash.
    //Dependency inversion principle states to depend upon abstractions, not concretes. Our constructor depends on interfaces which loosens the coupling compared to it being a concrete class.
    public class Factoriser : IFactoriser
    {
        private ICalculator _calculator;
        private ILogger _logger;

        public Factoriser(ICalculator calculator, ILogger logger)
        {
            _calculator = calculator;
            _logger = logger;
        }

        public void DoFactorTen(int value)
        {
            int result = _calculator.Multiply(value, 10);
            _logger.Log($"The result is {result}");
            _logger.Close();
        }
    }
}
