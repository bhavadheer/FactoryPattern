using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Factory
{
    
    /// IFactory =Interface
    ///Car & Bike = Concreate Product classes
    ///VehicleFactory =Creator
    ///ConcreteVehicleFactory =Concreate Creator
    public interface IFactory
    {
        void Drive(int miles);
    }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class Car : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the Car : " + miles.ToString()+ "miles" );
        }
    }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class Bike : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the Bike: " + miles.ToString() +"miles");
            
        }
       
        class Program
        {

            public void Drive(int miles)
            {
                Console.WriteLine("Drive the Bike : " + miles.ToString() + "km");
            }
        }
    }
        /// <summary>
        /// The Creator Abstract Class
        /// </summary>
        public abstract class VehicleFactory
        {
            public abstract IFactory GetVehicle(string Vehicle);

        }

        /// <summary>
        /// A 'ConcreteCreator' class
        /// </summary>
        public class ConcreteVehicleFactory : VehicleFactory
        {
            public override IFactory GetVehicle(string Vehicle)
            {
                switch (Vehicle)
                {
                    case "Car":
                        return new Car();
                    case "Bike":
                        return new Bike();
                    default:
                        throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Vehicle));
                }
            }

        }

        /// <summary>
        /// Factory Pattern Demo
        /// </summary>
        class Program
        {
            static void Main(string[] args)
            {
                VehicleFactory factory = new ConcreteVehicleFactory();

                IFactory Car = factory.GetVehicle("Car");
                Car.Drive(80);

                IFactory bike = factory.GetVehicle("Bike");
                bike.Drive(60);

                Console.ReadKey();

            }
        }
    }

            

