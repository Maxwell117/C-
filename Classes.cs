 using system;
using System.Collections.Generic;
namespace car
{
class Car 
{
     public car()
     {

     }

     public car(int year,string model,string make)
     {
     this.year=year;
     this.model=model;
     this.make=make;
     }
  public int year{get;set;};
  public string model{get;set;};
  public string make{get;set;};
}


    public class Program
    {
        static void Main(string[] args)
        {
        car honda=new car();
        honda.year=2010;
        honda.model="2A";
        honda.make="x2x";
       Console.writeline("year"+ honda.year + "model "+ honda.model + "make "+honda.make);
        carlist<car>=new list<car>();

        }
     
    }
}

