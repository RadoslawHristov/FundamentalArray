using System;
using System.Linq;

namespace _05._Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sumEven = 0;

            for (int i = 0; i < number.Length; i++)
            {
                int curennumber =number [i];
                if (curennumber % 2 == 0)
                {
                    sumEven += curennumber;
                }
            }

            Console.WriteLine(sumEven);
        }
    }
}
