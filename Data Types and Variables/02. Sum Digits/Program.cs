using System;

namespace _02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int inputCopy = int.Parse(input);
            int inputCopyTwo = inputCopy;
            int result = 0;

            for (int i = 0; i <= input.Length; i++)
            {
                inputCopyTwo %= 10;
                result += inputCopyTwo;
                inputCopy /= 10;
                inputCopyTwo = inputCopy;
            }

            Console.WriteLine(result);
        }
    }
}
