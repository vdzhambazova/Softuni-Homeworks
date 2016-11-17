using System;

namespace P03WildFarm.Animals.Mammals.Feline
{
    public class Cat : Feline
    {
        //private string breed;

        public Cat( string animalType, string animalName, double animalWeight, string livingRegion, string breed) 
            : base(animalType, animalName, animalWeight, livingRegion)
        {
            this.Breed = breed;
        }

        public string Breed { get; }

        public override void MakeSound()
        {
            Console.WriteLine("Meowwww");
        }

        public override string ToString()
        {
            return
                $"{this.AnimalType}[{this.AnimalName}, {this.Breed}," +
                $" {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
