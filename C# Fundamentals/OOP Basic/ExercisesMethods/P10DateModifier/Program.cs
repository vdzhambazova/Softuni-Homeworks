using System;
using System.Globalization;

namespace P10DateModifier
{
    public class DateModifier
    {
        //private DateTime firstDate;
        //private DateTime secondDate;

        public DateModifier(DateTime firstDate, DateTime secondDate)
        {
            this.FirstDate = firstDate;
            this.SecondDate = secondDate;
        }

        public DateTime SecondDate { get; set; }

        public DateTime FirstDate { get; set; }

        public double CalculateDifferenceBetweenDates()
        {
            double difference = Math.Abs((this.FirstDate - this.SecondDate).TotalDays);

            return difference;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DateTime firstDate = DateTime.Parse(Console.ReadLine().Trim(),
            CultureInfo.InvariantCulture);
            DateTime secondDate = DateTime.Parse(Console.ReadLine().Trim(),
            CultureInfo.InvariantCulture);

            DateModifier dateModifier = new DateModifier(firstDate, secondDate);

            Console.WriteLine(dateModifier.CalculateDifferenceBetweenDates());
        }
    }
}
