using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    internal class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
            BikeCount++;
        }

        public Motorcycle(int year, string make, string model, string engine, string honk, bool ride)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engine;
            HonkNoise = honk;
            IsRideable = ride;
            BikeCount++;
        }

        public Boolean IsRideable { get; set; }

        private static int BikeCount = 0;
    }
}
