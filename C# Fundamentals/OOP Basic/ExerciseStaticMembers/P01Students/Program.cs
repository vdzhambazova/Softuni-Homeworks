using System;
using System.Runtime.CompilerServices;

class Program
{
    public class Student
    {
        private string name;
        private static int studentsCount = 0;

        public static int StudentCounter { get { return Student.studentsCount; } }

        public string Name { get; set; }

        public Student(string name)
        {
            this.Name = name;
            Student.studentsCount++;
        }
    }

    static void Main()
    {
        string input = Console.ReadLine();

        while (input != "End")
        {
            Student student = new Student(input);

            input = Console.ReadLine();
        }

        Console.WriteLine(Student.StudentCounter);
    }
}

