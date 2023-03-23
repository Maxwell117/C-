using System;
namespace interfaceexercise
{
    class MotorCycle : IVehicle, ICompany
    {

        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public bool HasSideCart { get; set; }
        public string Logo { get; set; }
        public DateTime DateEstablished { get; set; }







        public void Drive()
        {
            Console.WriteLine("MotorCycle Drive");
        }
    }
}
