using Bakery.Models;
using System;

class Program
{
    private static Bread breadOrder = new Bread ();
    private static Pastry pastryOrder = new Pastry ();
    private static int intNumBread;
    private static int intNumPastry;

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

    // Convert user input to integer if possible; if not convertable, prompts user for new input
    private static bool ValidateConvertInput(ref int outputNum)
    {
        userResponse = Console.ReadLine();
        bool isInt = int.TryParse(userResponse, out outputNum);

        if (isInt)
        {
            return true; 
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please enter a valid number.");
            Console.ResetColor();
            return false;
        }
    }

    private static void TakeBreadOrder()
    {
        Console.Write("\nHow many loaves of bread would you like?: "); 
        if (ValidateConvertInput(ref intNumBread) == false)
        {
            TakeBreadOrder();
        }
    }

    private static void TakePastryOrder()
    {
        Console.Write("\nHow many pastries would you like?: ");
        if (ValidateConvertInput(ref intNumPastry) == false)
        {
            TakePastryOrder();
        }
    }

    // Add integer user input to the Bread or Pastry instance
    private static void ProcessOrder()
    {
        breadOrder.Quantity += intNumBread;
        pastryOrder.Quantity += intNumPastry;

        intNumBread = 0;    // Reset input to 0
        intNumPastry = 0;

        // Calculate totals for breads and pastries separately
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
                Console.WriteLine("\nGreat! Thank you for visiting!");
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
        if (ValidateConvertInput(ref intNumBread) == false)
        {
            AddMoreBread();
        }
        ProcessOrder();
    }

    private static void AddMorePastry()
    {
        Console.Write("\nHow many more pastries?: ");
        if (ValidateConvertInput(ref intNumPastry) == false)
        {
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
            Console.WriteLine("\nThank you for visiting!");
        }
    }
}
