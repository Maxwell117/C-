using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            Car honda=new Car();
            Car Chey=new Car();
            Car coro=new Car();
            //Set the properties for each of the cars
            honda.year=2010;
           honda.model="2A";
            honda.make="x2x";
           honda.EngineNoise="dsadas";
          honda.HonkNoise="ding";
         honda.isDriveable=true;

           chey.year=2007;
           chey.model="4C";
            chey.make="Zx2";
           chey.EngineNoise="JFGDJ”;
           chey.HonkNoise="bing";
           chey.IsDriveable=true;

	coro.year=2018;
           coro.model="7B";
           coro.make="x22";
           coro.EngineNoise="brrrrr”;
           coro.HonkNoise="clown horn”;
           coro.IsDriveable=true;
            //Call each of the methods for each car
           honda.MakeEngineNoise(honda.EngineNoise); 
           honda.MakeHonkNoise();
 	coro.MakeEngineNoise(coro.EngineNoise);
            coro.MakeHonkNoise();
	chey.MakeEngineNoise(chey.EngineNoise);
	chey.MakeHonkNoise();

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        
        }
    }
}