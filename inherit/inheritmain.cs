  using System;
  namespace inherit
  {
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
        
        Console.WriteLine(parrot.wings + parrot.flight + parrot.flightspeed + parrot.eggs);
        Console.WriteLine(salamander.camoflague + salamander.coldblooded + salamander.scalecolor + salamander.venomous);
        }
     
    }
}
