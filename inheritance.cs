using system;
using System.Collections.Generic;
namespace inheritance
{
class Animal
{
   private int legs{get;set;}
   private string skin{get;set;}
   private int weight{get;set;}
   private string diet{get;set;}

   public Animal
   {

   }
}

class Bird : Animal
{
   private int wings{get;set;}
   private bool flight{get;set;}
   private int flightspeed{get;set;}
   private int eggs{get;set;}

   public Bird
   {
   legs=2;
   skin="feathers";
   weight=2;
   diet="omnivore";
   }
}

class Reptile : Animal
{
   private bool camoflague{get;set;}
   private bool coldblooded{get;set;}
   private string scalecolor{get;set;}
   private bool venomous{get;set;}

  public Reptile
   {
   legs=4;
   skin="scales";
   weight=4;
   diet="herbivore";
   }
}


    public class Program
    {
        static void Main(string[] args)
        {
        bird parrot=new parrot();
        parrot.wings=2;
        parrot.flight=true;
        parrot.flightspeed=6;
        parrot.eggs=3;
        reptile salamander=new reptile();
        salamander.camoflague=true;
        salamander.coldblooded=true;
        salamander.scalecolor="green";
        salamander.venomous=false;

        }
     
    }
}

