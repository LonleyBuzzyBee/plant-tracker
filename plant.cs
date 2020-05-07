using System;

namespace PlantCare
{
  public class PlantMakeup
  {
    public string PlantName { get; set; }
    public string PlantType { get; set; }
    public string PlantAge { get; set; }
    public int PlantHealth { get; set;}

    public static string WaterPlant()
    {
      return "Your plant has been watered!";
    }
    public static string FeedPlant()
    {
      return "Your plant has been feed a fly!";
    }
    public static string SunPlant()
    {
      return "Your plant has felt the warmth of the sun!";
    }
    public static string WeedPlant()
    {
      return "Your plant has gotten a haircut!";
    }
    public static string NeglectPlant()
    {
      return "Your plant is lonely :(";
    }
    public PlantMakeup(string plantName, string plantType, string plantAge, int plantHealth)
    {
      PlantName = plantName;
      PlantType = plantType;
      PlantAge = plantAge;
      PlantHealth = plantHealth;
    }
  }
}

// different types of plants require different types of care?
// seed -> seedling -> teen plant (growth stage) -> vegetative state -> flowering stage -> reproduction stage -> regeneration stage