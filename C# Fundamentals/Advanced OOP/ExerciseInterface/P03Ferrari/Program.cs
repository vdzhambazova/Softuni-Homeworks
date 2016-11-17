using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03Ferrari
{
    public class Ferrari : IDrivable
    {
        public static string Model = "488-Spider";

        public Ferrari(string driverName)
        {
            DriverName = driverName;
        }

        public string DriverName { get; set; }

        public string UseBrakes()
        {
            return "Brakes!";
        }

        public string PushTheGasPedal()
        {
            return "Zadu6avam sA!";
        }

        public override string ToString()
        {
            return $"{Ferrari.Model}/{this.UseBrakes()}/{this.PushTheGasPedal()}/{this.DriverName}";
        }
    }

    public interface IDrivable
    {
        string DriverName { get; set; }

        string UseBrakes();

        string PushTheGasPedal();
    }

    public class Program
    {
        static void Main(string[] args)
        {
            string driverName = Console.ReadLine();

            IDrivable ferrari = new Ferrari(driverName);

            Console.WriteLine(ferrari);
        }
    }
}
