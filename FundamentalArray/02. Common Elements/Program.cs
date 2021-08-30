using System;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine()
                .Split();
            string[] input2 = Console.ReadLine()
                .Split();
             string result=String.Empty;
             for (int i = 0; i < input1.Length; i++)
            {
                for (int j = 0; j < input2.Length; j++)
                {
                    if (input1[i]==input2[j])
                    {
                        result +=((input1[i]) + " ");
                    }
                }
            }

            Console.WriteLine(result + " ");
        }
    }
}
