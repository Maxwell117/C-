using System;
namespace interfaceexercise
{
    interface IVehicle
    {
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        void Drive();
        void DriveDefault()
        {
            Console.WriteLine("Default Drive inside interface");
        }
    }

    interface ICompany
    {
        public string Logo { get; set; }
        public DateTime DateEstablished { get; set; }
    }
}
