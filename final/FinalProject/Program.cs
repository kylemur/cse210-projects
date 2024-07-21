using System;

class Program
{
    static void Main(string[] args)
    {
        Attributes attributesAll = new();

        string menuOption = "";
        while(menuOption != "3")
        {
            Console.WriteLine();
            Console.WriteLine("Menu ");
            Console.WriteLine(" 1. Record a Sporting Event");
            Console.WriteLine(" 2. See Data");
            Console.WriteLine(" 3. Exit");
            Console.Write("Select a choice from the menu: ");
            menuOption = Console.ReadLine();
            Console.WriteLine();

            string option = "";
            if (menuOption == "1") // Record a Sporting Event
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
                Console.Write("Select a choice from the menu: ");
                option = Console.ReadLine();
                Console.WriteLine();


                if (option == "1") // Baseball
                {
                    Console.Write("team: ");
                    string team = Console.ReadLine();
                    Console.Write("duration (# of innings): ");
                    float duration = float.Parse(Console.ReadLine());
                    Console.Write("location: ");
                    string location = Console.ReadLine();
                    Console.Write("field surface: ");
                    string playingSurface = Console.ReadLine();
                    Console.Write("penalties: ");
                    int penalties = int.Parse(Console.ReadLine());
                    Console.Write("runs: ");
                    int runs = int.Parse(Console.ReadLine());
                    Console.Write("runs conceded: ");
                    int runsConceded = int.Parse(Console.ReadLine());
                    Console.Write("foul balls: ");
                    int foulBalls = int.Parse(Console.ReadLine());
                    Console.Write("strikes: ");
                    int strikes = int.Parse(Console.ReadLine());
                    Console.Write("singles: ");
                    int singles = int.Parse(Console.ReadLine());
                    Console.Write("doubles: ");
                    int doubles = int.Parse(Console.ReadLine());
                    Console.Write("triples: ");
                    int triples = int.Parse(Console.ReadLine());
                    Console.Write("home runs: ");
                    int homeRuns = int.Parse(Console.ReadLine());
                    
                    Baseball baseball1 = new Baseball(team, duration, location, playingSurface, penalties, runs, runsConceded, foulBalls, strikes, singles, doubles, triples, homeRuns);
                    Console.WriteLine();
                    baseball1.DisplayAttributes();
                    baseball1.SaveAttributes();
                    attributesAll.AddAttributes(baseball1);
                }
                else if (option == "2") // Basketball
                {
                    Console.Write("team: ");
                    string team = Console.ReadLine();
                    Console.Write("duration (minutes): ");
                    float duration = float.Parse(Console.ReadLine());
                    Console.Write("location: ");
                    string location = Console.ReadLine();
                    Console.Write("court surface: ");
                    string playingSurface = Console.ReadLine();
                    Console.Write("fouls: ");
                    int penalties = int.Parse(Console.ReadLine());
                    Console.Write("points conceded: ");
                    int pointsConceded = int.Parse(Console.ReadLine());
                    Console.Write("two point shots: ");
                    int shots = int.Parse(Console.ReadLine());
                    Console.Write("two point shots made: ");
                    int shotsMade = int.Parse(Console.ReadLine());
                    Console.Write("three point shots: ");
                    int threeShots = int.Parse(Console.ReadLine());
                    Console.Write("three pointers made: ");
                    int threeShotsMade = int.Parse(Console.ReadLine());
                    Console.Write("free throws: ");
                    int freeThrows = int.Parse(Console.ReadLine());
                    Console.Write("free throws made: ");
                    int freeMade = int.Parse(Console.ReadLine());
                    
                    Basketball basketball1 = new Basketball(team, duration, location, playingSurface, penalties, pointsConceded, shots, shotsMade, threeShots, threeShotsMade, freeThrows, freeMade);
                    Console.WriteLine();
                    basketball1.DisplayAttributes();
                    basketball1.SaveAttributes();
                    attributesAll.AddAttributes(basketball1);
                }
                else if (option == "3") // Football
                {
                    Console.Write("team: ");
                    string team = Console.ReadLine();
                    Console.Write("duration (minutes): ");
                    float duration = float.Parse(Console.ReadLine());
                    Console.Write("location: ");
                    string location = Console.ReadLine();
                    Console.Write("field surface: ");
                    string playingSurface = Console.ReadLine();
                    Console.Write("penalties: ");
                    int penalties = int.Parse(Console.ReadLine());
                    Console.Write("yards penalized: ");
                    int yardsPen = int.Parse(Console.ReadLine());
                    Console.Write("points conceded: ");
                    int pointsConceded = int.Parse(Console.ReadLine());
                    Console.Write("touchdowns: ");
                    int touchdowns = int.Parse(Console.ReadLine());
                    Console.Write("PATs: ");
                    int PATs = int.Parse(Console.ReadLine());
                    Console.Write("two point conversions: ");
                    int twoPt = int.Parse(Console.ReadLine());
                    Console.Write("field goals: ");
                    int fieldGoals = int.Parse(Console.ReadLine());
                    Console.Write("other points: ");
                    int otherPoints = int.Parse(Console.ReadLine());
                    Console.Write("offensive yards: ");
                    int yardsO = int.Parse(Console.ReadLine());
                    Console.Write("yards allowed: ");
                    int yardsD = int.Parse(Console.ReadLine());
                    Console.Write("turnovers: ");
                    int turnovers = int.Parse(Console.ReadLine());
                    
                    Football football1 = new Football(team, duration, location, playingSurface, penalties, yardsPen, pointsConceded, touchdowns, PATs, twoPt, fieldGoals, otherPoints, yardsO, yardsD, turnovers);
                    Console.WriteLine();
                    football1.DisplayAttributes();
                    football1.SaveAttributes();
                    attributesAll.AddAttributes(football1);
                }
                else if (option == "4") // Golf
                {
                    Console.Write("name: ");
                    string team = Console.ReadLine();
                    Console.Write("duration (# of holes): ");
                    float duration = float.Parse(Console.ReadLine());
                    Console.Write("location: ");
                    string location = Console.ReadLine();
                    Console.Write("course type: ");
                    string playingSurface = Console.ReadLine();
                    Console.Write("penalty strokes: ");
                    int penalties = int.Parse(Console.ReadLine());
                    
                    Golf golf1 = new Golf(team, duration, location, playingSurface, penalties);
                    golf1.AddToPars();
                    golf1.AddToActuals();
                    golf1.SetNames();
                    golf1.SetTotalStrokes();
                    Console.WriteLine();
                    golf1.DisplayAttributes();
                    golf1.SaveAttributes();
                    attributesAll.AddAttributes(golf1);
                }
                else if (option == "5") // Hockey
                {
                    Console.Write("team: ");
                    string team = Console.ReadLine();
                    Console.Write("duration (minutes): ");
                    float duration = float.Parse(Console.ReadLine());
                    Console.Write("location: ");
                    string location = Console.ReadLine();
                    Console.Write("field surface: ");
                    string playingSurface = Console.ReadLine();
                    Console.Write("fouls: ");
                    int penalties = int.Parse(Console.ReadLine());
                    Console.Write("goals: ");
                    int goals = int.Parse(Console.ReadLine());
                    Console.Write("goals conceded: ");
                    int goalsConceded = int.Parse(Console.ReadLine());
                    Console.Write("shots: ");
                    int shots = int.Parse(Console.ReadLine());
                    Console.Write("shots on goal: ");
                    int shotsOnGoal = int.Parse(Console.ReadLine());
                    Console.Write("saves: ");
                    int saves = int.Parse(Console.ReadLine());
                    Console.Write("minutes in penalty box: ");
                    int penBoxMins = int.Parse(Console.ReadLine());
                    
                    Hockey hockey1 = new Hockey(team, duration, location, playingSurface, penalties, goals, goalsConceded, shots, shotsOnGoal, saves, penBoxMins);
                    Console.WriteLine();
                    hockey1.DisplayAttributes();
                    hockey1.SaveAttributes();
                    attributesAll.AddAttributes(hockey1);
                }
                else if (option == "6") // Soccer
                {
                    Console.Write("team: ");
                    string team = Console.ReadLine();
                    Console.Write("duration (minutes): ");
                    float duration = float.Parse(Console.ReadLine());
                    Console.Write("location: ");
                    string location = Console.ReadLine();
                    Console.Write("field surface: ");
                    string playingSurface = Console.ReadLine();
                    Console.Write("fouls: ");
                    int penalties = int.Parse(Console.ReadLine());
                    Console.Write("goals: ");
                    int goals = int.Parse(Console.ReadLine());
                    Console.Write("goals conceded: ");
                    int goalsConceded = int.Parse(Console.ReadLine());
                    Console.Write("shots: ");
                    int shots = int.Parse(Console.ReadLine());
                    Console.Write("shots on goal: ");
                    int shotsOnGoal = int.Parse(Console.ReadLine());
                    Console.Write("saves: ");
                    int saves = int.Parse(Console.ReadLine());
                    Console.Write("yellow cards: ");
                    int yellowCards = int.Parse(Console.ReadLine());
                    Console.Write("red cards: ");
                    int redCards = int.Parse(Console.ReadLine());
                    
                    Soccer soccer1 = new Soccer(team, duration, location, playingSurface, penalties, goals, goalsConceded, shots, shotsOnGoal, saves, yellowCards, redCards);
                    Console.WriteLine();
                    soccer1.DisplayAttributes();
                    soccer1.SaveAttributes();
                    attributesAll.AddAttributes(soccer1);
                }
                else if (option == "7") // Wrestling
                {
                    Console.Write("name: ");
                    string team = Console.ReadLine();
                    Console.Write("duration (minutes): ");
                    float duration = float.Parse(Console.ReadLine());
                    Console.Write("location: ");
                    string location = Console.ReadLine();
                    Console.Write("surface type: ");
                    string playingSurface = Console.ReadLine();
                    Console.Write("penalties: ");
                    int penalties = int.Parse(Console.ReadLine());
                    Console.Write("points conceded: ");
                    int pointsConceded = int.Parse(Console.ReadLine());
                    Console.Write("one point moves: ");
                    int onePoint = int.Parse(Console.ReadLine());
                    Console.Write("two point moves: ");
                    int twoPoint = int.Parse(Console.ReadLine());
                    Console.Write("four point moves: ");
                    int fourPoint = int.Parse(Console.ReadLine());
                    Console.Write("five point moves: ");
                    int fivePoint = int.Parse(Console.ReadLine());
                    Console.Write("pin: ");
                    bool pin = bool.Parse(Console.ReadLine());
                    Console.Write("was pinned: ");
                    bool wasPinned = bool.Parse(Console.ReadLine());
                    
                    Wrestling wrestling1 = new Wrestling(team, duration, location, playingSurface, penalties, pointsConceded, onePoint, twoPoint, fourPoint, fivePoint, pin, wasPinned);
                    Console.WriteLine();
                    wrestling1.DisplayAttributes();
                    wrestling1.SaveAttributes();
                    attributesAll.AddAttributes(wrestling1);
                }
                else
                {
                    Console.WriteLine("Invalid entry.");
                }
            }
            else if (menuOption == "2") // See Data
            {
                Console.WriteLine();
                Console.WriteLine("Data Menu");
                Console.WriteLine(" 1. Attributes");
                Console.WriteLine(" 2. Leaderboard");
                Console.WriteLine(" 3. Other Calculations");
                Console.Write("Select a choice from the menu: ");
                string dataOption = Console.ReadLine();
                Console.WriteLine();

                if (dataOption == "1") // See Attributes
                {
                    Console.WriteLine("All");
                    Console.WriteLine("Baseball");
                    Console.WriteLine("Basketball");
                    Console.WriteLine("Football");
                    Console.WriteLine("Golf");
                    Console.WriteLine("Hockey");
                    Console.WriteLine("Soccer");
                    Console.WriteLine("Wrestling");
                    Console.WriteLine();
                    Console.Write("What do you want to see? ");
                    attributesAll.Display(Console.ReadLine());
                }
                else if (dataOption == "2") // See Leaderboard
                {
                    
                }
                else if (dataOption == "3") // Other Calculations
                {

                }
                else
                {
                    Console.WriteLine("Invalid entry.");
                }
            }
            else if (menuOption == "3") // Exit
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