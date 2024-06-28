using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your username? ");
        string _userName = Console.ReadLine();

        Game game1 = new();
        game1.Load(_userName);

        string option = "";
        while(option != "7")
        {
            Console.WriteLine($"\n{_userName} has {game1.GetTotalPoints()} points.\n");

            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Points Per Category");
            Console.WriteLine(" 7. Quit");
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
                    simpleGoal1.Start();
                    game1.AddGoal(simpleGoal1);
                }
                else if(goalType == "2")
                {
                    EternalGoal eternalGoal1 = new EternalGoal();
                    eternalGoal1.Start();
                    game1.AddGoal(eternalGoal1);
                }
                else if(goalType == "3")
                {
                    ChecklistGoal checklistGoal1 = new ChecklistGoal();
                    checklistGoal1.Start();
                    game1.AddGoal(checklistGoal1);
                }
                else
                {
                    Console.WriteLine("Invalid entry.");
                }
            }
            else if(option == "2")
            {
                game1.DisplayGoalList();
            }
            else if(option == "3")
            {
                Console.WriteLine($"Would you like to: \n 1. Save to {_userName}GoalInfo.txt \n 2. Save to another name? ");
                string saveAs = Console.ReadLine();
                if (saveAs == "1")
                {
                    game1.Save(_userName);
                }
                else if (saveAs == "2")
                {
                    Console.Write("What is the name? ");
                    string fileName = $"{Console.ReadLine()}";
                    game1.Save(fileName);
                }
                
            }
            else if(option == "4")
            {
                Console.WriteLine($"{_userName}GoalInfo.txt has already been loaded.");
                Console.Write("Do you want to load GoalInfo for another name? (y/n) ");
                string yesNo = Console.ReadLine();
                if (yesNo == "y")
                {
                    Console.Write("What is the name? ");
                    string fileName = $"{Console.ReadLine()}";
                    game1.Load(fileName);

                    string filePath = Path.Combine("GoalGameInfo", $"{fileName}GoalInfo.txt");
                    if (File.Exists(filePath))
                    {
                        _userName = fileName;
                    }                    
                }
                
            }
            else if(option == "5")
            {
                game1.RecordEvent();
                // Console.WriteLine("The goals are: ");
                // // 1. name
                // // 2. name
                // Console.Write("Which goal did you accomplish? ");
                // string accomplishedGoal = Console.ReadLine();
                
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
            else if (option == "6")
            {
                game1.DisplayPointsDetails();
            }
            else if(option == "7")
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