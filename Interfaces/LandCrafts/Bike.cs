using System;
using Interfaces._Interfaces;

namespace Interfaces.LandCrafts
{
    public class Bike : ILandCraft
    {
        public int Wheels { get; set; } = 2;
        public int Doors { get; set; } = 0;
        public string TransmissionType { get; set; } = "None";
        public double EngineVolume { get; set; } = 0;
        public double MaxLandSpeed { get; set; } = 40;

        public void Move()
        {
            Console.WriteLine("The bike sliently passes through a store");
        }

        public void Start()
        {
            Console.WriteLine("The bike starts moving...");
        }

        public void Stop()
        {
            Console.WriteLine("The bike is getting stop...");

        }
    }
}


