namespace P03WildFarm.Animals.Mammals
{ 

    using System;
    using Food;

    public class Zebra: Mammal
    {
        public Zebra(string animalType, string animalName, double animalWeight, string livingRegion) 
            : base(animalType, animalName, animalWeight, livingRegion)
        {
        }

        public override void AddFood(Food food)
        {
            if (food is Meat)
            {
                throw new InvalidOperationException($"{this.AnimalType}s are not eating that type of food!");
            }

            base.AddFood(food);
        }

        public override void MakeSound()
        {
            Console.WriteLine("Zs");
        }
    }
}
