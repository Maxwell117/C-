using System;
namespace ConsoleUI
{
    class Car : Vehicle
    {
        public bool HasTrunk { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("car drive");
        }
    }
}
