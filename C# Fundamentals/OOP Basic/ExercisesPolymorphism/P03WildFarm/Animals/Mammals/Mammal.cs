namespace P03WildFarm.Animals.Mammals
{
    public abstract class Mammal : Animal
    {
        //private string livingRegion;

        protected Mammal(string animalType, string animalName, double animalWeight, string livingRegion)
            : base(animalType, animalName, animalWeight)
        {
            this.LivingRegion = livingRegion;
        }

        public string LivingRegion { get; }

        public override string ToString()
        {
            return base.ToString() + $" {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
