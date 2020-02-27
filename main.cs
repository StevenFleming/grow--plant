using System;
using System.Collections.Generic;
using AboutPlant;

namespace PlantProgram
{
    public class Program
    {
        public static void Main()
        {
            Plant Joe = new Plant ("Joe", "green", 5, 10, 5, true);
            Plant Bob = new Plant ("Bob", "yellow", 1, 2, 3, true);
            List<Plant> ListOfPlants = new List<Plant>{Joe, Bob};

            Console.WriteLine("Do you want to create your plant? Choose Y (for yes) or N (for no)");
            string answer = Console.ReadLine().ToLower();
            if (answer == "y")
            {
                Plant newPlant = AddPlant();
                ListOfPlants.Add(newPlant);
            } 
            else if (answer == "n")
            {
                Console.WriteLine("Okay, lets work with our garden, Joe and Bob");
            }
            else
            {
                Console.WriteLine("I'm sorry. I don't understand");
                 AddPlant();
            }

            Joe.Sun();
            Joe.Water();
            Joe.Feed();
            Joe.PrintPlant();
            Console.WriteLine(ListOfPlants.Count);

        } 
        public static Plant AddPlant()
      {
        Plant newPlant = new Plant("", "", 0, 0, 0, true);
        Console.WriteLine("Enter plant name");
        newPlant.Name = Console.ReadLine();
        Console.WriteLine("Enter plant color");
        newPlant.Color = Console.ReadLine();
        Console.WriteLine("Enter water level");
        newPlant.WaterLevel = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter sunshine level");
        newPlant.SunshineLevel = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter food level");
        newPlant.FoodLevel = int.Parse(Console.ReadLine());
        Console.WriteLine("Tell is your plant is alive");
        newPlant.PlantLiving = bool.Parse(Console.ReadLine());
        return newPlant;
      } 
    }

    
}