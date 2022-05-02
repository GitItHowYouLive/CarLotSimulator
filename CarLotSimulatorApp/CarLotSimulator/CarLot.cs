using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    internal class CarLot
    {
        public CarLot()
        {
            TheLot = new List<Car>();
        }
        public List<Car> TheLot { get; set; }

        public void TakeInventory()
        {
            int counter = 1;
            foreach(var item in TheLot)
            {
                Console.WriteLine($"Car #{counter} is a {item.Year} {item.Make} {item.Model}");
                counter++;
            }
        }

    }
}
