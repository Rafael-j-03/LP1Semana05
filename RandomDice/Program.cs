using System;

namespace RandomDice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Let the user enter a number n.
            Console.Write("Enter a number n: ");
            int n = int.Parse(Console.ReadLine());

            // Create a random number generator.
            Random r = new Random();

            // Create a variable to store the total.
            int total = 0;

            // Roll n dices.
            for (int i = 0; i < n; i++)
            {
                total += r.Next(1,7);
            }

            // Print the total.
            Console.WriteLine("Total: " + total);
        }
    }
}