using System;

namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();

            double SumForOnePerson = 0;

            if (groupType == "Students")
            {
                if (dayOfTheWeek == "Friday")
                {
                    SumForOnePerson += 8.45;
                }

                else if (dayOfTheWeek == "Saturday")
                {
                    SumForOnePerson += 9.80;
                }

                else if (dayOfTheWeek == "Sunday")
                { 
                    SumForOnePerson += 10.46;
                }

                if (people >= 30)
                {
                    SumForOnePerson *= 0.85;
                }
            }

            else if (groupType == "Business")
            {
                if (dayOfTheWeek == "Friday")
                {
                    SumForOnePerson += 10.90;
                }

                else if (dayOfTheWeek == "Saturday")
                {
                    SumForOnePerson += 15.60;
                }

                else if (dayOfTheWeek == "Sunday")
                {
                    SumForOnePerson += 16;
                }

                if (people >= 100)
                {
                    people -= 10;
                }
            }

            else if (groupType == "Regular")
            {
                if (dayOfTheWeek == "Friday")
                {
                    SumForOnePerson += 15;
                }

                else if (dayOfTheWeek == "Saturday")
                {
                    SumForOnePerson += 20;
                }

                else if (dayOfTheWeek == "Sunday")
                {
                    SumForOnePerson += 22.50;
                }

                if (people >= 10 && people <= 20)
                {
                    SumForOnePerson *= 0.95;
                }
            }

            double totalPrice = SumForOnePerson * people;

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
