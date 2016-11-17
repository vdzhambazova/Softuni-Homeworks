using System;
using System.Collections.Generic;
using System.Reflection;

public class Program
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name => this.name;
        public int Age => this.age;
    }

    public class Family
    {
        private List<Person> familyMembers;

        public Family()
        {
            this.familyMembers = new List<Person>();
        }

        public List<Person> FamilyMembers => this.familyMembers;

        public void AddMember(Person member)
        {
            this.FamilyMembers.Add(member);
        }

        public Person GetOldestMember()
        {
            int maxAge = Int32.MinValue;
            Person oldestPerson = null;
            foreach (var familyMember in FamilyMembers)
            {
                if (familyMember.Age > maxAge)
                {
                    maxAge = familyMember.Age;
                    oldestPerson = familyMember;
                }
            }

            return oldestPerson;
        }
    }

    public static void Main()
    {
        MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
        MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
        if (oldestMemberMethod == null || addMemberMethod == null)
        {
            throw new Exception();
        }

        int numOfInput = int.Parse(Console.ReadLine());
        Family family = new Family();

        for (int i = 0; i < numOfInput; i++)
        {
            string[] memberDetails = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Person person = new Person(memberDetails[0], int.Parse(memberDetails[1]));

            family.AddMember(person);
        }

        Person oldestPerson = family.GetOldestMember();

        Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
    }
}

