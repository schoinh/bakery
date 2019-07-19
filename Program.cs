using System;
using Bakery.Models;

class Program
{
    private static Bread breadOrder = new Bread ();
    private static Pastry pastryOrder = new Pastry ();
    private static int intNumBread;
    private static int intNumPastry;
    private static bool goodInput;

    private static string userResponse = "";

    private static void ShowWelcome()
    {
        Console.Clear();
        Console.WriteLine("#~#~#~#~#~#~#~#~#~#~#~#~#~#");
        Console.WriteLine("#                         #");
        Console.WriteLine("#    BAGHEERA'S BAKERY    #");
        Console.WriteLine("#                         #");
        Console.WriteLine("#~#~#~#~#~#~#~#~#~#~#~#~#~#");
        Console.WriteLine("\n~ Bienvenu a la Boulangerie ~\n");

        Console.WriteLine("------- MENU --------");
        Console.WriteLine("| Wheat Bread       |");
        Console.WriteLine("|            $5 / 1 |");
        Console.WriteLine("|           $10 / 3 |");
        Console.WriteLine("| Pastries          |");
        Console.WriteLine("|            $2 / 1 |");
        Console.WriteLine("|            $5 / 3 |");
        Console.WriteLine("---------------------\n");
    }

    private static void ValidateConvertInput(ref int outputNum)
    {
        userResponse = Console.ReadLine();
        // Console.WriteLine("User Response: " + userResponse);
        bool isInt = int.TryParse(userResponse, out outputNum);
        // Console.WriteLine("outputNum: " + outputNum);

        if (isInt)
        {
            goodInput = true; 
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please enter a valid number.");
            Console.ResetColor();
            goodInput = false;
        }
    }

    private static void TakeBreadOrder()
    {
        Console.Write("\nHow many loaves of bread would you like?: "); 
        ValidateConvertInput(ref intNumBread);
        Console.WriteLine("intNumBread: " + intNumBread);

        if (goodInput == false)
        {
            TakeBreadOrder();
        }

        // string numBread = Console.ReadLine();

        // // Validate user input and convert input to integer
        // bool isInt = int.TryParse(numBread, out intNumBread);
        // if (!isInt)
        // {
        //     Console.ForegroundColor = ConsoleColor.Red;
        //     Console.WriteLine("Please enter a valid number.");
        //     Console.ResetColor();
        //     TakeBreadOrder();
        // }
    }

    private static void TakePastryOrder()
    {
        Console.Write("\nHow many pastries would you like?: ");
        string numPastry = Console.ReadLine();

        // Validate user input and convert input to integer
        bool isInt = int.TryParse(numPastry, out intNumPastry);
        if (!isInt)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please enter a valid number.");
            Console.ResetColor();
            TakePastryOrder();
        }
    }

    private static void ProcessOrder()
    {
        breadOrder.Quantity += intNumBread;
        pastryOrder.Quantity += intNumPastry;

        breadOrder.GetCost();
        pastryOrder.GetCost();

        DisplayTotal();
    }

    private static void DisplayTotal()
    {
        int totalCost = breadOrder.Cost + pastryOrder.Cost;

        Console.WriteLine("\n------- YOUR ORDER -------");
        Console.WriteLine($" {breadOrder.Quantity}x Wheat Bread");
        Console.WriteLine($"                   ${breadOrder.Cost}.00");
        Console.WriteLine($" {pastryOrder.Quantity}x Pastries");
        Console.WriteLine($"                   ${pastryOrder.Cost}.00");
        Console.WriteLine("--------------------------");
        Console.WriteLine($"            TOTAL: ${totalCost}.00\n");

        AddToOrder();
    }

    private static void AddToOrder()
    {
        Console.WriteLine("Would you like to add any more items to your order?");
        Console.WriteLine(" 1: More Bread\n 2: More Pastries\n 3: No Thanks, I'm done");
        Console.Write("\nYour Choice (1-3): ");
        userResponse = Console.ReadLine();

        switch (userResponse)
        {
            case "1":
                AddMoreBread();
                break;
            case "2":
                AddMorePastry();
                break;
            case "3":
                Console.WriteLine("Thank you for visiting!");
                Environment.Exit(0);
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter a number between 1 and 3.");
                Console.ResetColor();
                AddToOrder();
                break;
        }
    }

    private static void AddMoreBread()
    {
        Console.Write("\nHow many more loaves of bread?: ");
        string numBread = Console.ReadLine();

        // Validate user input and convert input to integer
        bool isInt = int.TryParse(numBread, out intNumBread);
        if (!isInt)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please enter a valid number.");
            Console.ResetColor();
            AddMoreBread();
        }

        ProcessOrder();
    }

    private static void AddMorePastry()
    {
        Console.Write("\nHow many more pastries?: ");
        string numPastry = Console.ReadLine();

        // Validate user input and convert input to integer
        bool isInt = int.TryParse(numPastry, out intNumPastry);
        if (!isInt)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please enter a valid number.");
            Console.ResetColor();
            AddMorePastry();
        }

        ProcessOrder();
    }
    
    private static void Main()
    {
        ShowWelcome();
        Console.Write("\nWould you like to place an order? (Y/N): ");
        userResponse = Console.ReadLine();
        
        if (userResponse == "Y" || userResponse == "y")
        {
            TakeBreadOrder();
            TakePastryOrder();
            ProcessOrder();
        }
        else
        {
            Console.WriteLine("\nGreat! Thank you for visiting!");
        }
    }
}
