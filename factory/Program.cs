using System;
using System.Collections.Generic;
using System.Text;

namespace factory
{
    class Program
    {
        static void Main(string[] args)
        {

           
            Console.WriteLine("What type of vehicle do you want?");
            string userInput=Console.ReadLine();

            VehicleFactory vehicleFactory = new VehicleFactory();
            IVehicle mycar=vehicleFactory.CreateVehicle(userInput);
            
            
        }
    }
}
    

