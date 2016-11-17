using System;
using System.Collections.Generic;
using System.Linq;

namespace P08PokemonTrainer
{
    public class Trainer
    {
        //name, number of badges and a collection of pokemon
        public string name;
        public int badgesCount;
        public List<Pokemon> pokemons;

        public Trainer(string name, int badgesCount, List<Pokemon> pokemons)
        {
            this.name = name;
            this.badgesCount = badgesCount;
            this.pokemons = new List<Pokemon>();
        }

        public void IncreaseBadges()
        {
            badgesCount++;
        }

        public void RemovePokemon(Pokemon pokemon)
        {
            this.pokemons.Remove(pokemon);
        }

        public bool CheckElement(string element)
        {

            foreach (var pokemon in pokemons)
            {
                if (pokemon.element == element)
                {
                    return true;
                }
            }

            return false;
        }
    }

    public class Pokemon
    {
        //a name, an element and health
        public string name;
        public string element;
        private int health;

        public Pokemon(string name, string element, int health)
        {
            this.name = name;
            this.element = element;
            this.health = health;
        }

        public void DecreaseHealth()
        {
            this.health -= 10;
        }

        public int Health
        {
            get
            {
                return this.health;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

            while (input != "Tournament")
            {
                string[] pokemonDetails = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string trainerName = pokemonDetails[0];
                string pokemonName = pokemonDetails[1];
                string pokemonElement = pokemonDetails[2];
                int pokemonHealth = int.Parse(pokemonDetails[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if (!trainers.ContainsKey(trainerName))
                {
                    Trainer trainer = new Trainer(trainerName, 0, new List<Pokemon>());
                    trainers[trainerName] = trainer;
                    trainer.pokemons.Add(pokemon);
                }
                else
                {
                    trainers[trainerName].pokemons.Add(pokemon);
                }

                input = Console.ReadLine();
            }

            string elementCommand = Console.ReadLine();

            while (elementCommand != "End")
            {
                PlayTournament(trainers, elementCommand);

                elementCommand = Console.ReadLine();
            }

            var sortedTrainers = trainers.Values.OrderByDescending(t => t.badgesCount);

            foreach (var trainer in sortedTrainers)
            {
                Console.WriteLine($"{trainer.name} {trainer.badgesCount} {trainer.pokemons.Count}");
            }
        }

        private static void PlayTournament(Dictionary<string, Trainer> trainers, string element)
        {
            foreach (var trainer in trainers)
            {
                if (trainer.Value.CheckElement(element))
                {
                    trainer.Value.IncreaseBadges();
                }
                else
                {
                    for (int i = 0; i < trainer.Value.pokemons.Count; i++)
                    {
                        trainer.Value.pokemons[i].DecreaseHealth();
                        if (trainer.Value.pokemons[i].Health<=0)
                        {
                            trainer.Value.RemovePokemon(trainer.Value.pokemons[i]);
                        }
                    }
                }
            }
        }
    }
}
