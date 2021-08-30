using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string[] revers = text.Split(' ');

            for (int i = revers.Length - 1; i >= 0; i--)
            {
                string rev = revers[i];
                Console.Write(rev + " ");
            }
        }

    }
}
