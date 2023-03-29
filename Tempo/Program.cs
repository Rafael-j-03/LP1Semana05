using System;
using System.Diagnostics;
using System.Threading;

namespace Tempo
{
    class Program
    {
        static void Main(string[] args)
        {
            // This code creates a new Stopwatch object called crono1.
            Stopwatch crono1 = new Stopwatch();
            // This code creates a new Stopwatch object called crono2.
            Stopwatch crono2 = new Stopwatch();

            // This code starts the Stopwatch object crono1.
            crono1.Start();

            // Add sleep time 500 milliseconds
            Thread.Sleep(500);

            // This code stops the Stopwatch object crono2
            crono2.Start();

            // Add sleep time 300 milliseconds
            Thread.Sleep(300);
        }
    }
}
