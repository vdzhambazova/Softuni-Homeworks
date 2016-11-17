using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05ComparingObjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Person> people = new List<Person>();

            while (input != "END")
            {
                string[] personDetails = input.Split();
                Person person = new Person(personDetails[0], int.Parse(personDetails[1]), personDetails[2]);
                people.Add(person);

                input = Console.ReadLine();
            }

            int personPosition = int.Parse(Console.ReadLine()) - 1;

            int numberOfEqualPeople = 0;
            int numberOfNotEqualPeople = 0;
            int totalNumberOfPeople = 0;

            foreach (var person in people)
            {
                if (person.CompareTo(people[personPosition]) == 0)
                {
                    numberOfEqualPeople++;
                }
                else
                {
                    numberOfNotEqualPeople++;
                }

                totalNumberOfPeople++;
            }

            if (numberOfEqualPeople==0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{numberOfEqualPeople} {numberOfNotEqualPeople} {totalNumberOfPeople}");
            }
            
        }
    }
}
