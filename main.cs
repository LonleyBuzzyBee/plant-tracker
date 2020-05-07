using System;
using System.Collections.Generic;
using PlantInfo;

namespace PlantCare
{
  public class Program
  {
    public static void Main()
    {
      List<PlantCare> Plant = new List<PlantCare>();

      Console.WriteLine("What type of plant do you want to take care of?");
      Console.WriteLine("Dandelion, Succulent, or Sunflower");
      string plantType = Console.ReadLine();

      Console.WriteLine("What do you want to name your plant?");
      string plantName = Console.ReadLine();
      
      Plant.Add(new PlantCare(plantType,plantName, "seedling"));
      Console.WriteLine("Your plant's type is: " + plantType);
      Console.WriteLine("Your plant's name is: " + plantName);
      Console.WriteLine(plantName + " is currently a seed.");
      Console.WriteLine("What action do you want to do?");
      Console.WriteLine("water || feed || sunshine || weed");

    }
  }
}