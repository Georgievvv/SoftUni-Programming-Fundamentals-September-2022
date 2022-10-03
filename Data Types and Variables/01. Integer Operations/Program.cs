using System;

namespace _01._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());
            int numFour = int.Parse(Console.ReadLine());

            long result = ((long)numOne + numTwo) / numThree * numFour;

            Console.WriteLine(result);
        }
    }
}
