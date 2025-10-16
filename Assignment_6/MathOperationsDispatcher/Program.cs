using System;

namespace MathOperationsDispatcher
{
    class Program
    {
        // Define delegate
        delegate int MathOperation(int a, int b);

        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter first number: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter second number: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Choose operation (+, -, *, /): ");
                    char op = Convert.ToChar(Console.ReadLine());

                    MathOperation operation = null;

                    // Switch for assigning method to delegate
                    switch (op)
                    {
                        case '+':
                            operation = Add;
                            break;
                        case '-':
                            operation = Subtract;
                            break;
                        case '*':
                            operation = Multiply;
                            break;
                        case '/':
                            operation = Divide;
                            break;
                        default:
                            Console.WriteLine("Invalid operation. Try again.\n");
                            continue;
                    }

                    // Call the PerformOperation method
                    int result = PerformOperation(num1, num2, operation);
                    Console.WriteLine($"Result: {result}\n");

                    // Ask if user wants to perform another calculation
                    Console.Write("Do you want to perform another operation? (y/n): ");
                    string again = Console.ReadLine()?.Trim().ToLower();
                    if (again != "y")
                        break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Please enter valid numbers.\n");
                    continue;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.\n");
                    continue;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unexpected error: {ex.Message}\n");
                    continue;
                }
            }
        }

        // Methods matching the delegate
        static int Add(int a, int b) => a + b;
        static int Subtract(int a, int b) => a - b;
        static int Multiply(int a, int b) => a * b;
        static int Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException();
            return a / b;
        }

        // Method that calls delegate
        static int PerformOperation(int a, int b, MathOperation operation)
        {
            return operation(a, b);
        }
    }
}
