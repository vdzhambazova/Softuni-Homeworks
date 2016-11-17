using System;
using System.Collections.Generic;

public class Program
{


    public class Student
    {
        private string name;
        private static HashSet<Student> students;

        static Student()
        {
            Student.Students = new HashSet<Student>();
        }

        public Student(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public static HashSet<Student> Students { get; set; } 

        public static int StudenstCount
        {
            get { return Student.Students.Count; }
        }

        public override bool Equals(object other)
        {
            return this.GetHashCode().Equals(other.GetHashCode());
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
    }

    public static void Main()
    {
        string input = Console.ReadLine();

        while (input != "End")
        {
            Student student = new Student(input);
            Student.Students.Add(student);
            input = Console.ReadLine();
        }

        Console.WriteLine(Student.StudenstCount);
    }
}

