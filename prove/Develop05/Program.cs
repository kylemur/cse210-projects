using System;

class Program
{
    static void Main(string[] args)
    {
        string option = "";
        while(option != "6")
        {
            Game game1 = new();
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
                Console.WriteLine("The types of goals are:");
                Console.WriteLine(" 1. Simple Goal");
                Console.WriteLine(" 2. Eternal Goal");
                Console.WriteLine(" 3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                string goalType = Console.ReadLine();

                if(goalType == "1")
                {
                    SimpleGoal simpleGoal1 = new SimpleGoal();
                    game1.AddGoal(simpleGoal1);
                }
                else if(goalType == "2")
                {
                    EternalGoal eternalGoal1 = new EternalGoal();
                    game1.AddGoal(eternalGoal1);
                }
                else if(goalType == "3")
                {
                    ChecklistGoal checklistGoal1 = new ChecklistGoal();
                    game1.AddGoal(checklistGoal1);
                }
                else
                {
                    Console.WriteLine("Invalid entry.");
                }
            }
            else if(option == "2")
            {
                // 1. [x] _name (_description)
                // 2. [ ] _name (_description)
                // 3. [ ] _name (_description) -- Currently completed: _timesCompleted/_timesNeeded
            }
            else if(option == "3")
            {
                Console.Write("What is the filename for the goal file? ");
                string fileName = Console.ReadLine();
            }
            else if(option == "4")
            {
                // save points
                // save attributes for all classes
            }
            else if(option == "5")
            {
                Console.WriteLine("The goals are: ");
                // 1. name
                // 2. name
                Console.Write("Which goal did you accomplish? ");
                string accomplishedGoal = Console.ReadLine();
                
                // if(accomplishedGoal in list)
                // {
                //     int points = specificGoal.GetPointValue();
                //     specificGoal.AddPoints();
                //     Console.WriteLine($"Congradulations! You have earned {points} points! ");
                //     Console.WriteLine($"You now have {totalPoints} points! ");
                // }
                // else
                // {
                //     Console.WriteLine("Invalid entry.");
                // }
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