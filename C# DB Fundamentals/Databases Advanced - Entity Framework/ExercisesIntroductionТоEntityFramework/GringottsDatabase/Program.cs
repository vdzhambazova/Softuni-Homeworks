using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GringottsDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            using (context)
            {
                var uniqueLetters =
                    context.WizzardDeposits
                    .Where(wd => wd.DepositGroup == "Troll Chest")
                    .Select(wd => wd.FirstName.Substring(0, 1))
                    .Distinct()
                    .OrderBy(wd=>wd);

                foreach (var uniqueLetter in uniqueLetters)
                {
                    Console.WriteLine(uniqueLetter);
                }
            }
        }
    }
}
