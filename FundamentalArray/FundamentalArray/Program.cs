using System;

namespace FundamentalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            string[] dayOfweek = new[]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            if (day > dayOfweek.Length || day <= 0)
            {
                Console.WriteLine("Invalid day!");
                return;
            }
            Console.WriteLine(dayOfweek[day-1]);
        }
    }
}
