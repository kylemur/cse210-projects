using System;

class Program
{
    static void Main(string[] args)
    {
        string option = "";
        while(option != "6")
        {
            Console.WriteLine("\nYou have {points} points.\n");

            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");
            option = Console.ReadLine();

            if(option == "1")
            {

            }
            else if(option == "2")
            {

            }
            else if(option == "3")
            {
                
            }
            else if(option == "4")
            {
                
            }
            else if(option == "5")
            {
                
            }
            else if(option == "6")
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