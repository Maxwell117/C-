using System;
using System.Collections.Generic;
namespace car
{
class Car 
{
 public int year{get;set;}; 									
 public string model{get;set;};
 public string make{get;set;};
public bool IsDriveable{get;set;};
 public string HonkNoise{get;set;};
 public string EngineNoise{get;set;};
     public Car()
     {
         CarLot.cnt++
     }

     public Car(int year,string model,string make,bool IsDriveable,string HonkNoise,string EngineNoise)
     {
     CarLot.cnt++
     this.year=year;
     this.model=model;
     this.make=make;
     this.IsDriveable=IsDriveable;
     this.HonkNoise=HonkNoise;
     this.EngineNoise=EngineNoise;
     }

public void MakeEngineNoise(string n)
{
Console.WriteLine(n);
}


public void MakeHonkNoise()
{
Console.WriteLine(HonkNoise);;
}




}
}
