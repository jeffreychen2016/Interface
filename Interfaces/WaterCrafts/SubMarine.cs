using System;
using Interfaces._Interfaces;

namespace Interfaces.WaterCrafts
{
    public class SubMarine : IWaterCraft
    {
        public int Doors { get; set; } = 0;
        public int PassengerCapacity { get; set; } = 2;
        public double MaxWaterSpeed { get; set; } = 50;

        public void Move()
        {
            Console.WriteLine("The submarine is sinking down....");
        }

        public void Start()
        {
            Console.WriteLine("The submarine starts moving...");
        }

        public void Stop()
        {
            Console.WriteLine("The submarine is getting stop...");

        }
    }
}


