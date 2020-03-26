using System;

namespace Bonus_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentsGroup1 = { "Martin Martinovski", "Marko Markovski", "Filip Filipovski", "Jovana Jovanovska", "Simona Simonovska" };
            string[] studentsGroup2 = { "Darko Darkovski", "Jordan Jordanov" };
            string[] studentsGroup3 = { "Bisera Biserovska", "Ivana Ivanovska" };
            string[] teachers = { "Mladen Mladenovski", "Dusko Duskovski", "Mila Milanovska", "Jana Janevska" };
            string[] anouncements = { "All classes are cancelled until further notice. Stay home!", "The situation is getting out of hand!", "THE HORROR! THE HORR..." };
            string[] subjects = { "HTML", "CSS", "JavaScript Basic", "JavaScript Advanced", "C# Basic" };
            string userCapacity;

            while (true)
            {
                Console.WriteLine("Welcome! If you are a teacher press 'T', if you are a student press 'S'!");
                userCapacity = Console.ReadLine();
                if (userCapacity.ToLower() == "t" || userCapacity.ToLower() == "s")
                {
                    Console.Clear();
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter either 'T' or 'S'. Press Enter to try again...");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            while (true)
            {
                if (userCapacity.ToLower() == "t")
                {
                    Console.Clear();
                    Console.WriteLine("Please enter your name!");
                    string teacherName = Console.ReadLine();
                    if (Array.IndexOf(teachers, teacherName) >= 0)
                    {
                        Console.Clear();
                        Console.WriteLine("We have found you! Press Enter to continue...");
                        Console.ReadLine();
                        break;

                    }
                    else
                    {
                        Console.WriteLine("The name does not exist in the database! Press Enter to try again...");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                else if (userCapacity.ToLower() == "s")
                {
                    Console.Clear();
                    Console.WriteLine("Welcome! Please enter your name!");
                    string studentName = Console.ReadLine();
                    if (Array.IndexOf(studentsGroup1, studentName) >= 0 || Array.IndexOf(studentsGroup2, studentName) >= 0 || Array.IndexOf(studentsGroup3, studentName) >= 0)
                    {
                        Console.Clear();
                        Console.WriteLine("We have found you! Press Enter to continue...");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The name does not exist in the database Press Enter to try again...");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                else
                {
                    Console.WriteLine("{Please enter either 'T' or 'S'!");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            while (true)
            {
                if (userCapacity.ToLower() == "t" )
                {
                    Console.Clear();
                    Console.WriteLine("Please enter either 1 or 2!\n1) List students from a selected group\n2) Enter a new anouncement");
                    string userOptionInput = Console.ReadLine();
                    int userOption;
                    bool isUserOptionInputParsed = int.TryParse(userOptionInput, out userOption);
                    if (isUserOptionInputParsed)
                    {
                        if (userOption == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter a number from 1 - 3!\n1) List students from the 1st group\n2) List students from the 2nd group\n3) List students from the 3rd group");
                            string group = Console.ReadLine();
                            int chosenGroup;
                            bool isGroupParsed = int.TryParse(group, out chosenGroup);
                            if (isGroupParsed)
                            {
                                if (chosenGroup == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine("The students in the first group are:");
                                    for (int i = 0; i < studentsGroup1.Length; i++)
                                    {
                                        int ordinal = Array.IndexOf(studentsGroup1, studentsGroup1[i]);

                                        Console.WriteLine($"{ordinal + 1}. {studentsGroup1[i]}");
                                    }
                                    break;
                                }
                                else if (chosenGroup == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine("The students in the first group are:");
                                    for (int i = 0; i < studentsGroup2.Length; i++)
                                    {
                                        int ordinal = Array.IndexOf(studentsGroup2, studentsGroup2[i]);

                                        Console.WriteLine($"{ordinal + 1}. {studentsGroup2[i]}");
                                    }
                                    break;
                                }
                                else if (chosenGroup == 3)
                                {
                                    Console.Clear();
                                    Console.WriteLine("The students in the first group are:");
                                    for (int i = 0; i < studentsGroup3.Length; i++)
                                    {
                                        int ordinal = Array.IndexOf(studentsGroup3, studentsGroup3[i]);

                                        Console.WriteLine($"{ordinal + 1}. {studentsGroup3[i]}");
                                    }
                                    break;
                                } else
                                {
                                    Console.WriteLine("Please enter either 1 and 3! Press Enter to try again...");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please enter either 1 and 3! Press Enter to try again...");
                                Console.ReadLine();
                                Console.Clear();
                            }
                        }
                        else if (userOption == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Write your new anouncement below!");
                            string anouncement = Console.ReadLine();
                            int counter = anouncements.Length;
                            Array.Resize(ref anouncements, anouncements.Length + 1);

                            anouncements[counter] = anouncement;
                            Console.Clear();
                            Console.WriteLine("Anouncement stored successfully!");
                            Console.WriteLine("Here are all the anouncements!");
                            for (int i = 0; i < anouncements.Length; i++)
                            {
                                int ordinal = Array.IndexOf(anouncements, anouncements[i]);

                                Console.WriteLine($"{ordinal + 1}. {anouncements[i]}");
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter either 1 or 2! Press Enter to try again...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter either 1 or 2! Press Enter to try again...");
                        Console.ReadLine();
                    }
                } else if (userCapacity.ToLower() == "s")
                {
                    Console.Clear();
                    Console.WriteLine("Please enter either 1 or 2!\n1) List all academy subjects\n2) List all anouncements");
                    string studentOptionInput = Console.ReadLine();
                    int studentOption;
                    bool isStudentOptionInputParsed = int.TryParse(studentOptionInput, out studentOption);
                    if (isStudentOptionInputParsed)
                    {
                        if (studentOption == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("The academy subjects are:");
                            for (int i = 0; i < subjects.Length; i++)
                            {
                                int ordinal = Array.IndexOf(subjects, subjects[i]);

                                Console.WriteLine($"{ordinal + 1}. {subjects[i]}");
                            }
                            break;
                        }
                        else if (studentOption == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("The academy anouncements are:");
                            for (int i = 0; i < anouncements.Length; i++)
                            {
                                int ordinal = Array.IndexOf(anouncements, anouncements[i]);

                                Console.WriteLine($"{ordinal + 1}. {anouncements[i]}");
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter either 1 or 2. Press Enter to try again...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter either 1 or 2. Press Enter to try again...");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
