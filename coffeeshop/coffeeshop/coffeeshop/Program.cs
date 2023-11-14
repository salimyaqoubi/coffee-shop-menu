using System;
using System.Drawing;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Coffee Shop!");

        // Menu Display
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Americano - $2.50");
        Console.WriteLine("2. Latte - $3.00");
        Console.WriteLine("3. Cappuccino - $3.50");

        // Order Placement
        Console.Write("Select a coffee (1-3): ");
        int coffeeChoice = int.Parse(Console.ReadLine());

        // Customizations order
        Console.WriteLine("Customizations:");
        Console.WriteLine("1. Small");
        Console.WriteLine("2. Medium");
        Console.WriteLine("3. Large");

        Console.Write("Select a size (1-3): ");
        int sizeChoice = int.Parse(Console.ReadLine());


        //ask for sugar
        string sugar1 = "yes";
        string sugar2 = "no";
        string sugar;


        Console.Write("Do you want sugar? (yes/no):");
        sugar = Console.ReadLine();

        //ask for milk
        string milke1 = "yes";
        string milk2 = "no";
        string milk;

        Console.Write("Do you want milk? (yes/no): ");
        milk = Console.ReadLine();


        //cost calculation and order summary
        if (number == 1)
        {
            Console.WriteLine("Americano  - $2.50 ");

        }
        else if (number == 2)
        {
            Console.WriteLine("Latte - $3.00");
        }
        else
        {
            Console.WriteLine("Cappuccino - $3.50");
        }
        if (size == 1)
        {
            Console.WriteLine("Small");
        }
        else if (size == 2)
        {
            Console.WriteLine("Medium");
        }
        else
        {
            Console.WriteLine("Large");
        }
        if (sugar == "yes")
        {
            Console.WriteLine("with suger");
            Console.Read();

        }
        else
        {
            Console.WriteLine("no suger ");
        }
        if (milk == "yes")
        {
            Console.WriteLine("with milk");



        }
        else
        {
            Console.Write("no milk ");

        }
        Console.WriteLine("Your Order Summary:" + number + size + sugar + milk);
        Console.WriteLine("Total Cost:");
        Console.WriteLine("Thank you for ordering!");

       
        }
    }
}
