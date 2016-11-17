using System;
using System.Collections.Generic;
using System.Linq;
using P06BirthdayCelebrations.Interfaces;
using P06BirthdayCelebrations.Models;

namespace P06BirthdayCelebrations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IBirthable> birthables = new List<IBirthable>();
            string entrants = Console.ReadLine();

            while (entrants != "End")
            {
                string[] entrantDetails = entrants.Split();

                switch (entrantDetails[0])
                {
                    case "Citizen":
                        Citizen citizen =
                            new Citizen(entrantDetails[1], int.Parse(entrantDetails[2]),
                        entrantDetails[3], entrantDetails[4]);
                        birthables.Add(citizen);
                        break;
                    case "Pet":
                        Pet pet =
                            new Pet(entrantDetails[1], entrantDetails[2]);
                        birthables.Add(pet);
                        break;
                }

                entrants = Console.ReadLine();
            }

            string birthyear = Console.ReadLine();

            var chosenOnes = birthables.Where(i => i.BirthDate.EndsWith(birthyear)).ToList();

            Console.WriteLine(string.Join(Environment.NewLine, chosenOnes));
        }
    }
}
