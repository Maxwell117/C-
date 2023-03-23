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
            Vehicle vechicle1 = new Car(){Make=”Ford”,year=2003,model=”2x”};
	Vehicle vechicle2 = new Car(){Make=”Suzuki,year=2011,model=”6xz”};
            var honda=new Car() {HasTrunk=TRUE};
            var harley=new Motorcycle(); {HasSideCart=TRUE};

             list<vehicle> vehicles= new list<vehicle>();
             vehicles.add(harley);
             vehicles.add(honda);
	 vehicles.add(vehicle1);
             vehicles.add(vehicle2);

             foreach(var ride in vehicles)
             {
             Console.writeline(ride.make+ride.model+ride.year);
             Vehicle.DriveAbstract();
             Vehicle.DriveVirtual();
             }
            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
