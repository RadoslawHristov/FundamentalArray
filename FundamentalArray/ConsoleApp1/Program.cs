using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstNumber = long.Parse(Console.ReadLine());
            long secondNumber = long.Parse(Console.ReadLine());
            if (secondNumber == 0 || firstNumber == 0)
            {
                return;
            }

            Console.WriteLine($"{Result(firstNumber, secondNumber):f2}");


            static long Result(long first, long second)
            {

                long originalFirst = first;
                for (long i = first - 1; i >= 1; i--)
                {
                    originalFirst = originalFirst * i;
                }

                return originalFirst / second;
            }
        }

    }
}
