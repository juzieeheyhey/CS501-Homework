using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string moreCoffee = "yes"; // This variable is used to indicate if the user wants to buy more coffee.

        do
        {
            Console.WriteLine("Please select your coffee size:");
            Console.WriteLine("(1) Small");
            Console.WriteLine("(2) Medium");
            Console.WriteLine("(3) Large");
            Console.Write("Please select 1, 2, or 3: ");
            string choice = Console.ReadLine(); // Read user's choice

            switch (choice)
            {
                case "1": // If user selects 1
                    Console.WriteLine("You have selected a Small coffee.");
                    break;
                case "2": // If user selects 2
                    Console.WriteLine("You have selected a Medium coffee.");
                    break;
                case "3":  // If user selects 3
                    Console.WriteLine("You have selected a Large coffee.");
                    break;
                default: // Handle invalid input from user
                    Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
                    continue; // Skip the rest and start the loop again
            }

            do
            {
                Console.WriteLine("Would you like to buy another coffee? (yes/no)");
                moreCoffee = Console.ReadLine().ToLower(); // Read user's response and convert to lowercase
                if (moreCoffee != "yes" && moreCoffee != "no") // Validate user's input
                {
                    Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                }
                else
                {
                    break; // Valid input, exit the inner loop
                }
            } while (true);
        } while (moreCoffee == "yes");
        Console.WriteLine("Thank you for your order! Have a great day!");
    }
}