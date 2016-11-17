using System;

namespace P03WildFarm.Animals.Mammals
{
    using Food;

    public abstract class Animal
    {
        //private string animalName;
        //private string animalType;
        //private double animalWeight;
        //private int foodEaten;

        protected Animal(string animalType, string animalName, double animalWeight)
        {
            this.AnimalType = animalType;
            this.AnimalName = animalName;
            this.AnimalWeight = animalWeight;
            this.FoodEaten = 0;
        }

        public int FoodEaten { get; private set; }

        public double AnimalWeight { get; }

        public string AnimalType { get; }

        public string AnimalName { get; }

        public virtual void AddFood(Food food)
        {
            this.FoodEaten += food.Quantity;
        }

        public abstract void MakeSound();

        public override string ToString()
        {
            return $"{this.AnimalType}[{AnimalName}, {AnimalWeight},";
        }
    }
}
