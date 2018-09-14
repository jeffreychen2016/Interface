using System;
using Interfaces._Interfaces;

namespace Interfaces.LandCrafts
{

    public class Motorcycle : ILandCraft
    {
        public int Wheels { get; set; } = 2;
        public int Doors { get; set; } = 0;
        public string TransmissionType { get; set; } = "Manual";
        public double EngineVolume { get; set; } = 1.3;
        public double MaxLandSpeed { get; set; } = 160.4;

        public void Move()
        {
            Console.WriteLine("The motorcycle screams down the highway");
        }

        public void Start()
        {
            Console.WriteLine("The motorcycle starts moving...");
        }

        public void Stop()
        {
            Console.WriteLine("The motorcycle is getting stop...");

        }
    }
}


