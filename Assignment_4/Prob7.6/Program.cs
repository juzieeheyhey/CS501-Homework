using System;
using System.IO;

class Program
{
    static void Main()
    {
        const int SIZE = 400;
        string[] names = new string[SIZE]; // initialize array
        int count = 0;

        try
        {
            StreamReader inputFile = File.OpenText("popular_names.txt");

            while (count < names.Length && !inputFile.EndOfStream)
            {
                string line = inputFile.ReadLine(); // read file
                if (!string.IsNullOrWhiteSpace(line))
                {
                    names[count] = line.Trim(); // add names to array
                    count++;
                }
            }

            inputFile.Close();
            Console.WriteLine("popular_names.txt file read.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Could not find popular_names.txt.");
            return;
        }

        while (true)
        {
            Console.Write("Enter a name: ");
            string input = Console.ReadLine();

            if (input == null) continue;
            input = input.Trim(); // remove spaces
            if (input == "") // if no names were entered
            { 
                Console.WriteLine("Please enter a name."); 
                continue; 
            }

            bool found = false;
            for (int i = 0; i < count; i++)
            {
                if (input.ToUpper() == names[i].ToUpper()) // not case sensitive
                {
                    found = true; 
                    break; // if found, break
                }
            }

            if (found)
                Console.WriteLine(input + " is among the most popular names.");
            else
                Console.WriteLine(input + " is NOT among the most popular names.");
        }
    }
}