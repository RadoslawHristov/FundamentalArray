using System;
using System.Globalization;
using System.Linq;

namespace _04._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] firstdig = new int[num.Length / 2];
            int[] second = new int[num.Length / 2];

            int size = num.Length / 4;
            int lastIndex = num.Length - 1;

            for (int j = 0; j < firstdig.Length; j++)
            {
                if (j < firstdig.Length / 2)
                {
                    firstdig[j] = num[size - 1 - j];
                }
                else
                {
                    firstdig[j] = num[lastIndex];
                    lastIndex--;
                }
                
            }

            for (int i = 0; i < second.Length; i++)
            {
                second[i] = num[size + i];
            }

            for (int i = 0; i < firstdig.Length; i++)
            {
                int result = firstdig[i] + second[i];
                Console.Write(result + " ");
            }
        }
    }
}
