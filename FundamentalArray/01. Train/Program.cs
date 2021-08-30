using System;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfWagon = int.Parse(Console.ReadLine());

            int sumPeople = 0;
            int[] wagons = new int[numOfWagon];
            for (int i = 0; i < numOfWagon; i++)
            {
                int wagon = int.Parse(Console.ReadLine());
                wagons[i] = wagon;
                sumPeople += wagon;
            }

            foreach (int element in wagons)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine();
            Console.WriteLine(sumPeople);
        }
    }
}
