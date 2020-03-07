using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of trees!");
            int numberOfBranches = 12;
            int applesOnABranch = 8;
            int applesInABasket = 5;
            string inputTrees = Console.ReadLine();
            int numberOfTrees = Convert.ToInt32(inputTrees);
            double rest = (numberOfBranches * applesOnABranch * numberOfTrees) % applesInABasket;
            double numberOfBaskets = ((numberOfBranches * applesOnABranch * numberOfTrees) / applesInABasket) + rest;
            Console.WriteLine($"For {numberOfTrees} tree(s), you will need {numberOfBaskets} baskets!");
            Console.ReadLine();
        }
    }
}
