using System;
using System.IO;

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

            // Put the array of args by alphabetical order
            Array.Sort(args);

            // Put the array of args separated by a _ with stringWriter
            StringWriter separate = new StringWriter();
            for (int i = 0; i < args.Length; i++)
            {
                separate.Write(args[i]);
                if (i != args.Length - 1)
                {
                    separate.Write("_");
                }
            }

            // Print the array of args
            Console.WriteLine(separate);
        }
    }
}