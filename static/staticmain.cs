using System;
namespace staticexercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celc = TempConverter.FahrenheitToCelsius(70);
            var fahr = TempConverter.CelsiusToFahrenheit(88);
        }

    }
}
