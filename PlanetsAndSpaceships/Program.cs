using System;
using System.Collections.Generic;

namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            var planetList = new List<string>(){"Mercury", "Mars"};

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            var lastPlanets = new List<string>(){ "Uranus", "Neptune" };

            planetList.AddRange(lastPlanets);

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            planetList.Add("Pluto");

            planetList.GetRange(0, 4);

            planetList.Remove("Pluto");

            var spaceCraft = new Dictionary<string, string>();

            spaceCraft.Add("Mercury", "Mariner 10, Messenger, BepiColombo");
            spaceCraft.Add("Venus", "Mariner 1, Mariner 2, Mariner 5, Mariner 10, Pioneer 12, Galileo, Magellan, Cassini, Messenger, Parker Solar Probe, BepiColombo");
            spaceCraft.Add("Earth", "Mariner 10, Pioneer, Voyager 1, Voyager 2");
            spaceCraft.Add("Mars", "Mariner 3, Mariner 4, Mariner 6, Mariner 7, Mariner 9, Viking 1, Viking 2, Pathfinder, Sojourner, Odyssey, Spirit, Opportunity, Phoenix, Dawn, Curiosity, MAVEN, InSight, MarCO A, MarCO B");
            spaceCraft.Add("Jupiter", "Pioneer 10, Pioneer 11, Voyager 1, Voyager 2, Ulysses, Galileo, Cassini, New Horizons, Juno, Europa Clipper");
            spaceCraft.Add("Saturn","Pioneer 11, Voyager 1, Voyager 2, Cassini");
            spaceCraft.Add("Uranus", "Voyager 2");
            spaceCraft.Add("Neptune", "Voyager 2");

            foreach (var (planet, probe) in spaceCraft)
            {
                Console.WriteLine($"{planet} has been visited by the following probes: {probe}");
            }
        }
    }
}
