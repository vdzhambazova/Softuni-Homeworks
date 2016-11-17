namespace P03OpinionPoll
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public class Person
        {
            public string name;
            public int age;

            public Person()
                : this("No name", 1)
            {
            }

            public Person(int age)
                : this("No name", age)
            {
            }

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }
        static void Main(string[] args)
        {
            int numberOfInput = int.Parse(Console.ReadLine());
            List<Person> peopleOver30 = new List<Person>();
            for (int i = 0; i < numberOfInput; i++)
            {
                string[] inputArgs = Console.ReadLine().Split();
                string name = inputArgs[0];
                int age = int.Parse(inputArgs[1]);

                Person person = new Person(name, age);

                if (person.age > 30)
                {
                    peopleOver30.Add(person);
                }

            }

            peopleOver30 = peopleOver30.OrderBy(p => p.name).ToList();

            foreach (var person in peopleOver30)
            {
                Console.WriteLine("{0} - {1}", person.name, person.age);
            }
        }
    }
}
