using System;

public class FactoryPattern
{
    #region Abstract shared class
    // The Vehicle class declares the factory method that returns an object of a Vehicle class.
    public abstract class Vehicle
    {
        // The FactoryMethod that we use to create new objects.
        public abstract IVehicle FactoryMethod();

        public string SomeOperation()
        {
            // Call the factory method to create a Product object.
            var vehicle = FactoryMethod();

            // Try to use the vehicles combined with the underlying type.
            var result = vehicle.Drive();

            return result;
        }
    }
    #endregion

    #region Interface with shared behaviour
    // The Product interface declares the operations that all concrete products
    // must implement.
    public interface IVehicle
    {
        string Drive();
    }
    #endregion


    #region Concrete type of vehicles
    // Now we can create a specialised type of car and inherit from the abstract type of vehicle.
    class Dacia : Vehicle
    {
        // Since the FactoryMethod is abstract, we need to override it and define the logic for how the factory should create the vehicle.
        public override IVehicle FactoryMethod()
        {
            return new Car();
        }

        public string WhoAmI()
        {
            return "I am a Dacia";
        }
    }

    class Scania : Vehicle
    {
        public override IVehicle FactoryMethod()
        {
            return new Truck();
        }

        public string WhoAmI() {
            return "I am a Scania";
        }
    }

    // Concrete vehicles provide various implementations of the Vehicle interface.
    class Car : IVehicle
    {
        public string Drive()
        {
            return "I'm a car, and I drive!";
        }
    }

    class Truck : IVehicle
    {
        public string Drive()
        {
            return "I'm a truck, and I drive!";
        }
    }
    #endregion

    public static void ClientCode(Vehicle vehicle)
    {
        Console.WriteLine("I am a vehicle. Maybe I am a Dacia. Maybe I am a Scania. I can still drive! :) \n" + vehicle.SomeOperation());
    }

    public void Demo()
    {
        Dacia dacia = new Dacia();
        Console.WriteLine($"App: Launched with a {dacia.WhoAmI()}.");
        ClientCode(dacia);

        Scania scania = new Scania();
        Console.WriteLine($"App: Launched with {scania.WhoAmI()}.");
        ClientCode(scania);
    }
}
