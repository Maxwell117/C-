namespace factory
{
    using System;
    class VehicleFactory
    {
       
            public IVehicle CreateVehicle(string userInput)
            {
                switch (userInput)
                {
                    case "car":
                    return new Car();
                        break;
                    case "motorcycle":
                        return new MotorCycle();
                        break;
                    default:
                        return new Car();
                        break;
                }
        }
    }
}