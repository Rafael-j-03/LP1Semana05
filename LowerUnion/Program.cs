using System;

namespace LowerUnion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Put all the array of args into lower case
            for (int i = 0; i < args.Length; i++)
            {
                args[i] = args[i].ToLower();
            }

            // Print the array of args
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }
    }
}
