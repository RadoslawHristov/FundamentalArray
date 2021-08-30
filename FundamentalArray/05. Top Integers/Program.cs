using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] element = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
           // bool isbigger = false;
           // for (int i = 0; i < element.Length; i++)
           // {
           //     for (int j = i+1; j < element.Length; j++)
           //     {
           //         if (element[i] > element[j])
           //         {
           //             isbigger = true;
           //         }
           //         else
           //         {
           //             isbigger = false;
           //                 break;
           //         }
           //     }
           //
           //     if (i==element.Length-1)
           //     {
           //         isbigger = true;
           //     }
           //
           //     if (isbigger==true)
           //     {
           //         Console.Write(element[i] + " ");
           //     }
           // }
           //judj 100/100

           for (int i = 0; i < element.Length; i++)
           {
               int r = element[0];
               int s = element[1];
               int sum = 0;
               if (r > s)
               {
                   sum = r;
               }

               r++;
               s++;
               Console.WriteLine(sum);


           }

        }
    }
}