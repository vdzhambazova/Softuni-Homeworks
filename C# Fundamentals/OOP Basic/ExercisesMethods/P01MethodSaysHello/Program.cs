using System;
using System.Reflection;

public class Program
{
    public class Person
    {
        private string name;

        public Person(string name)
        {
            this.name = name;
        }

        public string Name => this.name;

        public string SayHello()
        {
            string greeting = $"{this.Name} says \"Hello\"!";

            return greeting;
        }
    }

    public static void Main()
    {
        Type personType = typeof(Person);
        FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
        MethodInfo[] methods = personType.GetMethods(BindingFlags.Public | BindingFlags.Instance);

        //if (fields.Length != 1 || methods.Length != 5)
        //{
        //    throw new Exception();
        //}

        string personName = Console.ReadLine();
        Person person = new Person(personName);

        Console.WriteLine(person.SayHello());

    }
}

