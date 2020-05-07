using System;
using System.Collections.Generic;

namespace PlantCare
{
  public class PlantMakeup
  {
    public string PlantName { get; set; }
    public string PlantType { get; set; }
    public string PlantAge { get; set; }
   
   
    public static Dictionary<string, int> CareStats;
    public PlantMakeup(string plantName, string plantType, string plantAge)
    {
      PlantName = plantName;
      PlantType = plantType;
      PlantAge = plantAge;
      CareStats =  new Dictionary<string, int>();
      CareStats.Add("water", 0);
      CareStats.Add("sun", 0);
      CareStats.Add("feed", 0);
      CareStats.Add("weed", 0);
      CareStats.Add("health", 10);
    }
      
    public static string WaterPlant()
    {
      
      CareStats["water"] ++;
      CareStats["health"] ++;
      return "Your plant has been watered!" + " " + CareStats["water"];
    }
    public static string FeedPlant()
    {
      CareStats["feed"] ++;
      CareStats["health"] ++;
      return "Your plant has been feed a fly! " + CareStats["feed"];
    }
    public static string SunPlant()
    {
      CareStats["sun"] ++;
      CareStats["health"] ++;
      return "Your plant has felt the warmth of the sun! " + CareStats["sun"];
    }
    public static string WeedPlant()
    {
      CareStats["weed"] ++;
      CareStats["health"] ++;
      return "Your plant has gotten a haircut! " + CareStats["weed"];
    }
    public static string ReadPlant()
    {
      CareStats["health"] --;
      return "Your took a break and read. It was relaxing. ";
    }

    
    // public Dictionary<int, string> careStats = new Dictionary<int, string>();
    // careStats.Add(0, "water");
    // careStats.Add(0, "sun");
    // careStats.Add(0, "feed");
    // careStats.Add(0, "weed");



  }
}

// different types of plants require different types of care?
// seed -> seedling -> teen plant (growth stage) -> vegetative state -> flowering stage -> reproduction stage -> regeneration stage
// 1 water 1 sun, *name* is now a seedling! -> 2 water 2 sun 1 weed, *name* is now a young *plant*! -> 3 water 3 sun 2 weed 1 feed, *name* is now growing more! ->  4 water 3 sun 2 weed 2 feed, *name* is now flowering! -> 4 water 4 sun 3 weed 3 feed, *name* is now producing pollen! -> 4 water 4 sun 4 weed 4 feed, *name* is now producing seeds!
// 7 stages
// define each age parameter
// each stage will wait until variables meet parameters
// have counters for parameters that reset every time it grows
// {[water, 0], [sun, 2], [weed, 1], [feed, 2]}
