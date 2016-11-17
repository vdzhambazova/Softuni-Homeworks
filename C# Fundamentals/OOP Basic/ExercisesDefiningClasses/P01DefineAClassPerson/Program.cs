﻿namespace P01DefineAClassPerson
{
    using System;
    using System.Reflection;

    public class Program
    {
        public static void Main(string[] args)
        {
            Type personType = typeof(Person);
            ConstructorInfo emptyCtor = personType.GetConstructor(new Type[] { });
            ConstructorInfo ageCtor = personType.GetConstructor(new[] { typeof(int) });
            ConstructorInfo nameAgeCtor = personType.GetConstructor(new[] { typeof(string), typeof(int) });
            bool swapped = false;
            if (nameAgeCtor == null)
            {
                nameAgeCtor = personType.GetConstructor(new[] { typeof(int), typeof(string) });
                swapped = true;
            }

            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Person basePerson = (Person)emptyCtor.Invoke(new object[] { });
            Person personWithAge = (Person)ageCtor.Invoke(new object[] { age });
            Person personWithAgeAndName = swapped ? (Person)nameAgeCtor.Invoke(new object[] { age, name }) : (Person)nameAgeCtor.Invoke(new object[] { name, age });

            Console.WriteLine("{0} {1}", basePerson.name, basePerson.age);
            Console.WriteLine("{0} {1}", personWithAge.name, personWithAge.age);
            Console.WriteLine("{0} {1}", personWithAgeAndName.name, personWithAgeAndName.age);


            //Instances

            Person pesho = new Person("Pesho", 23);
            Person gosho = new Person
            {
                name = "Gosho",
                age = 40
            };

            Person pesho2 = new Person("Pesho", 20);
        }
    }

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
}
