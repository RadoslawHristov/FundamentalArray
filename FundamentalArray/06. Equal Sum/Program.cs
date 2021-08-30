using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            bool ismidlle = false;
            if (array.Length < 1)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = 0; i < array.Length; i++)
            {
                int leftSum = 0;
                for (int j = i-1; j >= 0; j--)
                {
                    leftSum += array[j];
                }

                int rightSum = 0;
                for (int k = i + 1; k < array.Length; k++)
                {
                    rightSum += array[k];
                }

                if (leftSum == rightSum)
                {
                    ismidlle = true;
                    Console.WriteLine(i);
                    break;
                }
                
            }

            if (ismidlle !=true)
            {
                Console.WriteLine("no");
            }
            

        }
    }
}
