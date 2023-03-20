using System;

namespace InterfaceExercise
{

      interface IVehicle
           {
           public int windows{get;set;}
           public int wheels{get;set;}
            public string dealership{get;set;}
            public string milage{get;set;}

            public void brake();
            public void park();
            public void refill();
           }

           interface ICompany
           {
           public string logo{get;set;}
           public string CEO{get;set;} 
           }

           class Car : IVehicle,ICompany
           {
           public car()
           {

           }
           public void brake()
           {
            console.writeline("car brake");
           }
           }

           class truck : IVehicle,ICompany
           {
           public truck()
           {

           }
            public void brake()
           {
            console.writeline("truck brake");
           }
           }

           class SUV : IVehicle,ICompany
           {
           public SUV()
           {

           }
              public void brake()
           {
            console.writeline("SUV brake");
           }
           }




    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany
       
            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //In ICompany
            
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */

            //In each of your car, truck, and suv classes

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            car honda=new car();
            truck toyoto=new truck();
            SUV ssds=new SUV();
        }
    }
}
