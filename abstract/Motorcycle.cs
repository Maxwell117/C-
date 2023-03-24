
using System;
namespace ConsoleUI
{
    class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("motorcycle drive");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("motorcycle drive virtual");
        }

    }
}
