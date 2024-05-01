using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("Enter grade percentage: ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letter;

        /*
        if (grade >= 90)
        {
            Console.WriteLine($"{grade} earns an A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine($"{grade} earns a B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine($"{grade} earns a C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine($"{grade} earns a D");
        }
        else
        {
            Console.WriteLine($"{grade} earns an F");
        }

        if (grade >= 70)
        {
            Console.WriteLine($"You passed!");
        }
        else
        {
            Console.WriteLine($"You did not pass. Better luck next time.");
        }
        */

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        string plusMinus;
        int lastDigit = grade % 10;
        if (lastDigit >= 7)
        {
            plusMinus = "+";
        }
        else if (lastDigit < 3)
        {
            plusMinus = "-";
        }
        else 
        {
            plusMinus = "";
        }


        if (grade >= 93 || letter == "F")
        {
            plusMinus = "";
        }

        Console.WriteLine($"Your grade: {letter}{plusMinus} ");

        if (grade >= 70)
        {
            Console.WriteLine($"You passed!");
        }
        else
        {
            Console.WriteLine($"You did not pass. Better luck next time.");
        }

    }
}