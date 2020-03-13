using System;

namespace Coffee_machine
{
    class Program
    {
        static void Main(string[] args)
        {
            double espresso = 2;
            double macchiato = 3.5;
            double latte = 4;
            double cappuccino = 6;
            double tea = 1.5;
            double moneyGiven;
            Console.WriteLine("Welcome dear customer! Please select a drink: \n" +
                "1.Espresso...........2$ \n" +
                "2.Macchiato........3,5$ \n" +
                "3.Latte..............4$ \n" +
                "4.Cappuccino.........6$ \n" +
                "5.Tea..............1.5$");
            string userDrink = Console.ReadLine();
            int chosenDrink;
            bool isDrinkParsed = int.TryParse(userDrink, out chosenDrink);
            if (isDrinkParsed)
            {
                switch (chosenDrink)
                {
                case 1:
                    
                    Console.WriteLine($"Please insert 2$!");
                        string moneyInserted = Console.ReadLine();
                        bool isMoneyParsed = double.TryParse(moneyInserted, out moneyGiven);
                        while (!isMoneyParsed)
                        {
                            Console.WriteLine($"Please insert 2$!");
                            moneyInserted = Console.ReadLine();
                            isMoneyParsed = double.TryParse(moneyInserted, out moneyGiven);
                        }
                        while (moneyGiven < espresso)
                        {
                            double rest = espresso - moneyGiven;
                            Console.WriteLine($"The espresso costs ${espresso}$, you are {rest}$ short!");
                            Console.WriteLine($"Please insert 2$!");
                            moneyInserted = Console.ReadLine();
                            isMoneyParsed = double.TryParse(moneyInserted, out moneyGiven);
                        }
                        if (moneyGiven >= espresso)
                        {
                            Console.WriteLine("You can take your drink!");
                        }
                    break;
                case 2:
                        Console.WriteLine($"Please insert 3.5$!");
                        moneyInserted = Console.ReadLine();
                        isMoneyParsed = double.TryParse(moneyInserted, out moneyGiven);
                        while (!isMoneyParsed)
                        {
                            Console.WriteLine($"Please insert 3.5$!");
                            moneyInserted = Console.ReadLine();
                            isMoneyParsed = double.TryParse(moneyInserted, out moneyGiven);
                        }
                        while (moneyGiven < macchiato)
                        {
                            double rest = macchiato - moneyGiven;
                            Console.WriteLine($"The macchiato costs ${macchiato}$, you are {rest}$ short!");
                            Console.WriteLine($"Please insert 3.5$!");
                            moneyInserted = Console.ReadLine();
                            isMoneyParsed = double.TryParse(moneyInserted, out moneyGiven);
                        }
                        if (moneyGiven >= macchiato)
                        {
                            Console.WriteLine("You can take your drink!");
                        }
                        break;
                case 3:
                        Console.WriteLine($"Please insert 4$!");
                        moneyInserted = Console.ReadLine();
                        isMoneyParsed = double.TryParse(moneyInserted, out moneyGiven);
                        while (!isMoneyParsed)
                        {
                            Console.WriteLine($"Please insert 4$!");
                            moneyInserted = Console.ReadLine();
                            isMoneyParsed = double.TryParse(moneyInserted, out moneyGiven);
                        }
                        while (moneyGiven < latte)
                        {
                            double rest = latte - moneyGiven;
                            Console.WriteLine($"The latte costs ${latte}$, you are {rest}$ short!");
                            Console.WriteLine($"Please insert 4$!");
                            moneyInserted = Console.ReadLine();
                            isMoneyParsed = double.TryParse(moneyInserted, out moneyGiven);
                        }
                        if (moneyGiven >= latte)
                        {
                            Console.WriteLine("You can take your drink!");
                        }
                        break;
                case 4:
                        Console.WriteLine($"Please insert 6$!");
                        moneyInserted = Console.ReadLine();
                        isMoneyParsed = double.TryParse(moneyInserted, out moneyGiven);
                        while (!isMoneyParsed)
                        {
                            Console.WriteLine($"Please insert 6$!");
                            moneyInserted = Console.ReadLine();
                            isMoneyParsed = double.TryParse(moneyInserted, out moneyGiven);
                        }
                        while (moneyGiven < cappuccino)
                        {
                            double rest = cappuccino - moneyGiven;
                            Console.WriteLine($"The cappuccino costs ${cappuccino}$, you are {rest}$ short!");
                            Console.WriteLine($"Please insert 6$!");
                            moneyInserted = Console.ReadLine();
                            isMoneyParsed = double.TryParse(moneyInserted, out moneyGiven);
                        }
                        if (moneyGiven >= cappuccino)
                        {
                            Console.WriteLine("You can take your drink!");
                        }
                        break;
                    case 5:
                        Console.WriteLine($"Please insert 1.5$!");
                        moneyInserted = Console.ReadLine();
                        isMoneyParsed = double.TryParse(moneyInserted, out moneyGiven);
                        while (!isMoneyParsed)
                        {
                            Console.WriteLine($"Please insert 1.5$!");
                            moneyInserted = Console.ReadLine();
                            isMoneyParsed = double.TryParse(moneyInserted, out moneyGiven);
                        }
                        while (moneyGiven < tea)
                        {
                            double rest = tea - moneyGiven;
                            Console.WriteLine($"The tea costs ${tea}$, you are {rest}$ short!");
                            Console.WriteLine($"Please insert 1.5$!");
                            moneyInserted = Console.ReadLine();
                            isMoneyParsed = double.TryParse(moneyInserted, out moneyGiven);
                        }
                        if (moneyGiven >= tea)
                        {
                            Console.WriteLine("You can take your drink!");
                        }
                        break;
                    default:
                    Console.WriteLine("Please enter valid numbers and a valid operator!");
                    break;
                }
            }
            


            Console.ReadLine();
        }
    }
}
