namespace PlantInfo
{
  public class PlantMakeup
  {
    public string PlantName {get; set; }
    public string PlantType {get; set; }
    public string PlantAge {get; set; }

    public PlantCare(string plantName, string plantType, string plantAge)
    {
      PlantName = plantName;
      PlantType = plantType;
      PlantAge = plantAge;
    }
    
  }
}
// different types of plants require different types of care?
// seed -> seedling -> teen plant (growth stage) -> vegetative state -> flowering stage -> reproduction stage -> regeneration stage