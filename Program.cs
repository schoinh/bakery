using System;
using Bakery.Models;

class Program
{
    private static string userResponse = "";

    private static void ShowWelcome()
    {
        Console.Clear();
        Console.WriteLine("#~#~#~#~#~#~#~#~#~#~#~#");
        Console.WriteLine("#  BAGHEERA'S BAKERY  #");
        Console.WriteLine("#~#~#~#~#~#~#~#~#~#~#~#");
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

    private static void TakeBreadOrder()
    {
        Console.WriteLine("\nHow many loaves of bread would you like?"); 
        Console.Write("Enter number of loaves: ");
        string numBread = Console.ReadLine();

        // Validate user input and convert input to integer
        int intNumBread;
        bool isInt = int.TryParse(numBread, out intNumBread);
        if (!isInt)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please enter a valid number.");
            Console.ResetColor();
            TakeBreadOrder();
        }
    }

    private static void TakePastryOrder()
    {
        Console.WriteLine("\nHow many pastries would you like?");
        Console.Write("Enter number of pastries: ");
        string numPastry = Console.ReadLine();

        // Validate user input and convert input to integer
        int intNumPastry;
        bool isInt = int.TryParse(numPastry, out intNumPastry);
        if (!isInt)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please enter a valid number.");
            Console.ResetColor();
            TakePastryOrder();
        }
    }
    
    private static void Main()
    {
        ShowWelcome();
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1: Place an order");
        Console.Write("\nEnter Option (1-): ");
        userResponse = Console.ReadLine();
        
        if (userResponse == "1")
        {
            TakeBreadOrder();
            TakePastryOrder();
        }
    }
}
