using System;

namespace _08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int row = 1; row <= input; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write($"{row} ");
                }

                Console.WriteLine();
            }
        }
    }
}
