namespace P03WildFarm.Animals.Mammals.Feline
{
    public abstract class Feline : Mammal
    {
        public Feline(string animalType, string animalName, double animalWeight, string livingRegion) 
            : base(animalType, animalName, animalWeight, livingRegion)
        {
        }
    }
}
