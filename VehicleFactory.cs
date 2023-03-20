using System;

namespace InterfaceExercise
{

      interface IVehicle
      {
      
      public void drive();
        
      }

      public class car:IVehicle
      {
        public void drive()
        {
        Console.WriteLine(“Building a new Car!”)
        }
      }

      public class BigRig:IVehicle
      {
        public void drive()
        {
        Console.WriteLine(“Building a new BigRig!”)
        }
      }
  
      static class VehicleFactory
      {
        public static IVehicle GetVehicle(int tires)
        {
            if(tires=4)
            {
            return new car();
            }
            else
            {
            return new BigRig();
            }
        }
      }
        



    class Program
    {
        static void Main(string[] args)
        {
            var ride = PhoneFactory.GetVehicle(4);
        }
    }
}
