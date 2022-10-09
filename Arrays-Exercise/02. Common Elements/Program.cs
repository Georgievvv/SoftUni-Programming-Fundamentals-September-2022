using System;

namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstRow = Console.ReadLine().Split(" ");
            string[] secondRow = Console.ReadLine().Split(" ");

            for (int i = 0; i < firstRow.Length; i++)
            {
                for (int j = 0; j < secondRow.Length; j++)
                {
                    if (firstRow[i] == secondRow[j])
                    {
                        Console.Write($"{firstRow[i]}");
                        Console.Write(" ");
                    }
                }
            }
        }
    }
}
