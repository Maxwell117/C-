using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    abstract class Vehicle
    {
        public string year { get; set; } = "def";
        public string make { get; set; } = "def";
        public string model { get; set; } = "def";

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine("default drive");
        }

    }
}
