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
        }
    }
}
