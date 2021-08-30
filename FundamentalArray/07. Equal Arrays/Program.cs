using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] arr2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int firstarrSum = 0;
            int twoarrSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                firstarrSum += arr[i];
                if (arr[i] != arr2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                twoarrSum += arr2[i];
            }

            if (firstarrSum == twoarrSum)
            {
                Console.WriteLine($"Arrays are identical. Sum: {firstarrSum} ");
            }
        }
    }
}
