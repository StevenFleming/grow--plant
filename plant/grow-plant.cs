using System;
namespace AboutPlant

{
    public class Plant
    {
        public string Name {get; set;}
        public string Color {get; set;}
        public int WaterLevel {get; set;}
        public int SunshineLevel {get; set;}
        public int FoodLevel {get; set;}
        public bool PlantLiving {get; set;}


        public Plant (string name, string color, int waterLevel, int sunshineLevel, int foodLevel, bool plantLiving)
        {
            Name = name;
            Color = color;
            WaterLevel = waterLevel;
            SunshineLevel = sunshineLevel;
            FoodLevel = foodLevel;
            PlantLiving = plantLiving; 
        }

        public void Water ()
        {
           WaterLevel ++;
        }

        public void Feed ()
        {
            FoodLevel ++;
            if (FoodLevel>= 10)
            {
                Color = "green";
            }
            else if(FoodLevel <=7)
            {
                Color = "yellow";
            }
            else if (FoodLevel<=3)
            {
                Color = "brown";
            }

        }

        public void Sun ()
        {
            SunshineLevel += 2;
        }

        public void PrintPlant()
        {
            Console.Write(Name + ", ");
            Console.Write(Color +  ", ");
            Console.Write(WaterLevel + ", ");
            Console.Write(SunshineLevel + ", ");
            Console.Write(FoodLevel + ", ");
            Console.WriteLine(PlantLiving);
        }
    }
}