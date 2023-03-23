using System;
namespace ConsoleUI
{
class Car  : vehicle
   {
      public bool HasTrunk {get;set;} 
     public override void driveabstract()
   {
   Console.WriteLine("car drive");
   }
   }
}
