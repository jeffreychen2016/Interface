using System;
using System.Collections.Generic;
using Interfaces.AirCrafts;
using Interfaces.LandCrafts;
using Interfaces.WaterCrafts;

namespace Interfaces
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var jetski = new JetSki();
            var waterCraft1 = new WaterCraft(jetski);
            waterCraft1.Move();
            waterCraft1.Start();
            waterCraft1.Stop();

            Console.WriteLine("------------------------------------------------");

            var submarine = new SubMarine();
            var waterCraft2 = new WaterCraft(submarine);
            waterCraft2.Move();
            waterCraft2.Start();
            waterCraft2.Stop();

            Console.WriteLine("------------------------------------------------");

            var cessna = new Cessna();
            var airCraft1 = new AirCraft(cessna);
            airCraft1.Move();
            airCraft1.Start();
            airCraft1.Stop();

            Console.WriteLine("------------------------------------------------");

            var airplane = new Airplane();
            var airCraft2 = new AirCraft(airplane);
            airCraft2.Move();
            airCraft2.Start();
            airCraft2.Stop();

            Console.WriteLine("------------------------------------------------");

            var motorcycle = new Motorcycle();
            var landCraft1 = new LandCraft(motorcycle);
            landCraft1.Move();
            landCraft1.Start();
            landCraft1.Stop();

            Console.WriteLine("------------------------------------------------");

            var bike = new Bike();
            var landCraft2 = new LandCraft(bike);
            landCraft2.Move();
            landCraft2.Start();
            landCraft2.Stop();

            Console.WriteLine("------------------------------------------------");

            // Build a collection of all vehicles that fly

            // With a single `foreach`, have each vehicle Fly()

            var airCrafts = new List<AirCraft>() { airCraft1, airCraft2 };

            foreach (var airCraft in airCrafts)
            {
                airCraft.Move();
            }

            // Build a collection of all vehicles that operate on roads

            // With a single `foreach`, have each road vehicle Drive()

            var landCrafts = new List<LandCraft>() { landCraft1, landCraft2 };

            foreach (var landCraft in landCrafts)
            {
                landCraft.Move();
            }

            // Build a collection of all vehicles that operate on water

            // With a single `foreach`, have each water vehicle Drive()


            var waterCrafts = new List<WaterCraft>() { waterCraft1, waterCraft2 };

            foreach (var waterCraft in waterCrafts)
            {
                waterCraft.Move();
            }
        }
    }
}


