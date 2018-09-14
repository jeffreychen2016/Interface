using System;
using Interfaces._Interfaces;

namespace Interfaces.WaterCrafts
{
    public class JetSki : IWaterCraft
    {
        public int Doors { get; set; } = 0;
        public int PassengerCapacity { get; set; } = 2;
        public double MaxWaterSpeed { get; set; } = 50;

        public void Move()
        {
            Console.WriteLine("The jetski zips through the waves with the greatest of ease");
        }

        public void Start()
        {
            Console.WriteLine("The jetski starts moving...");
        }

        public void Stop()
        {
            Console.WriteLine("The jetski is getting stop...");

        }
    }
}


