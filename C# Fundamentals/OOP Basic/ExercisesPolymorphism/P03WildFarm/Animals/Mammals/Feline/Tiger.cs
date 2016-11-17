namespace P03WildFarm.Animals.Mammals.Feline
{
    using System;
    using Food;

    public class Tiger : Feline
    {
        public Tiger(string animalType, string animalName, double animalWeight, string livingRegion) 
            : base(animalType, animalName, animalWeight, livingRegion)
        {
        }

        public override void AddFood(Food food)
        {
            if (food is Vegetable)
            {
                throw new InvalidOperationException($"{this.AnimalType}s are not eating that type of food!");
            }

            base.AddFood(food);
        }

        public override void MakeSound()
        {
            Console.WriteLine("ROAAR!!!");
        }
    }
}
