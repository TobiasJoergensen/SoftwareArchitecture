using System;

public class FactoryPattern
{
    #region Abstract shared class
    // The Vehicle class declares the factory method that returns an object of a Vehicle class.
    public abstract class AbstractVehicleFactory
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
        string VehicleBrand();
        bool HasParticleFilter();
    }
    #endregion


    #region Concrete type of vehicles
    // Now we can create a specialised type of car and inherit from the abstract type of vehicle.
    class CarFactory : AbstractVehicleFactory
    {
        // Since the FactoryMethod is abstract, we need to override it and define the logic for how the factory should create the vehicle.
        public override IVehicle FactoryMethod()
        {
            return new Dacia();
        }
    }

    class TruckFactory : AbstractVehicleFactory
    {
        public override IVehicle FactoryMethod()
        {
            return new Scania();
        }
    }

    // Concrete vehicles provide various implementations of the Vehicle interface.
    class Dacia : IVehicle
    {
        private bool _wasMadeInEU;

        public string Drive()
        {
            return "I drive!";
        }

        public bool HasParticleFilter()
        {
            if (_wasMadeInEU)
            {
                return true;
            }

            return false;
        }

        public string VehicleBrand()
        {
            return "I'm a Dacia!";
        }
    }

    class Scania : IVehicle
    {
        private bool _wasMadeInEU = true;
        public string Drive()
        {
            return "I drive!";
        }

        public bool HasParticleFilter()
        {
            if(_wasMadeInEU)
            {
                return true;
            }

            return false;
        }

        public string VehicleBrand()
        {
            return "I'm a Scania!";
        }
    }
    #endregion

    public void Demo()
    {
        CarFactory carFactory = new CarFactory();     
        TruckFactory truckFactory = new TruckFactory();

        List<IVehicle> list = new List<IVehicle>();

        for (int i = 0; i < 10; i++) {
            if (i % 2 == 0) { 
                list.Add(carFactory.FactoryMethod());
            }
            else
            {
                list.Add(truckFactory.FactoryMethod());
            }
        }

        foreach(IVehicle vehicle in list)
        {
            Console.WriteLine(vehicle.GetType() + vehicle.Drive());

            if(vehicle is Dacia dacia)
            {
                Console.WriteLine(dacia.VehicleBrand());
                Console.WriteLine($"Has particle filter: {dacia.HasParticleFilter()}");

            }
            else if (vehicle is Scania scania) {
                Console.WriteLine(scania.VehicleBrand());
                Console.WriteLine($"Has particle filter: {scania.HasParticleFilter()}");
            }

            Console.WriteLine("\n");
        }
    }
}
