using System;

namespace _01._Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            if (input <= 2)
            {
                Console.WriteLine("baby");
            }

            else if (input <= 13)
            {
                Console.WriteLine("child");
            }

            else if (input <= 19)
            {
                Console.WriteLine("teenager");
            }

            else if (input <= 65)
            {
                Console.WriteLine("adult");
            }

            else if (input >= 66)
            {
                Console.WriteLine("elder");
            }
        }
    }
}
