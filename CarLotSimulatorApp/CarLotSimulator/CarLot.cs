using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    internal class CarLot
    {
        public CarLot()
        {
            TheLot = new List<Vehicle>();
        }
        public List<Vehicle> TheLot { get; set; }

        public void TakeInventory()
        {
            int counter = 1;
            foreach(var item in TheLot)
            {
                Console.WriteLine($"Car #{counter} is a {item.Year} {item.Make} {item.Model}");
                counter++;
            }
        }

        public void WinAuction()
        {
            Console.WriteLine("Congrats!!! Please answer the following questions about your new inventory." +
                "\nIs it a car or motorcycle?");
            bool done = false;
            string kind = "";

            while (!done)
            {
                kind = Console.ReadLine().ToLower().Trim();
                if (kind.Contains("car"))
                {
                    kind = "car";
                    done =  true;
                }
                else if (kind.Contains("motorcycle")||kind.Contains("bike")) {
                    kind = "motorcycle";
                    done = true;
                }
                else
                {
                    Console.WriteLine("That is not a valid vehicle type. Please try again.");
                }
            }

            Console.WriteLine("What is the vehicle's make?");
            string make = Console.ReadLine().Trim();

            Console.WriteLine("What is the vehicle's model?");
            string model = Console.ReadLine().Trim();

            Console.WriteLine("What year was it manufactured?");
            int year = 0;
            while(year == 0)
            {
                int.TryParse(Console.ReadLine(), out year);
                if (year == 0)
                {
                    Console.WriteLine("That is not a valid year. Please try again.");
                }
            }

            if (kind=="car")
            {
                this.TheLot.Add(new Car(year, make, model, "vroom", "honk", true));
            }
            else if (kind == "motorcycle")
            {
                TheLot.Add(new Motorcycle(year, make, model, "vroom", "honk", true));
            }

            Console.WriteLine("Your vehicle has been added to the lot. Press any key to continue.");
            Console.ReadKey();
        }

    }
}
