using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround
{
    public class DemoNavigator
    {
        public void DemoNavigatorMain()
        {
            Console.Clear();
            Console.WriteLine("Welcome to this demo on Software Architecture principles. \n\n" +
                "Please select any of the topics you want to read more about:\n"
                + "   Press 1 to go to Design Patterns.\n"
                + "   Press 2 to go to SOLID principles.\n");
            Console.WriteLine();

            var key = Console.ReadLine();

            switch (key.Trim())
            {
                case "1":
                    DemoNavigatorDesignPatterns();
                    break;
                case "2":
                    DemoNavigatorSOLIDPrinciples();
                    break;
                default:
                    break;

            }
        }

        #region DesignPatterns
        void DemoNavigatorDesignPatterns()
        {
            Console.Clear();
            Console.WriteLine("Press 1 to go to Creational Patterns");
            bool keepLooping = true;

            while (keepLooping)
            {
                var key = Console.ReadLine();

                switch (key.Trim())
                {
                    case "1":
                        DemoNavigatorCreationalDesignPatterns();
                        break;
                    case "0":
                        keepLooping = false;
                        break;
                    default:
                        break;

                }
            }

        }
        void DemoNavigatorCreationalDesignPatterns()
        {
            Console.Clear();
            Console.WriteLine("Press 1 to show Factory Pattern");
            bool keepLooping = true;

            while (keepLooping)
            {
                var key = Console.ReadLine();

                switch (key.Trim())
                {
                    case "1":
                        new FactoryPattern().Demo();
                        break;
                    case "0":
                        keepLooping = false;
                        break;
                    default:
                        break;

                }
            }
        }
        #endregion

        #region SOLID
        void DemoNavigatorSOLIDPrinciples()
        {
            Console.Clear();
            Console.WriteLine("The SOLID principles are 5 principles that help make your code more understandable, flexible, and maintainable.\n"
                + "During this demo, I will explain using the example of a calculator that can be seen in the source code. \n\n"
                + "Whenever you are ready to continue, please press any key.\n\n");

            Console.ReadKey(true);

            Console.WriteLine("S, or Single Responsibility Principle, states that there should never be more than one reason for a class to change. Or simply put, it should have just one responsbility.\n"
                + "In our code, the class \"Calculator\" has just one responsibility, and that is to function as a calculator - this includes the method multiply, but could also include addition or substraction. It does not have any logging responsibility or validation, as that would be outside of the scope of the calculator.\n"
                + "This principle helps make our code easier to maintain by having just one responsibility, it is easier to know what subject to test, and any changes will be isolated to just this class.\n\n");
            Console.WriteLine("In a nutshell: If your class har more than one responsibility, you might be violating the Single Responsbility Principle.\n");

            Console.ReadKey(true);

            Console.WriteLine("O, or Open-Closed Principle, states that software should be open for extenstion but closed for modification.\n");
            Console.WriteLine("In our code, the class \"ICalculator\" helps us follow this principle. As our calculator implements this interface it means that class has its functionality extended. Further, our interface or the class directly, could implement other interfaces leading to more extensions of functionality, without having to modify the existing classes or interfaces.\n"
                + "This principle helps us make our code extensible without having to change existing code, reduces risk of regression bugs, provides flexibility to faster implement new functionality.\n\n");
            Console.WriteLine("In a nutshell: Avoid modifying existing functionality, instead aim to extend it.\n");

            Console.ReadKey(true);

            Console.WriteLine("L, or Liskov Substitution Principle, states that functions that use pointers or references to base classes must be able to use objects of derived classes without knowing it.\n");
            Console.WriteLine("In our code, the class \"Factoriser\" is the closest we come to an example of this. It takes an instance of the ICalculator without depending on what type of class it is. It just requires the super instance of ICalculator.\n" 
                + "A better example would be to have two classes inherit from the same super while using the super as input for the function.");
            Console.WriteLine("This principle allows us to use polymorphic behaviour i.e. multiple classes as long as they are of type ICalculator, reliability by adhering to their superclass or implementations contract, and predictability knowing that replacing the class with a different class wont break the program.\n\n");
            Console.WriteLine("In a nutshell: Any class that inherits a super, should be valid to use in a function/method that takes the super as input without crashing.\n");

            Console.ReadKey(true);

            Console.WriteLine("I, or Interface Segregation Principle, states that clients should not be forced to depend upon interfaces that they do not use.\n");
            Console.WriteLine("In our code, the \"ICalculator\" is an example of this. The interface does not implement methods that are irrelevant for the calculator. If, for instance, the ICalculator was implementing a RegisterUser or Log methods, it would violate it, as it is not relevant for the Calculator.\n");
            Console.WriteLine("This principle makes the code more decoupled as classes wont overflow with unsed functionality that will violate the S in Solid, makes interfaces more precise and therefore flexible, and it makes code easier to maintain by having only relevant functionality.\n\n");
            Console.WriteLine("In a nutshell: Do not introduce unnecessary methods or functionality to an interface.\n");

            Console.ReadKey(true);

            Console.WriteLine("D, or Dependency Inversion Principle, states to depend upon abstractions, not concretes.\n");
            Console.WriteLine("In our code, the \nFactoriser\n is an example of this. In its constructor, it does not rely on a concrete but rather and abstraction in form of an interface.\n");
            Console.WriteLine("This principle reduces coupling, makes the code flexible as concretes are not the only acceptable input, and can make code easier to understand.\n\n");
            Console.WriteLine("In a nutshell: Use abstractions over concretes to make your code more flexible and have less coupling.\n\n\n");

            Console.ReadKey(true);
            Console.WriteLine("These were the SOLID principles. I hope you learned something. Press any key to return.");
            Console.ReadKey(true);
        }

        #endregion
    }
}
