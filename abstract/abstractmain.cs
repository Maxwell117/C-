using System;
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            Vehicle vehicle1 = new Car() { make ="Ford", year = "2003", model = "2x" };
            Vehicle vehicle2 = new Car() { make = "Chey", year = "2011", model = "7v" };
            var honda = new Car() { HasTrunk = true };
            var harley = new Motorcycle()
            { HasSideCart = true};

            List<Vehicle> v = new List<Vehicle>();
        

            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(harley);
            vehicles.Add(honda);
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);

            foreach (var ride in vehicles)
            {
                Console.WriteLine(ride.make + ride.model + ride.year);
                ride.DriveAbstract();
                ride.DriveVirtual();
            }
            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
