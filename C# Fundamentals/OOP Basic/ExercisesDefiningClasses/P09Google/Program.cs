using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace P09Google
{
    public class Program
    {
        public class Company
        {
            public string name;
            public string departament;
            public decimal salary;

            public Company(string name, string departament, decimal salary)
            {
                this.name = name;
                this.departament = departament;
                this.salary = salary;
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"{this.name} {this.departament} {this.salary:F2}");

                return sb.ToString();
            }
        }

        public class Pokemon
        {
            public string name;
            public string type;

            public Pokemon(string name, string type)
            {
                this.name = name;
                this.type = type;
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"{name} {type}");

                return sb.ToString();
            }
        }

        public class Parent
        {
            public string name;
            public string birthday;

            public Parent(string name, string birthday)
            {
                this.name = name;
                this.birthday = birthday;
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"{name} {birthday}");

                return sb.ToString();
            }
        }

        public class Child
        {
            public string name;
            public string birthday;

            public Child(string name, string birthday)
            {
                this.name = name;
                this.birthday = birthday;
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"{name} {birthday}");

                return sb.ToString();
            }
        }

        public class Car
        {
            public string model;
            public int speed;

            public Car(string model, int speed)
            {
                this.model = model;
                this.speed = speed;
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine($"{this.model} {this.speed}");

                return sb.ToString();
            }
        }

        public class Person
        {
            public string name;
            public Company company;
            public List<Pokemon> pokemons;
            public List<Parent> parents;
            public List<Child> children;
            public Car car;

            public Person(string name)
            {
                this.name = name;
                this.pokemons = new List<Pokemon>();
                this.parents = new List<Parent>();
                this.children = new List<Child>();
            }

            public Company Company
            {
                get { return this.company; }
                set { this.company = value; }
            }

            public Car Car
            {
                get { return this.car; }
                set { this.car = value; }
            }


            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine($"{name}");
                sb.AppendLine("Company:");
                if (this.Company != null)
                {
                    sb.Append(this.Company.ToString());
                }
                sb.AppendLine("Car:");
                if (this.Car != null)
                {
                    sb.Append(this.Car.ToString());
                }

                sb.AppendLine("Pokemon:");
                foreach (Pokemon pokemon in pokemons)
                {
                    sb.Append(pokemon.ToString());
                }
                sb.AppendLine("Parents:");
                if (pokemons.Count >0)
                {
                    foreach (var parent in parents)
                    {
                        sb.Append(parent.ToString());
                    }
                }
                
                sb.AppendLine("Children:");
                if (children.Count > 0)
                {
                    foreach (var child in children)
                    {
                        sb.AppendLine(child.ToString());
                    }
                }

                string result = sb.ToString();

                return result;
            }
        }

        public static void Main(string[] args)
        {
            Dictionary<string, Person> peopleDictionary = new Dictionary<string, Person>();

            string personString = Console.ReadLine();
            while (personString != "End")
            {
                string[] personDetails = personString.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string personName = personDetails[0];

                if (!peopleDictionary.ContainsKey(personName))
                {
                    Person person = new Person(personName);
                    peopleDictionary[personName] = person;
                }

                switch (personDetails[1])
                {
                    case "company":
                        Company company = new Company(personDetails[2], personDetails[3], decimal.Parse(personDetails[4]));
                        peopleDictionary[personName].Company = company;
                        break;
                    case "car":
                        Car car = new Car(personDetails[2], int.Parse(personDetails[3]));
                        peopleDictionary[personName].Car = car;
                        break;
                    case "pokemon":
                        Pokemon pokemon = new Pokemon(personDetails[2], personDetails[3]);
                        peopleDictionary[personName].pokemons.Add(pokemon);
                        break;
                    case "parents":
                        Parent parent = new Parent(personDetails[2], personDetails[3]);
                        peopleDictionary[personName].parents.Add(parent);
                        break;
                    case "children":
                        Child child = new Child(personDetails[2], personDetails[3]);
                        peopleDictionary[personName].children.Add(child);
                        break;
                }

                personString = Console.ReadLine();
            }

            string personToPrint = Console.ReadLine();

            var filteredPerson = peopleDictionary.First(x => x.Value.name == personToPrint);

            Console.WriteLine(filteredPerson.Value.ToString());
        }
    }
}
