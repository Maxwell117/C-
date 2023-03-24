using System;
using System.Collections.Generic;
namespace car
{
    class Car
    {
        public int year { get; set; } = default(int);
        public string model { get; set; } =default(string);
        public string make { get; set; } = default(string);
        public bool IsDriveable { get; set; } =default(bool);
        public string HonkNoise { get; set; } = default(string);
        public string EngineNoise { get; set; } = default(string);
        public Car()
        {
            CarLot.cnt++;
        }

        public Car(int year, string model, string make, bool IsDriveable, string HonkNoise, string EngineNoise)
        {
            CarLot.cnt++;
        this.year = year;
            this.model = model;
            this.make = make;
            this.IsDriveable = IsDriveable;
            this.HonkNoise = HonkNoise;
            this.EngineNoise = EngineNoise;
        }

        public void MakeEngineNoise(string n)
        {
            Console.WriteLine(n);
        }


        public void MakeHonkNoise()
        {
            Console.WriteLine(HonkNoise);
        }




    }
}
