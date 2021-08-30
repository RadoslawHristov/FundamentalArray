using System;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeDna = int.Parse(Console.ReadLine());
            int besstiquenc = 0;
            int bestsiquensStarting = 0;
            int bestsum = 0;
            int[] bestsiquens = new int[sizeDna];

            int bestSample = 1;
            int sample = 0;
            while (true)
            {
                string line = Console.ReadLine();
                sample += 1;
                if (line == "Clone them!")
                {
                    break;
                }

                int[] siquens = line.Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int siqueSum = 0;
                foreach (var item in siquens)
                {
                    siqueSum += item;
                }

                for (int i = 0; i < siquens.Length; i++)
                {
                    int siqueni = siquens[i];
                    if (siqueni == 0)
                    {
                        continue;
                    }

                    int curentSize = 1;
                    for (int j = i + 1; j < siquens.Length; j++)
                    {

                        if (siqueni == siquens[j])
                        {
                            curentSize += 1;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (curentSize > besstiquenc)
                    {
                        besstiquenc = curentSize;
                        bestsiquensStarting = i;
                        bestsum = siqueSum;
                        bestsiquens = siquens;
                        bestSample = sample;
                    }
                    else if (curentSize == besstiquenc)
                    {
                        if (i < bestsiquensStarting)
                        {
                            besstiquenc = curentSize;
                            bestsiquensStarting = i;
                            bestsum = siqueSum;
                            bestsiquens = siquens;
                            bestSample = sample;
                        }
                        else if (i == bestsiquensStarting && siqueSum > bestsum)
                        {
                            besstiquenc = curentSize;
                            bestsiquensStarting = i;
                            bestsum = siqueSum;
                            bestsiquens = siquens;
                            bestSample = sample;
                        }
                    }
                }
            }
            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestsum}.");
            Console.WriteLine(string.Join(" ", bestsiquens));
        }
    }
}
