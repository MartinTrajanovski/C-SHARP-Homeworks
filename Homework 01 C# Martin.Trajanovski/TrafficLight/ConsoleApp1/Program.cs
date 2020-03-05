using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor
            = ConsoleColor.Red;
            Console.WriteLine("STOP",
                           Console.BackgroundColor);
            Thread.Sleep(2000);
            Console.BackgroundColor
            = ConsoleColor.Yellow;
            Console.WriteLine("READY",
                           Console.BackgroundColor);
            Thread.Sleep(2000);
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.BackgroundColor
            = ConsoleColor.DarkGreen;
            Console.WriteLine("GO",
                           Console.BackgroundColor);






            Console.ReadLine();
        }
    }
}
