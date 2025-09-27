using System;
using System.Security.Principal;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class BankAccount
{
    // Private fields
    private string accountNumber;
    private string accountHolderName;
    private decimal balance;

    // Public properties
    public string AccountNumber 
    { 
        get { return accountNumber; } 
    }
    public string AccountHolderName 
    {
        get { return accountHolderName; }
        set { accountHolderName = value; }
    }
    public decimal Balance 
    {
        get { return balance; } 
    }

    // Constructor
    public BankAccount(string accountNumber, string accountHolderName, decimal initialBalance)
    {
        this.accountNumber = accountNumber;
        this.accountHolderName = accountHolderName;
        this.balance = initialBalance;
    }

    // Deposit Method
    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            // Makes sure the deposit amount is positive
            throw new ArgumentException("Deposit amount must be positive.");
        }
        balance += amount;
    }

    // Withdraw Method
    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            // Makes sure the withdraw amount is positive
            throw new ArgumentException("Withdraw amount must be positive.");
        }
        if (amount > balance)
        {
            // Prevents overdraft
            throw new ArgumentException("Insufficient funds for this withdrawal.");
        }
        balance -= amount;
    }

    public override string ToString()
    {
        return $"Account Number: {AccountNumber}\nAccount Holder: {AccountHolderName} \nBalance: {Balance:C}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = createBankAccount();

        string? choice;
        bool exit = false;
        do
        {
            Console.WriteLine("Choose an option: \n1. Deposit \n2.Withdraw\n3.Show Account Summary\n4.Exit");
            Console.Write(">>> ");
            choice = Console.ReadLine();
            int operation = choiceIsValid(choice);
            if (operation == -1)
            {
                Console.WriteLine("Invalid choice, please select again.");
                continue;
            }
            switch (operation)
            {
                case 1:
                    // Deposit
                    Console.Write("Enter amount to deposit: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
                    {
                        try
                        {
                            account.Deposit(depositAmount);
                            Console.WriteLine($"Successfully deposited {depositAmount:C}");
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else
                    {
                        // For cases where input is not a valid decimal number (user trying to input a string or special characters)
                        Console.WriteLine("Invalid amount, please enter a numeric value.");
                    }
                    break;
                case 2:
                    // Withdraw
                    Console.Write("Enter amount to withdraw: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount))
                    {
                        try
                        {
                            account.Withdraw(withdrawAmount);
                            Console.WriteLine($"Successfully withdrew {withdrawAmount:C}");
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount, please enter a numeric value.");
                    }
                    break;
                case 3:
                    // Show Account Summary
                    Console.WriteLine(account.ToString());
                    break;
                case 4:
                    // Exit
                    exit = true;
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
            }
            Console.WriteLine(); // Adds a blank line for better readability

        } while (!exit);



    }
    private static BankAccount createBankAccount()
    {
        // Prompts the user for account details. 

        string? accountNumber, accountHolderName;

        // Validates that inputs are not empty
        do
        {
            Console.WriteLine("Enter Account Number: ");
            Console.Write(">>> ");
            accountNumber = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(accountNumber))
            {
                Console.WriteLine("Account Number can not be empty, please answer again.");
            }
        } while (string.IsNullOrWhiteSpace(accountNumber));

        do
        {
            Console.WriteLine("Enter Account Holder Name: ");
            Console.Write(">>> ");
            accountHolderName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(accountHolderName))
            {
                Console.WriteLine("Account Holder Name can not be empty, please answer again.");
            }
        } while (string.IsNullOrWhiteSpace(accountHolderName));

        // Creates a new bank account with an initial balance of 0.
        BankAccount account = new BankAccount(accountNumber, accountHolderName, 0);

        Console.WriteLine("\nAccount created successfully!");

        return account;

    }

    // This dictionary maps user input to corresponding operation code.
    private static readonly Dictionary<string, int> ChoiceMap = new()
    {
        { "1", 1 }, { "deposit", 1 }, {"1. deposit", 1 },
        { "2", 2 }, { "withdraw", 2 }, {"2. withdraw", 2 },
        { "3", 3 }, { "summary", 3 } , { "account summary", 3 }, { "show account summary", 3 }, { "3. show account summary", 3 },
        { "4", 4 }, { "exit", 4 }, { "4. exit", 4 }
    };

    // This method validates the user's choice and returns the corresponding operation code.
    private static int choiceIsValid(string? choice)
    {   
        if (string.IsNullOrWhiteSpace(choice))
        {             
            return -1;
        }
        else
        {
            choice = choice.Trim().ToLower();

            if (ChoiceMap.TryGetValue(choice, out int operationCode))
            {
                return operationCode;
            }
            else
            {
                return -1; // Invalid choice
            }
        }
    }
}