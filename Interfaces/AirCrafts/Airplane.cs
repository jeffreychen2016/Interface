using System;
using Interfaces._Interfaces;

namespace Interfaces.AirCrafts
{
    public class Airplane : IAirCraft
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
            Console.WriteLine("The Airplane is flying...");
        }

        public void Start()
        {
            Console.WriteLine("The Airplane starts moving...");
        }

        public void Stop()
        {
            Console.WriteLine("The Airplane is getting stop...");

        }

    }
}


