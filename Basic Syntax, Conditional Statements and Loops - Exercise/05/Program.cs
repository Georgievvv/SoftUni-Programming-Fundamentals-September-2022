using System;

namespace _05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;
            char charts = ' ';

            for (int i = username.Length - 1; i >= 0; i--)
            {
                charts = username[i];
                password += charts;
            }

            int totalTries = 1;
            string enteredPassword;

            while ((enteredPassword = Console.ReadLine()) != password)
            {
                if (totalTries >= 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }

                else
                {
                    Console.WriteLine($"Incorrect password. Try again.");
                }

                totalTries++;
            }

            Console.WriteLine($"User {username} logged in.");
        }
    }
}
