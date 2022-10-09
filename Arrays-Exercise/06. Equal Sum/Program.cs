using System;
using System.Linq;

namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int leftSum = 0;
            int rightSum = 0;
            bool flag = true;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currNum = numbers[i];

                for (int l = 0; l <= i - 1; l++)
                {
                    leftSum += numbers[l];
                }

                for (int r = i + 1; r < numbers.Length; r++)
                {
                    rightSum += numbers[r];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    flag = false;
                    return;
                }
                else
                {
                    leftSum = 0;
                    rightSum = 0;
                }
            }

            if (flag)
            {
                Console.WriteLine("no");
            }
        }
    }
}
