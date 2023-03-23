using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    abstract class vehicle
    {
    public string year{get;set;}="def";
    public string make{get;set;}="def";
    public string model{get;set;}="def";

   public abstract void driveabstract();
   public virtual void drivevirtual()
   {
   Console.writeline("default drive");
   }
   }
}
