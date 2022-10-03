using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfLines = int.Parse(Console.ReadLine());
            int input = 0;
            int sum = 0;

            for (int i = 1; i <= numOfLines; i++)
            {
                input = int.Parse(Console.ReadLine());

                if (sum + input <= 255)
                {
                    sum += input;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(sum);
        }
    }
}
