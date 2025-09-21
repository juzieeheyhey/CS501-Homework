using System;
using System.Globalization;

namespace BMICalculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("I am a BMI Calculator!");
            try
            {
                string gender = PromptGender();
                double height = PromptDouble("Please enter your height in meters (e.g., 1.75): ");
                double weight = PromptDouble("Please enter your weight in kilograms (e.g., 70.5): ");
                int age = PromptAge();
                var user = new BMI(gender, height, weight, age);
                double bmi = user.CalculateBMI();
                Console.WriteLine($"\nYour BMI is: {bmi:F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }



        }

        private static string PromptGender() // This function handles input for gender prompt
        {
            while (true)
            {
                Console.Write("Enter your gender (male/female/other): ");
                string input = (Console.ReadLine()?.Trim().ToLower() ?? "");

                // Check if the input is empty
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Input cannot be empty. Please enter your gender.\n");
                    continue;
                }

                // Accept valid values
                if (input == "male" || input == "female" || input == "other")
                {
                    return input;
                }

                // Handle invalid input
                Console.WriteLine("Invalid input. Please enter Male, Female, or Other.\n");
            }
        }

        private static double PromptDouble(string message) // This function handles input for Height & Weight (asking for number)
        {
            while (true)
            {
                try
                {
                    Console.Write(message);
                    
                    double input = Convert.ToDouble(Console.ReadLine());

                    // Check if the input is negative
                    if (input < 0)
                    {
                        Console.WriteLine("Invalid input. Please enter a positive number.");
                        continue;
                    }

                    // Return valid input (no negative, no exception)
                    return input;

                }
                catch (FormatException) // Handle the case when user input letters
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid input." + ex.Message);
                    continue;
                }
                    
                
            }
        }

        private static int PromptAge() // This function handles input for Age field
        {
            while (true)
            {
                try
                {
                    Console.Write("Please enter your age: ");

                    int input = Convert.ToInt32(Console.ReadLine());

                    // Check if the input is negative
                    if (input < 0)
                    {
                        Console.WriteLine("Invalid input. Please enter a positive number.");
                        continue;
                    }

                    // Return valid input (no negative, no exception)
                    return input;

                }
                catch (FormatException) // Handle the case when user input letters or double number
                {
                    Console.WriteLine("Invalid input. Please enter an interger.");
                    continue;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid input." + ex.Message);
                    continue;
                }


            }
        }

    }

}
