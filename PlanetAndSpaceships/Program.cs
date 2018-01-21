using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {

            // Creates new list called planetList, and adds two planets to start off with
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            // Adds Jupiter and Saturn to the end of the list
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            // Creates new list called newPlanetList
            List<string> newPlanetList = new List<string> { "Uranus", "Neptune" };

            // Combines the two existing lists together
            planetList.AddRange(newPlanetList);

            // Uses Insert() to put new planets in the list at a specific location
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            // Adds Pluto to the end of the list
            planetList.Add("Pluto");

            // Loops through the planetList and prints out all of the planets in the correct order
            Console.WriteLine("Here are all the planets in the correct order:");
            foreach (var planets in planetList)
            {
                Console.WriteLine(planets);
            }

            // Uuses the GetRange method to grab planets 1-4, and puts them in a new list called rockyPlanets
            List<string> rockyPlanets = planetList.GetRange(0, 4);
            Console.WriteLine("Here are the rocky, or terrestrial, planets:");
            foreach (var newPlanets in rockyPlanets)
            {
                Console.WriteLine(newPlanets);
            }

            // Time to remove Pluto from the list, since it's not a planet anymore
            planetList.Remove("Pluto");
            Console.WriteLine("Sorry Pluto, you'll always be a planet in my heart, but for schoolastic reasons, I have to remove you from the list...");
            foreach (var planets in planetList)
            {
                Console.WriteLine(planets);
            }

            
            // Creates a new dictionary, and stores key/value pairs as strings
            var spaceshipDictionary = new Dictionary<string, string>
            {
                {"Mercury", "Mariner"},
                {"Venus", "Mariner 2"},
                {"Mars", "Mariner 9"},
                {"Jupiter", "Juno"},
                {"Saturn", "Cassini"},
                {"Uranus", "Voyager 2"},
                {"Neptune", "Voyager 2"}
            };

            // Loops over the spaceshipDictionary
            foreach (var item in spaceshipDictionary)
            {
                Console.WriteLine($"The planet {item.Key} has been visited by the spaceship/probe {item.Value}");
            }




            Console.ReadLine();

        }
    }
}
