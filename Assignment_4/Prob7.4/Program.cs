using System;
using System.IO;

class Program
{
    static void Main()
    {
        char[] correct = {
            'B',
            'D',
            'A',
            'A',
            'C',
            'A',
            'B',
            'A',
            'C',
            'D',
            'B',
            'C',
            'D',
            'A',
            'D',
            'C',
            'C',
            'B',
            'D',
            'A',
        };

        StreamReader inputFile;

        // check if file path is valid
        while (true)
        {
            Console.Write("Enter the full path to the answers file: ");
            string path = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(path))
                return;

            try
            {
                inputFile = File.OpenText(path); // open file
                break;                           // if success, leave loop
            }
            catch
            {
                Console.WriteLine("Could not open file. Please try again.");
            }
        }

        char[] student = new char[20];

        int index = 0;

        while (index < student.Length && !inputFile.EndOfStream)
        {
            string line = inputFile.ReadLine(); // read one line
            student[index] = line[0]; // take first char
            index++;
        }

        inputFile.Close(); // close file

        // grade

        int count = 0;
        string wrongList = "";

        for (int i = 0; i < 20; i++)
        {
            if (student[i] == correct[i]) // if correct
            {
                count++;
            }
            else
            {
                wrongList = wrongList + (i + 1) + " "; // if wrong, add question number to the list
            }
        }

        if (count >= 15)
        {
            Console.WriteLine("You passed the exam.");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("You failed the exam.");
            Console.ReadLine();
        }

        Console.WriteLine("Correct: " + count);
        Console.WriteLine("Incorrect: " + (20 - count));
        Console.ReadLine();

        if (wrongList != "")
        {
            Console.WriteLine("Wrong questions: " + wrongList);
            Console.ReadLine();
        }
    }
}
