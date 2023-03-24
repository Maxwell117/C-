using System;
using System.Collections.Generic;
namespace car
{
    class Car
    {
        public int year { get; set; } public string model { get; set; }
        public string make { get; set; }


        public Car()
        {

        }

        public Car(int year, string model, string make)
        {
            this.year = year;
            this.model = model;
            this.make = make;
        }
    }
}
