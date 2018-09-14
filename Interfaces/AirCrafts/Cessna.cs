using System;
using Interfaces._Interfaces;

namespace Interfaces.AirCrafts
{
    public class Cessna : IAirCraft
    {
        public int Wheels { get; set; } = 3;
        public int Doors { get; set; } = 3;
        public int PassengerCapacity { get; set; } = 113;
        public bool Winged { get; set; } = true;
        public string TransmissionType { get; set; } = "None";
        public double EngineVolume { get; set; } = 31.1;
        public double MaxAirSpeed { get; set; } = 309.0;

        public void Move()
        {
            Console.WriteLine("The Cessna effortlessly glides through the clouds like a gleaming god of the Sun");
        }

        public void Start()
        {
            Console.WriteLine("The Cessna starts moving...");
        }

        public void Stop()
        {
            Console.WriteLine("The Cessna is getting stop...");

        }
    }
}


