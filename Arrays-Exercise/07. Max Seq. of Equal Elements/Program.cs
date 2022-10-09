using System;
using System.Linq;

namespace _07._Max_Seq._of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int counter = 0;
            int maxCounter = 0;
            int printNum = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                int currNum = numbers[i];

                if (numbers[i-1] == numbers[i])
                {
                    counter++;

                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        printNum = currNum;
                    }
                }
                else
                {
                    counter = 0;
                }
            }

            for (int p = 1; p <= maxCounter + 1; p++)
            { 
                Console.Write($"{printNum} ");
            }
        }
    }
}
