using System;
namespace factory
{
    public class MotorCycle : IVehicle
    {

        public string Color { get; set; }
        public bool HasHandBreak { get; set; }

        public void Drive()
        {
            Console.WriteLine("Driving a motorcycle");
        }


    }
}
