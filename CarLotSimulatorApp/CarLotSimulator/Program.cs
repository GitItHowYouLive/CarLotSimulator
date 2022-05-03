using System;
using System.Collections.Generic;

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

            var RBCustoms = new CarLot();

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var c1 = new Car();
            c1.Make = "Dodge";
            c1.Model = "Challenger";
            c1.Year = 1969;
            c1.EngineNoise = "VROOM";
            c1.HonkNoise = "BONK BONK";
            c1.IsDriveable = true;
            RBCustoms.TheLot.Add(c1);



            RBCustoms.TheLot.Add(new Car(1989, "Isuzu", "Rodeo", "BRUPBRUPBRUP", "beep beep", true));

            RBCustoms.TheLot.Add(new Car() { EngineNoise = "            ", IsDriveable = true, HonkNoise = "MOVE! I'm RICH!", Make = "Tesla", Model = "Roadster", Year = 2016 });

            RBCustoms.TheLot.Add(new Motorcycle(2004, "BMW", "K1200GT", "HUMMMMMMMMM", "BEEEEEP", true));

            //Console.WriteLine(RBCustoms.Cars[0]);
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            bool done = false;
            Console.WriteLine("Have you added any new cars to the lot?");

            while (!done)
            {
                Console.WriteLine("Please enter yes or no.");
                string newCar = Console.ReadLine().Trim().ToLower();

                switch (newCar)
                {
                    case "yes":
                    case "y":
                    case "yep":
                        RBCustoms.WinAuction();
                        Console.WriteLine("\nHave you added any other new cars to the lot?");
                        break;
                    case "no":
                    case "n":
                    case "nope":
                        done = true;
                        break;
                    default:
                        Console.WriteLine("Unrecognized input. Please try again.");
                        break;
                }
            }

            RBCustoms.TakeInventory();
            Console.WriteLine($"Your total number of vehicles is {CarLot.numberOfCars}.");
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
