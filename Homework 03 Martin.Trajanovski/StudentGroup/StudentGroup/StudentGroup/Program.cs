using System;

namespace StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentGroupOne = new string[5];
            string[] studentGroupTwo = new string[5];
            int counter = 0;
            int counterTwo = 0;
            Console.WriteLine("Enter the names of the students in the frist group: ");

            while (counter < studentGroupOne.Length)
            {
                string nameOfStudent = Console.ReadLine();
                if (nameOfStudent.Length > 1)
                {
                    studentGroupOne[counter] = nameOfStudent;
                    counter++;
                }
                else
                {
                    Console.WriteLine("Please enter a valid name");
                }
                if (counter == 5)
                {
                    Console.WriteLine("Thank you!");
                }
            }
            Console.Clear();
            Console.WriteLine("Enter the names of the students in the second group: ");
            while (counterTwo < studentGroupTwo.Length)
            {
                string nameOfStudent = Console.ReadLine();
                if (nameOfStudent.Length > 1)
                {
                    studentGroupTwo[counterTwo] = nameOfStudent;
                    counterTwo++;
                }
                else
                {
                    Console.WriteLine("Please enter a valid name");
                }
            }
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Press 1 to print the students from the first group, press 2 to print the students from the second group!");
                string userInput = Console.ReadLine();
                int group;
                bool isUserInputParsed = int.TryParse(userInput, out group);
                if (isUserInputParsed)
                {
                    if (group == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("The students in the first group are:");
                        for (int i = 0; i < studentGroupOne.Length; i++)
                        {
                            int ordinal = Array.IndexOf(studentGroupOne, studentGroupOne[i]);

                            Console.WriteLine($"{ordinal + 1}. {studentGroupOne[i]}");
                        }
                        break;
                    }
                    else if (group == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("The students in the second group are:");
                        for (int i = 0; i < studentGroupTwo.Length; i++)
                        {
                            int ordinal = Array.IndexOf(studentGroupTwo, studentGroupTwo[i]);

                            Console.WriteLine($"{ordinal + 1}. {studentGroupTwo[i]}");
                        }
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter either 1 or 2! Press Enter to try again...");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please enter either 1 or 2! Press Enter to try again...");
                    Console.ReadLine();
                }
            }






















            Console.ReadLine();
        }
    }
}
