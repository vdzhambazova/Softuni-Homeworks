using System;
using System.IO;

namespace ExcerciseFilesAndDirectories
{
    public class Startup
    {
        static void Main(string[] args)
        {
            File.WriteAllText("renamedNumbers.txt","Napisan tekst");

            var text = File.ReadAllLines("renamedNumbers.txt");

            foreach (var line in text)
            {
                Console.WriteLine(line);
            }

        }
    }
}
