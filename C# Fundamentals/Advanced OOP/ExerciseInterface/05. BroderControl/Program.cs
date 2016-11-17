using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BroderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IIdentifiable> identifiables = new List<IIdentifiable>();
            string entrants = Console.ReadLine();

            while (entrants != "End")
            {
                string[] entrantDetails = entrants.Split();

                if (entrantDetails.Length > 2)
                {
                    Citizen citizen = 
                        new Citizen(entrantDetails[0], int.Parse(entrantDetails[1]), entrantDetails[2]);
                    identifiables.Add(citizen);
                }
                else
                {
                    Robot robot = new Robot(entrantDetails[0], entrantDetails[1]);
                    identifiables.Add(robot);
                }
                entrants = Console.ReadLine();
            }

            string fakeIds = Console.ReadLine();

            var detrained = identifiables.Where(i=>i.Id.EndsWith(fakeIds)).ToList();

            Console.WriteLine(string.Join(Environment.NewLine, detrained));
        }
    }
}
