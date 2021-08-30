using System;
using System.Linq;
using System.Threading;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] digits = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int magicnumber = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                int curen = digits[i];
                for (int j = i+1; j < digits.Length; j++)
                {
                    int curentnumber = digits[j];
                    if (curen + curentnumber == magicnumber)
                    {
                        Console.WriteLine($"{curen} {curentnumber}");
                        break;
                    }

                }
            }

        }
    }
}
