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

        void DemoNavigatorSOLIDPrinciples()
        {
            Console.Clear();

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
    }
}
