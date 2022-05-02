using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    internal class Car
    {
        public Car()
        {
            CarCount++;
            
        }

        public Car(int year, string make, string model, string engine, string honk, bool drive)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engine;
            HonkNoise = honk;
            IsDriveable = drive;
            CarCount++;
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public Boolean IsDriveable { get; set; }

        public void MakeHonkNoise()
        {
            Console.WriteLine(HonkNoise);
        }

        public void MakeEngineNoise()
        {
            Console.WriteLine(EngineNoise);
        }

        public static int CarCount = 0;
    }
}
