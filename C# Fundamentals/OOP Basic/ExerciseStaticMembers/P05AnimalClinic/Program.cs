using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class Program
{
    public class Animal
    {
        private string name;
        private string breed;

        public Animal(string name, string breed)
        {
            this.Name = name;
            this.Breed = breed;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Breed
        {
            get { return this.breed; }
            set { this.breed = value; }
        }
    }

    public class AnimalClinic
    {
        public static int patientId = 1;
        public static int healedAnimalsCount;
        public static int rehabilitatedAnimalsCount;
        public static List<Animal> healedAnimals;
        public static List<Animal> rehabilitatedAnimals;
        public static Dictionary<Animal, int> animals;

        static AnimalClinic()
        {
            AnimalClinic.healedAnimals = new List<Animal>();
            AnimalClinic.rehabilitatedAnimals = new List<Animal>();
            AnimalClinic.animals = new Dictionary<Animal, int>();
        }

        public static void HealAnimal(Animal animal)
        {
            AnimalClinic.healedAnimalsCount++;
            AnimalClinic.healedAnimals.Add(animal);
        }

        public static void RehabilitateAnimal(Animal animal)
        {
            AnimalClinic.rehabilitatedAnimalsCount++;
            AnimalClinic.rehabilitatedAnimals.Add(animal);
        }

        public static void AddAnimal(Animal animal)
        {
            AnimalClinic.animals[animal] = patientId;
            patientId++;
        }

    }

    public static void Main()
    {
        string input = Console.ReadLine();

        while (input != "End")
        {
            string[] animalDetails = input.Split();

            string animalName = animalDetails[0];
            string animalBreed = animalDetails[1];
            string state = animalDetails[2];

            Animal animal = new Animal(animalName, animalBreed);

            AnimalClinic.AddAnimal(animal);

            if (state == "heal")
            {
                AnimalClinic.HealAnimal(animal);
            }
            else
            {
                AnimalClinic.RehabilitateAnimal(animal);
            }

            input = Console.ReadLine();
        }

        foreach (var animal in AnimalClinic.animals)
        {
            if (AnimalClinic.healedAnimals.Contains(animal.Key))
            {
                Console.WriteLine($"Patient {animal.Value}: [{animal.Key.Name} ({animal.Key.Breed})] has been healed!");
            }
            else
            {
                Console.WriteLine($"Patient {animal.Value}: [{animal.Key.Name} ({animal.Key.Breed})] has been rehabilitated!");
            }

        }

        Console.WriteLine($"Total healed animals: {AnimalClinic.healedAnimals.Count}");
        Console.WriteLine($"Total rehabilitated animals: {AnimalClinic.rehabilitatedAnimals.Count}");

        string command = Console.ReadLine();

        if (command == "heal")
        {
            foreach (var healedAnimal in AnimalClinic.healedAnimals)
            {
                Console.WriteLine($"{healedAnimal.Name} {healedAnimal.Breed}");
            }
        }
        else
        {
            foreach (var rehabilitatedAnimal in AnimalClinic.rehabilitatedAnimals)
            {
                Console.WriteLine($"{rehabilitatedAnimal.Name} {rehabilitatedAnimal.Breed}");
            }
        }
    }
}

