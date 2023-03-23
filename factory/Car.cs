using System;
namespace factory
{
    public class Car : IVehicle
    {
        
        
            public string Color { get; set; }
            public bool IsDriveable { get; set; }

            public void Drive()
            {
            Console.WriteLine("Sorry cant text, im driving");
            }

        
        }
    }
