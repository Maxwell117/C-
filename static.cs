using System;
namespace StaticExercise
{

class car
{

  public int year{get;set;};
  public string model{get;set;};
  public string make{get;set;}; 
  public static int cnt=0;

     public car()
     {
     cnt++;
     }    

     public public car(int year,string model,string make)
     {
     this.year=year;
     this.model=model;
     this.make=make;
     cnt++;   
     }
}




    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            var result = (fahrenheit - 32) / 1.8;

            return result;
        }

        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9) / 5 + 32;
        }
    }

public static r
{
    public class Program
    {
        static void Main(string[] args)
        {
         var celc=TempConverter.FahrenheitToCelsius(70);
         var fahr=TempConverter.CelsiusToFahrenheit(88);

         car<honda>=new car<honda>();

        }
     
    }
}

