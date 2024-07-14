using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello FinalProject World!");

        string option = "";
        while(option != "8")
        {
            Console.WriteLine();
            Console.WriteLine("What type of team/player are you recording?");
            Console.WriteLine(" 1. Baseball");
            Console.WriteLine(" 2. Basketball");
            Console.WriteLine(" 3. Football");
            Console.WriteLine(" 4. Golf");
            Console.WriteLine(" 5. Hockey");
            Console.WriteLine(" 6. Soccer");
            Console.WriteLine(" 7. Wrestling");
            Console.WriteLine(" 8. Exit");
            Console.Write("Select a choice from the menu: ");
            option = Console.ReadLine();
            Console.WriteLine(" "); // makes a clear line for formatting/organization


            if (option == "1") // Baseball
            {

            }
            else if (option == "2")
            {

            }
            else if (option == "3")
            {

            }
            else if (option == "4")
            {

            }
            else if (option == "5")
            {

            }
            else if (option == "6")
            {

            }
            else if (option == "7")
            {

            }
            else if (option == "8")
            {
                Console.WriteLine("Goodbye.");
            }
            else
            {
                Console.WriteLine("Invalid entry.");

            }

        }
    }
}