using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    internal class Vehicle
    {
        public Vehicle()
        {
            CarLot.numberOfVehicles++;
        }

        ~Vehicle()
        {
            CarLot.numberOfVehicles--;
        }

        public Vehicle(int year, string make, string model, string engine, string honk)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engine;
            HonkNoise = honk;
            CarLot.numberOfVehicles++;
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }

        public void MakeHonkNoise()
        {
            Console.WriteLine(HonkNoise);
        }

        public void MakeEngineNoise()
        {
            Console.WriteLine(EngineNoise);
        }
    }
}
