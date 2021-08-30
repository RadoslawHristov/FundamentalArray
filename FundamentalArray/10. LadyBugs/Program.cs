using System;
using System.Linq;

namespace _10._LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldcapasity = int.Parse(Console.ReadLine());
            bool[] fielsize = new bool[fieldcapasity];
            int[] indexposition = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            foreach (var VARIABLE in indexposition)
            {
                if (VARIABLE < 0 || VARIABLE >= fielsize.Length )
                {
                    continue;
                }
                fielsize[VARIABLE] = true;
            }
            

            while (true)
            {
                string line = Console.ReadLine();
                if (line=="end")
                {
                    break;
                }
                string[] readcomand = line.Split();


               int startIndex =int.Parse(readcomand[0]);
                string where = readcomand[1];
                int targetindex = int.Parse(readcomand[2]);
                if (startIndex < 0 || startIndex >= fielsize.Length || !fielsize[startIndex])
                {
                    continue;
                }
                fielsize[startIndex] = false;
                while (true)
                {
                    if (where=="right")
                    {
                        startIndex += targetindex;
                    }
                    else
                    {
                        startIndex-= targetindex;
                    }
                    
                    if (startIndex >= fielsize.Length || startIndex < 0)
                    {
                        break;
                    }

                    if (!fielsize[startIndex])
                    {
                        fielsize[startIndex] = true;
                        break;
                    }
                }
            }
            foreach (var VARIABLE in fielsize)
            {
                if (VARIABLE == true)
                {
                    Console.Write("1 ");
                }
                else
                {
                    Console.Write("0 ");
                }
            }
        }
    }
}