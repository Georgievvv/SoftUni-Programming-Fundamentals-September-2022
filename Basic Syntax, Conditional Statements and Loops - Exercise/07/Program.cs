using System;

namespace _07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            double sumMoney = 0;

            while ((input = Console.ReadLine()) != "Start")
            {
                double coin = double.Parse(input);

                if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2)
                {
                    sumMoney += coin;
                }

                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
            }

            string product = string.Empty;

            while ((product = Console.ReadLine()) != "End")
            {
                switch (product)
                {
                    case "Nuts":
                        if (sumMoney - 2 >= 0)
                        {
                            sumMoney -= 2;
                            Console.WriteLine("Purchased nuts");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;

                    case "Water":
                        if (sumMoney - 0.7 >= 0)
                        {
                            sumMoney -= 0.7;
                            Console.WriteLine("Purchased water");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;

                    case "Crisps":
                        if (sumMoney - 1.5 >= 0)
                        {
                            sumMoney -= 1.5;
                            Console.WriteLine("Purchased crisps");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;

                    case "Soda":
                        if (sumMoney - 0.8 >= 0)
                        {
                            sumMoney -= 0.8;
                            Console.WriteLine("Purchased soda");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;

                    case "Coke":
                        if (sumMoney - 1 >= 0)
                        {
                            sumMoney -= 1;
                            Console.WriteLine("Purchased coke");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
            }

            Console.WriteLine($"Change: {sumMoney:f2}");
        }
    }
}
//•	"Nuts" with a price of 2.0
//•	"Water" with a price of 0.7
//•	"Crisps" with a price of 1.5
//•	"Soda" with a price of 0.8
//•	"Coke" with a price of 1.0
