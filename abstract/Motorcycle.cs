using System;
namespace ConsoleUI
{
class Motorcycle : vehicle
   {
    public bool HasSideCart {get;set;} 
    public override void driveabstract()
   {
   Console.WriteLine("motorcycle drive");
   }

  public override void drivevirtual()
   {
   Console.WriteLine("motorcycle drive virtual");
   }

   }
}
