using System;

namespace Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a sentence!");
            string inputSentence = Console.ReadLine();
            int wordCount = inputSentence.Split(' ').Length;
            Console.WriteLine($"The number of words is equal to {wordCount}!");

            Console.ReadLine();

            
        }
    }
}
