using System;
using System.Collections.Generic;


namespace PlantCare
{
  public class Program
  {
    public static void Main()
    {
      List<PlantMakeup> Plant = new List<PlantMakeup>();

      Console.WriteLine("What type of plant do you want to take care of?");
      Console.WriteLine("Venus-Flytrap, Succulent, or Sunflower");
      string plantType = Console.ReadLine();

      Console.WriteLine("What do you want to name your plant?");
      string plantName = Console.ReadLine();
      
      Plant.Add(new PlantMakeup(plantType,plantName, "seed", 10));

      Console.WriteLine("Your plant's type is: " + plantType);
      Console.WriteLine("Your plant's name is: " + plantName);
      Console.WriteLine(plantName + " is currently a seed.");
      Console.WriteLine("What action do you want to do?");
      Console.WriteLine("water || feed || sunshine || weed || neglect || quit");
      string action = Console.ReadLine();
      while (action !)
      if (action == "water" || action == "Water")
      {
        Console.WriteLine(PlantMakeup.WaterPlant());
      }
      else if (action == "feed" || action == "Feed")
      {
        Console.WriteLine(PlantMakeup.FeedPlant());
      }
      else if (action == "sunshine" || action == "Sunshine")
      {
        Console.WriteLine(PlantMakeup.SunPlant());
      }
      else if (action == "weed" || action == "Weed")
      {
        Console.WriteLine(PlantMakeup.WeedPlant());
      }
      else if (action == "neglect" || action == "Neglect")
      {
        Console.WriteLine(PlantMakeup.NeglectPlant());
      }
      else if (action == "quit" || action == "Quit")
      {
        return;
      }
      else
      {
        Console.WriteLine("I did not understand, please type one of the actions.")
      }

    }
  }
}
    // public -> the access modifier (default is 'internal'), labels how this method is accessed. Public allows any part of internal or external code to access it.
    // static -> allows access without instantiating the class, for example Main() must be static as Program can't be instantiated
    // void -> return data type, void denotes returning nothing (i.e. no 'return' statement in the method), it can be any data type (string, int, int[](array of ints), bool, etc) but there can only be one return type
    // Main() -> name of the method