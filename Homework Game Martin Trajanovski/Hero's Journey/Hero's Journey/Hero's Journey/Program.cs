using System;
using System.Linq;

namespace Hero_s_Journey
{
    class Program
    {
        static void Main(string[] args) 
        {
                string[] emails = new string[] { "martin@mail.com", "jovana@mail.com" };
                string[] passwords = new string[] { "martin", "jovana" };
                int tries = 0;
                while (tries < 6)
                {
                    Console.WriteLine("Please enter your e-mail address!");
                    string userMail = Console.ReadLine();
                    Console.WriteLine("Please enter your password address!");
                    string userPass = Console.ReadLine();
                    if (emails.Contains(userMail) && passwords.Contains(userPass))
                    {
                        Console.WriteLine($"Welcome {userMail}! Press Enter to create your character!");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                    if (userMail == "" || userPass == "")
                    {
                        Console.WriteLine("The E-Mail and Password fields must not be empty. Press Enter to try again...");
                        tries++;
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else if (!userMail.ToLower().Contains('@') || !userMail.ToLower().Contains('.'))
                    {

                        Console.WriteLine("The E-Mail is invalid! Press enter to try again...");
                        tries++;
                        Console.ReadLine();
                        Console.Clear();

                    }
                    else if (!emails.Contains(userMail) || !passwords.Contains(userPass))
                    {
                        Console.WriteLine("The E-Mail and Password do not match! Press Enter to try again...");
                        tries++;
                        Console.ReadLine();
                        Console.Clear();
                    }
                    if (tries > 5)
                    {
                        Console.WriteLine("You have run out of tries! Press Enter to exit!");
                        Console.ReadLine();
                        System.Environment.Exit(0);
                    }
                }
            static void doStuff()
            {
                string userName;
                string userRace = "";
                string userClass = "";
                string userOptionInput = "";
                Random randomNumber = new Random();
                int rnd;
                int userOption;
                int userHealth = 0;
                int userAgility = 0;
                int userStrength = 0;
                int dwarfHealth = 100;
                int dwarfStrength = 6;
                int dwarfAgility = 2;
                int elfHealth = 60;
                int elfAgility = 6;
                int elfStrength = 4;
                int humanHealth = 80;
                int humanStrength = 5;
                int humanAgility = 4;
                int warriorHealth = 20;
                int warriorAgility = -1;
                int rogueHealth = -20;
                int rogueAgility = 1;
                int mageHealth = 20;
                int mageStrength = -1;
                string dwarf = "Dwarf";
                string elf = "Elf";
                string human = "Human";
                string warrior = "Warrior";
                string rogue = "Rogue";
                string mage = "Mage";
                while (true)
                {
                    Console.WriteLine("Choose a name:");
                    userName = Console.ReadLine();
                    Console.Clear();
                    if (userName.Length <= 1 || userName.Length > 20)
                    {
                        Console.WriteLine("The name of the hero must not be shorter than 1 or longer than" +
                        " 20 characters!\nPress enter to try again...");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        break;
                    }
                }
                while (true)
                {
                    Console.WriteLine("Choose a race:");
                    Console.ForegroundColor
                        = ConsoleColor.Yellow;
                    Console.WriteLine($"1) {dwarf}",
                                            Console.ForegroundColor);
                    Console.ForegroundColor
                        = ConsoleColor.Green;
                    Console.WriteLine($"2) {elf}",
                                             Console.ForegroundColor);
                    Console.ForegroundColor
                        = ConsoleColor.Blue;
                    Console.WriteLine($"3) {human}",
                                             Console.ForegroundColor);
                    Console.ResetColor();

                    string userCharacter = Console.ReadLine();
                    Console.Clear();
                    int character;
                    bool isCharacterParsed = int.TryParse(userCharacter, out character);
                    if (isCharacterParsed)
                    {
                        if (character < 1 || character > 3)
                        {
                            Console.WriteLine("Please enter a number between 1 - 3. Press Enter to try again...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            if (character == 1)
                            {
                                userHealth += dwarfHealth;
                                userStrength += dwarfStrength;
                                userAgility = +dwarfAgility;
                                userRace = dwarf;
                            }
                            if (character == 2)
                            {
                                userHealth += elfHealth;
                                userStrength += elfStrength;
                                userAgility += elfAgility;
                                userRace = elf;
                            }
                            if (character == 3)
                            {
                                userHealth += humanHealth;
                                userStrength += humanStrength;
                                userAgility += humanAgility;
                                userRace = human;
                            }
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number between 1 - 3. Press Enter to try again...");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                while (true)
                {
                    Console.WriteLine("Choose a class:");
                    Console.ForegroundColor
                        = ConsoleColor.Red;
                    Console.WriteLine($"1) {warrior}",
                                            Console.ForegroundColor);
                    Console.ForegroundColor
                        = ConsoleColor.Green;
                    Console.WriteLine($"2) {rogue}",
                                             Console.ForegroundColor);
                    Console.ForegroundColor
                        = ConsoleColor.Blue;
                    Console.WriteLine($"3) {mage}",
                                             Console.ForegroundColor);
                    Console.ResetColor();
                    string userClassInput = Console.ReadLine();
                    Console.Clear();
                    int classOfCharacter;
                    bool isClassOfCharacterParsed = int.TryParse(userClassInput, out classOfCharacter);
                    if (isClassOfCharacterParsed)
                    {
                        if (classOfCharacter < 1 || classOfCharacter > 3)
                        {
                            Console.WriteLine("Please enter a number between 1 - 3. Press Enter to try again...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            if (classOfCharacter == 1)
                            {
                                userHealth += warriorHealth;
                                userAgility += warriorAgility;
                                userClass = warrior;
                            }
                            if (classOfCharacter == 2)
                            {
                                userHealth += rogueHealth;
                                userAgility += rogueAgility;
                                userClass = rogue;

                            }
                            if (classOfCharacter == 3)
                            {
                                userHealth += mageHealth;
                                userStrength += mageStrength;
                                userClass = mage;
                            }
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number between 1 - 3. Press Enter to try again...");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                Console.WriteLine("Character successfully created!");
                Console.WriteLine($"{userName} ({userRace}) the {userClass}");
                Console.WriteLine($"Status: {userHealth} HP, {userStrength} STR, {userAgility} AGI!");
                Console.WriteLine("Press Enter to start playing...");
                Console.ReadLine();
                Console.Clear();
                while (true)
                {
                    Console.WriteLine($"Bandits attack you out of nowhere. They seem very dangerous...\nHealth: {userHealth}\n" +
                        $"1) Fight\n2) Run");
                    userOptionInput = Console.ReadLine();
                    bool isUserParsed = int.TryParse(userOptionInput, out userOption); 
                    if (isUserParsed)
                    {
                        if (userOption < 1 || userOption >3)
                        {
                            Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (userOption == 1)
                        {
                            rnd = randomNumber.Next(1, 11);
                            if (rnd < userStrength)
                            {
                                Console.WriteLine("You won the fight. Press Enter to continue...");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            }
                            if (rnd >= userStrength)
                            {
                                Console.WriteLine("You lost the fight! Press Enter to continue...");
                                userHealth -= 20;
                                Console.ReadLine();
                                Console.Clear();
                                if (userHealth <= 0)
                                {
                                    Console.WriteLine("You lost the game!\n1) Restart the game\n2) Quit");
                                    userOptionInput = Console.ReadLine();
                                    bool isUserParsed2 = int.TryParse(userOptionInput, out userOption);
                                    if (isUserParsed2)
                                    {
                                        if (userOption == 1)
                                        {
                                            doStuff();
                                        }
                                        else if (userOption == 2)
                                        {
                                            System.Environment.Exit(0);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                                            Console.ReadLine();
                                            Console.Clear();
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                                        Console.ReadLine();
                                        Console.Clear();
                                    }
                                } else
                                {
                                    break;
                                }
                            }
                        }
                        else if (userOption == 2) {
                            rnd = randomNumber.Next(1, 11);
                            if (rnd < userAgility)
                            {
                                Console.WriteLine("You managed to run away. Press Enter to continue...");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            }
                            if (rnd >= userAgility)
                            {
                                Console.WriteLine("You failed to run away! Press Enter to continue...");
                                userHealth -= 20;
                                Console.ReadLine();
                                Console.Clear();
                                if (userHealth <= 0)
                                {
                                    Console.WriteLine("You lost the game!\n1) Restart the game\n2) Quit");
                                    userOptionInput = Console.ReadLine();
                                    bool isUserParsed2 = int.TryParse(userOptionInput, out userOption);
                                    if (isUserParsed2)
                                    {
                                        if (userOption == 1)
                                        {
                                            doStuff();
                                        }
                                        else if (userOption == 2)
                                        {
                                            System.Environment.Exit(0);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                                            Console.ReadLine();
                                            Console.Clear();
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                                        Console.ReadLine();
                                        Console.Clear();
                                    }
                                } else
                                {
                                    break;
                                }
                            }
                        } 
                        else
                        {
                            Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                    } else
                    {
                        Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    }
                while (true)
                {
                    Console.WriteLine($"You bump into one of the guards of the nearby village. They attack you without warning...\nHealth: {userHealth}\n" +
                        $"1) Fight\n2) Run");
                    userOptionInput = Console.ReadLine();
                    bool isUserParsed = int.TryParse(userOptionInput, out userOption);
                    if (isUserParsed)
                    {
                        if (userOption < 1 || userOption > 3)
                        {
                            Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (userOption == 1)
                        {
                            rnd = randomNumber.Next(1, 11);
                            if (rnd < userStrength)
                            {
                                Console.WriteLine("You won the fight. Press Enter to continue...");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            }
                            if (rnd >= userStrength)
                            {
                                Console.WriteLine("You lost the fight! Press Enter to continue...");
                                Console.ReadLine();
                                Console.Clear();
                                userHealth -= 30;
                                if (userHealth <= 0)
                                {
                                    Console.WriteLine("You lost the game!\n1) Restart the game\n2) Quit");
                                    userOptionInput = Console.ReadLine();
                                    bool isUserParsed2 = int.TryParse(userOptionInput, out userOption);
                                    if (isUserParsed2)
                                    {
                                        if (userOption == 1)
                                        {
                                            Console.Clear();
                                            doStuff();
                                        }
                                        else if (userOption == 2)
                                        {
                                            System.Environment.Exit(0);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                                            Console.ReadLine();
                                            Console.Clear();
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                                        Console.ReadLine();
                                        Console.Clear();
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        else if (userOption == 2)
                        {
                            rnd = randomNumber.Next(1, 11);
                            if (rnd < userAgility)
                            {
                                Console.WriteLine("You managed to run away. Press Enter to continue...");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            }
                            if (rnd >= userAgility)
                            {
                                Console.WriteLine("You failed to run away! Press Enter to continue...");
                                Console.ReadLine();
                                Console.Clear();
                                userHealth -= 30;
                                if (userHealth <= 0)
                                {
                                    Console.WriteLine("You lost the game!\n1) Restart the game\n2) Quit");
                                    userOptionInput = Console.ReadLine();
                                    bool isUserParsed2 = int.TryParse(userOptionInput, out userOption);
                                    if (isUserParsed2)
                                    {
                                        if (userOption == 1)
                                        {
                                            Console.Clear();
                                            doStuff();
                                        }
                                        else if (userOption == 2)
                                        {
                                            System.Environment.Exit(0);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                                            Console.ReadLine();
                                            Console.Clear();
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                                        Console.ReadLine();
                                        Console.Clear();
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                while (true)
                {
                    Console.WriteLine($"A Land Shark appears. It starts chasing you down to eat you...\nHealth: {userHealth}\n" +
                        $"1) Fight\n2) Run");
                    userOptionInput = Console.ReadLine();
                    bool isUserParsed = int.TryParse(userOptionInput, out userOption);
                    if (isUserParsed)
                    {
                        if (userOption < 1 || userOption > 3)
                        {
                            Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (userOption == 1)
                        {
                            rnd = randomNumber.Next(1, 11);
                            if (rnd < userStrength)
                            {
                                Console.WriteLine("You won the fight. Press Enter to continue...");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            }
                            if (rnd >= userStrength)
                            {
                                Console.WriteLine("You lost the fight! Press Enter to continue...");
                                Console.ReadLine();
                                Console.Clear();
                                userHealth -= 50;
                                if (userHealth <= 0)
                                {
                                    Console.WriteLine("You lost the game!\n1) Restart the game\n2) Quit");
                                    userOptionInput = Console.ReadLine();
                                    bool isUserParsed2 = int.TryParse(userOptionInput, out userOption);
                                    if (isUserParsed2)
                                    {
                                        if (userOption == 1)
                                        {
                                            Console.Clear();
                                            doStuff();
                                        }
                                        else if (userOption == 2)
                                        {
                                            System.Environment.Exit(0);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                                            Console.ReadLine();
                                            Console.Clear();
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                                        Console.ReadLine();
                                        Console.Clear();
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        else if (userOption == 2)
                        {
                            rnd = randomNumber.Next(1, 11);
                            if (rnd < userAgility)
                            {
                                Console.WriteLine("You managed to run away. Press Enter to continue...");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            }
                            if (rnd >= userAgility)
                            {
                                Console.WriteLine("You failed to run away! Press Enter to continue...");
                                Console.ReadLine();
                                Console.Clear();
                                userHealth -= 50;
                                if (userHealth <= 0)
                                {
                                    Console.WriteLine("You lost the game!\n1) Restart the game\n2) Quit");
                                    userOptionInput = Console.ReadLine();
                                    bool isUserParsed2 = int.TryParse(userOptionInput, out userOption);
                                    if (isUserParsed2)
                                    {
                                        if (userOption == 1)
                                        {
                                            Console.Clear();
                                            doStuff();
                                        }
                                        else if (userOption == 2)
                                        {
                                            System.Environment.Exit(0);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                                            Console.ReadLine();
                                            Console.Clear();
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                                        Console.ReadLine();
                                        Console.Clear();
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                while (true)
                {
                    Console.WriteLine($"You accidentally step on a rat. His friends are not happy. They attack... \nHealth: {userHealth}\n" +
                        $"1) Fight\n2) Run");
                    userOptionInput = Console.ReadLine();
                    bool isUserParsed = int.TryParse(userOptionInput, out userOption);
                    if (isUserParsed)
                    {
                        if (userOption < 1 || userOption > 3)
                        {
                            Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (userOption == 1)
                        {
                            rnd = randomNumber.Next(1, 11);
                            if (rnd < userStrength)
                            {
                                Console.WriteLine("You won the fight. Press Enter to continue...");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            }
                            if (rnd >= userStrength)
                            {
                                Console.WriteLine("You lost the fight! Press Enter to continue...");
                                Console.ReadLine();
                                Console.Clear();
                                userHealth -= 10;
                                if (userHealth <= 0)
                                {
                                    Console.WriteLine("You lost the game!\n1) Restart the game\n2) Quit");
                                    userOptionInput = Console.ReadLine();
                                    bool isUserParsed2 = int.TryParse(userOptionInput, out userOption);
                                    if (isUserParsed2)
                                    {
                                        if (userOption == 1)
                                        {
                                            Console.Clear();
                                            doStuff();
                                        }
                                        else if (userOption == 2)
                                        {
                                            System.Environment.Exit(0);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                                            Console.ReadLine();
                                            Console.Clear();
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                                        Console.ReadLine();
                                        Console.Clear();
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        else if (userOption == 2)
                        {
                            rnd = randomNumber.Next(1, 11);
                            if (rnd < userAgility)
                            {
                                Console.WriteLine("You managed to run away. Press Enter to continue...");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            }
                            if (rnd >= userAgility)
                            {
                                Console.WriteLine("You failed to run away! Press Enter to continue...");
                                Console.ReadLine();
                                Console.Clear();
                                userHealth -= 10;
                                if (userHealth <= 0)
                                {
                                    Console.WriteLine("You lost the game!\n1) Restart the game\n2) Quit");
                                    userOptionInput = Console.ReadLine();
                                    bool isUserParsed2 = int.TryParse(userOptionInput, out userOption);
                                    if (isUserParsed2)
                                    {
                                        if (userOption == 1)
                                        {
                                            Console.Clear();
                                            doStuff();
                                        }
                                        else if (userOption == 2)
                                        {
                                            System.Environment.Exit(0);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                                            Console.ReadLine();
                                            Console.Clear();
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                                        Console.ReadLine();
                                        Console.Clear();
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                while (true)
                {
                    Console.WriteLine($"You find a huge rock. It comes alive somehow and tries to smash you... \nHealth: {userHealth}\n" +
                        $"1) Fight\n2) Run");
                    userOptionInput = Console.ReadLine();
                    bool isUserParsed = int.TryParse(userOptionInput, out userOption);
                    if (isUserParsed)
                    {
                        if (userOption < 1 || userOption > 3)
                        {
                            Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (userOption == 1)
                        {
                            rnd = randomNumber.Next(1, 11);
                            if (rnd < userStrength)
                            {
                                Console.WriteLine("You won the fight. Press Enter to continue...");
                                Console.ReadLine();
                                Console.Clear();
                                if (userHealth <= 0)
                                {
                                    Console.WriteLine("You lost the game!\n1) Restart the game\n2) Quit");
                                    userOptionInput = Console.ReadLine();
                                    bool isUserParsed2 = int.TryParse(userOptionInput, out userOption);
                                    if (isUserParsed2)
                                    {
                                        if (userOption == 1)
                                        {
                                            Console.Clear();
                                            doStuff();
                                        }
                                        else if (userOption == 2)
                                        {
                                            System.Environment.Exit(0);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                                            Console.ReadLine();
                                            Console.Clear();
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                                        Console.ReadLine();
                                        Console.Clear();
                                    }
                                }
                                else if (userHealth > 0)
                                {
                                    Console.WriteLine("You won!\n 1) Play again\n2) Quit");
                                    userOptionInput = Console.ReadLine();
                                    bool isUserParsed2 = int.TryParse(userOptionInput, out userOption);
                                    if (isUserParsed2)
                                    {
                                        if (userOption == 1)
                                        {
                                            Console.Clear();
                                            doStuff();
                                        }
                                        else if (userOption == 2)
                                        {
                                            System.Environment.Exit(0);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                                            Console.ReadLine();
                                            Console.Clear();
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                                        Console.ReadLine();
                                        Console.Clear();
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                            if (rnd >= userStrength)
                            {
                                Console.WriteLine("You lost the fight! Press Enter to continue...");
                                Console.ReadLine();
                                Console.Clear();
                                userHealth -= 30;
                                if (userHealth <= 0)
                                {
                                    Console.WriteLine("You lost the game!\n1) Restart the game\n2) Quit");
                                    userOptionInput = Console.ReadLine();
                                    bool isUserParsed2 = int.TryParse(userOptionInput, out userOption);
                                    if (isUserParsed2)
                                    {
                                        if (userOption == 1)
                                        {
                                            Console.Clear();
                                            doStuff();
                                        }
                                        else if (userOption == 2)
                                        {
                                            System.Environment.Exit(0);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                                            Console.ReadLine();
                                            Console.Clear();
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                                        Console.ReadLine();
                                        Console.Clear();
                                    }
                                }
                                else if (userHealth > 0)
                                {
                                    Console.WriteLine("You won!\n 1) Play again\n2) Quit");
                                    userOptionInput = Console.ReadLine();
                                    bool isUserParsed2 = int.TryParse(userOptionInput, out userOption);
                                    if (isUserParsed2)
                                    {
                                        if (userOption == 1)
                                        {
                                            Console.Clear();
                                            doStuff();
                                        }
                                        else if (userOption == 2)
                                        {
                                            System.Environment.Exit(0);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                                            Console.ReadLine();
                                            Console.Clear();
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                                        Console.ReadLine();
                                        Console.Clear();
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        else if (userOption == 2)
                        {
                            rnd = randomNumber.Next(1, 11);
                            if (rnd < userAgility)
                            {
                                Console.WriteLine("You managed to run away. Press Enter to continue...");
                                Console.ReadLine();
                                Console.Clear();
                                if (userHealth <= 0)
                                {
                                    Console.WriteLine("You lost the game!\n1) Restart the game\n2) Quit");
                                    userOptionInput = Console.ReadLine();
                                    bool isUserParsed2 = int.TryParse(userOptionInput, out userOption);
                                    if (isUserParsed2)
                                    {
                                        if (userOption == 1)
                                        {
                                            Console.Clear();
                                            doStuff();
                                        }
                                        else if (userOption == 2)
                                        {
                                            System.Environment.Exit(0);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                                            Console.ReadLine();
                                            Console.Clear();
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                                        Console.ReadLine();
                                        Console.Clear();
                                    }
                                }
                                else if (userHealth > 0)
                                {
                                    Console.WriteLine("You won!\n 1) Play again\n2) Quit");
                                    userOptionInput = Console.ReadLine();
                                    bool isUserParsed2 = int.TryParse(userOptionInput, out userOption);
                                    if (isUserParsed2)
                                    {
                                        if (userOption == 1)
                                        {
                                            Console.Clear();
                                            doStuff();
                                        }
                                        else if (userOption == 2)
                                        {
                                            System.Environment.Exit(0);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                                            Console.ReadLine();
                                            Console.Clear();
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                                        Console.ReadLine();
                                        Console.Clear();
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                            if (rnd >= userAgility)
                            {
                                Console.WriteLine("You failed to run away! Press Enter to continue...");
                                Console.ReadLine();
                                Console.Clear();
                                userHealth -= 30;
                                if (userHealth <= 0)
                                {
                                    Console.WriteLine("You lost the game!\n1) Restart the game\n2) Quit");
                                    userOptionInput = Console.ReadLine();
                                    bool isUserParsed2 = int.TryParse(userOptionInput, out userOption);
                                    if (isUserParsed2)
                                    {
                                        if (userOption == 1)
                                        {
                                            Console.Clear();
                                            doStuff();
                                        }
                                        else if (userOption == 2)
                                        {
                                            System.Environment.Exit(0);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                                            Console.ReadLine();
                                            Console.Clear();
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                                        Console.ReadLine();
                                        Console.Clear();
                                    }
                                }
                                else if (userHealth > 0)
                                {
                                    Console.WriteLine("You won!\n 1) Play again\n2) Quit");
                                    userOptionInput = Console.ReadLine();
                                    bool isUserParsed2 = int.TryParse(userOptionInput, out userOption);
                                    if (isUserParsed2)
                                    {
                                        if (userOption == 1)
                                        {
                                            Console.Clear();
                                            doStuff();
                                        }
                                        else if (userOption == 2)
                                        {
                                            System.Environment.Exit(0);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                                            Console.ReadLine();
                                            Console.Clear();
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                                        Console.ReadLine();
                                        Console.Clear();
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Press either 1 or 2. Press Enter to try again...");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }














            }
            doStuff();
            Console.ReadLine();
        }
    }
}
