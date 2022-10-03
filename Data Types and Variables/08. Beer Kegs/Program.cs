using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numLines = int.Parse(Console.ReadLine());

            string model = string.Empty;
            double radius = 0;
            int height = 0;
            double volume = 0;

            double biggestVol = double.MinValue;
            string printModel = string.Empty;

            for (int i = 1; i <= numLines; i++)
            {
                model = Console.ReadLine();
                radius = double.Parse(Console.ReadLine());
                height = int.Parse(Console.ReadLine());

                volume = Math.PI * radius * radius * height;

                if (volume > biggestVol)
                {
                    biggestVol = volume;
                    printModel = model;
                }
            }

            Console.WriteLine(printModel);
        }
    }
}
