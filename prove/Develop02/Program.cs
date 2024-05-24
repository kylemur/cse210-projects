using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        Journal journal1 = new Journal();

        Console.WriteLine("\nWelcome to the Journal Program!");

        while (choice != "5")
        {
            Console.WriteLine("\nPlease select one of the following choices: ");

            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                Entry writeEntry = new Entry();
                
                writeEntry._date = writeEntry.GetDate();
                writeEntry._prompt = writeEntry.GetPrompt();
                Console.WriteLine(writeEntry._prompt);
                writeEntry._response = Console.ReadLine();

                journal1.AddEntry(writeEntry);
            }

            else if (choice == "2")
            {
                journal1.Display();
            }

            else if (choice == "3")
            {
                journal1.Load();
            }

            else if (choice == "4")
            {
                journal1.Save();
            }

            else if (choice == "5")
            {
                Console.Write("Approximately what time will I write in my journal tomorrow? ");
                string journalTime = Console.ReadLine();
                Console.WriteLine($"Remember to set an alarm for {journalTime}. Goodbye.\n");
            }

            else
            {
                Console.WriteLine("Not a valid option. Try again.");
            }
        }
    }
}