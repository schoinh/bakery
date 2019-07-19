using System;
using Bakery.Models;

class Program
{
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
        Console.WriteLine("---------------------");
    }
    
    private static void Main()
    {
        ShowWelcome();
    }
}
