using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    internal class Car : Vehicle
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
                
        public bool IsDriveable { get; set; }
        
        public static int CarCount = 0;
    }
}
