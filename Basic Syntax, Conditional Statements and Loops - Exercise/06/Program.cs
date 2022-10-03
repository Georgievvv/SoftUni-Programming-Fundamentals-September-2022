using System;

namespace _06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int inputCopy = input;
            int factorialSum = 0;

            while (inputCopy > 0)
            {
                int lastDigit = inputCopy % 10;
                inputCopy /= 10;

                int factorial = 1;

                for (int i = 1; i <= lastDigit; i++)
                {
                    factorial *= i;
                }

                factorialSum += factorial; 
            }

            if (factorialSum == input)
            {
                Console.WriteLine("yes");
            }

            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
