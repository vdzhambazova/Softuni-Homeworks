using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gringotts
{
    class Program
    {
        static void Main(string[] args)
        {
            GringottsContext gringottsContext = new GringottsContext();
            using (gringottsContext)
            {
                var uniqueWizzardNames = gringottsContext.
            }
        }
    }
}
