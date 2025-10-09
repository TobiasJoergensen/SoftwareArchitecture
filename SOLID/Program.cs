using SOLID.Models;

var calculator = new Calculator();
var logger = new ConsoleLogger();
var factoriser = new Factoriser(calculator, logger);

factoriser.DoFactorTen(15);