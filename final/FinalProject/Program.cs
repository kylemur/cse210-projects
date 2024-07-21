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
                // Console.Write("outcome: ");
                Console.Write("team: ");
                string team = Console.ReadLine();
                Console.Write("duration: ");
                float duration = float.Parse(Console.ReadLine());
                Console.Write("location: ");
                string location = Console.ReadLine();
                Console.Write("playingSurface: ");
                string playingSurface = Console.ReadLine();
                Console.Write("penalties: ");
                int penalties = int.Parse(Console.ReadLine());
                Console.Write("runs: ");
                int runs = int.Parse(Console.ReadLine());
                Console.Write("runsConceded: ");
                int runsConceded = int.Parse(Console.ReadLine());
                Console.Write("foulBalls: ");
                int foulBalls = int.Parse(Console.ReadLine());
                Console.Write("strikes: ");
                int strikes = int.Parse(Console.ReadLine());
                Console.Write("singles: ");
                int singles = int.Parse(Console.ReadLine());
                Console.Write("doubles: ");
                int doubles = int.Parse(Console.ReadLine());
                Console.Write("triples: ");
                int triples = int.Parse(Console.ReadLine());
                Console.Write("homeRuns: ");
                int homeRuns = int.Parse(Console.ReadLine());
                
                Baseball baseball1 = new Baseball(team, duration, location, playingSurface, penalties, runs, runsConceded, foulBalls, strikes, singles, doubles, triples, homeRuns);
                Console.WriteLine();
                baseball1.DisplayAttributes();
            }
            else if (option == "2") // Basketball
            {
                Console.Write("team: ");
                string team = Console.ReadLine();
                Console.Write("duration: ");
                float duration = float.Parse(Console.ReadLine());
                Console.Write("location: ");
                string location = Console.ReadLine();
                Console.Write("playingSurface: ");
                string playingSurface = Console.ReadLine();
                Console.Write("penalties: ");
                int penalties = int.Parse(Console.ReadLine());
                Console.Write("pointsConceded: ");
                int pointsConceded = int.Parse(Console.ReadLine());
                Console.Write("shots: ");
                int shots = int.Parse(Console.ReadLine());
                Console.Write("shotsMade: ");
                int shotsMade = int.Parse(Console.ReadLine());
                Console.Write("threeShots: ");
                int threeShots = int.Parse(Console.ReadLine());
                Console.Write("threeShotsMade: ");
                int threeShotsMade = int.Parse(Console.ReadLine());
                Console.Write("freeThrows: ");
                int freeThrows = int.Parse(Console.ReadLine());
                Console.Write("freeMade: ");
                int freeMade = int.Parse(Console.ReadLine());
                
                Basketball basketball1 = new Basketball(team, duration, location, playingSurface, penalties, pointsConceded, shots, shotsMade, threeShots, threeShotsMade, freeThrows, freeMade);
                Console.WriteLine();
                basketball1.DisplayAttributes();
            }
            else if (option == "3") // Football
            {
                Console.Write("team: ");
                string team = Console.ReadLine();
                Console.Write("duration: ");
                float duration = float.Parse(Console.ReadLine());
                Console.Write("location: ");
                string location = Console.ReadLine();
                Console.Write("playingSurface: ");
                string playingSurface = Console.ReadLine();
                Console.Write("penalties: ");
                int penalties = int.Parse(Console.ReadLine());
                Console.Write("pointsConceded: ");
                int pointsConceded = int.Parse(Console.ReadLine());
                Console.Write("touchdowns: ");
                int touchdowns = int.Parse(Console.ReadLine());
                Console.Write("PATs: ");
                int PATs = int.Parse(Console.ReadLine());
                Console.Write("twoPt: ");
                int twoPt = int.Parse(Console.ReadLine());
                Console.Write("fieldGoals: ");
                int fieldGoals = int.Parse(Console.ReadLine());
                Console.Write("otherPoints: ");
                int otherPoints = int.Parse(Console.ReadLine());
                Console.Write("yardsO: ");
                int yardsO = int.Parse(Console.ReadLine());
                Console.Write("yardsD: ");
                int yardsD = int.Parse(Console.ReadLine());
                Console.Write("turnovers: ");
                int turnovers = int.Parse(Console.ReadLine());
                
                Football football1 = new Football(team, duration, location, playingSurface, penalties, pointsConceded, touchdowns, PATs, twoPt, fieldGoals, otherPoints, yardsO, yardsD, turnovers);
                Console.WriteLine();
                football1.DisplayAttributes();
            }
            else if (option == "4") // Golf
            {
                Console.Write("team: ");
                string team = Console.ReadLine();
                Console.Write("duration: ");
                float duration = float.Parse(Console.ReadLine());
                Console.Write("location: ");
                string location = Console.ReadLine();
                Console.Write("playingSurface: ");
                string playingSurface = Console.ReadLine();
                Console.Write("penalties: ");
                int penalties = int.Parse(Console.ReadLine());
                
                Golf golf1 = new Golf(team, duration, location, playingSurface, penalties);
                golf1.SetPars();
                golf1.SetActuals();
                golf1.SetNames();
                golf1.SetTotalStrokes();
                Console.WriteLine();
                golf1.DisplayAttributes();
            }
            else if (option == "5") // Hockey
            {
                Console.Write("team: ");
                string team = Console.ReadLine();
                Console.Write("duration: ");
                float duration = float.Parse(Console.ReadLine());
                Console.Write("location: ");
                string location = Console.ReadLine();
                Console.Write("playingSurface: ");
                string playingSurface = Console.ReadLine();
                Console.Write("penalties: ");
                int penalties = int.Parse(Console.ReadLine());
                Console.Write("goals: ");
                int goals = int.Parse(Console.ReadLine());
                Console.Write("goalsConceded: ");
                int goalsConceded = int.Parse(Console.ReadLine());
                Console.Write("shots: ");
                int shots = int.Parse(Console.ReadLine());
                Console.Write("shotsOnGoal: ");
                int shotsOnGoal = int.Parse(Console.ReadLine());
                Console.Write("saves: ");
                int saves = int.Parse(Console.ReadLine());
                Console.Write("penBoxMins: ");
                int penBoxMins = int.Parse(Console.ReadLine());
                
                Hockey hockey1 = new Hockey(team, duration, location, playingSurface, penalties, goals, goalsConceded, shots, shotsOnGoal, saves, penBoxMins);
                Console.WriteLine();
                hockey1.DisplayAttributes();
            }
            else if (option == "6") // Soccer
            {
                Console.Write("team: ");
                string team = Console.ReadLine();
                Console.Write("duration: ");
                float duration = float.Parse(Console.ReadLine());
                Console.Write("location: ");
                string location = Console.ReadLine();
                Console.Write("playingSurface: ");
                string playingSurface = Console.ReadLine();
                Console.Write("penalties: ");
                int penalties = int.Parse(Console.ReadLine());
                Console.Write("goals: ");
                int goals = int.Parse(Console.ReadLine());
                Console.Write("goalsConceded: ");
                int goalsConceded = int.Parse(Console.ReadLine());
                Console.Write("shots: ");
                int shots = int.Parse(Console.ReadLine());
                Console.Write("shotsOnGoal: ");
                int shotsOnGoal = int.Parse(Console.ReadLine());
                Console.Write("saves: ");
                int saves = int.Parse(Console.ReadLine());
                Console.Write("yellowCards: ");
                int yellowCards = int.Parse(Console.ReadLine());
                Console.Write("redCards: ");
                int redCards = int.Parse(Console.ReadLine());
                
                Soccer soccer1 = new Soccer(team, duration, location, playingSurface, penalties, goals, goalsConceded, shots, shotsOnGoal, saves, yellowCards, redCards);
                Console.WriteLine();
                soccer1.DisplayAttributes();
            }
            else if (option == "7") // Wrestling
            {
                Console.Write("team: ");
                string team = Console.ReadLine();
                Console.Write("duration: ");
                float duration = float.Parse(Console.ReadLine());
                Console.Write("location: ");
                string location = Console.ReadLine();
                Console.Write("playingSurface: ");
                string playingSurface = Console.ReadLine();
                Console.Write("penalties: ");
                int penalties = int.Parse(Console.ReadLine());
                Console.Write("pointsConceded: ");
                int pointsConceded = int.Parse(Console.ReadLine());
                Console.Write("onePoint: ");
                int onePoint = int.Parse(Console.ReadLine());
                Console.Write("twoPoint: ");
                int twoPoint = int.Parse(Console.ReadLine());
                Console.Write("fourPoint: ");
                int fourPoint = int.Parse(Console.ReadLine());
                Console.Write("fivePoint: ");
                int fivePoint = int.Parse(Console.ReadLine());
                Console.Write("pin: ");
                bool pin = bool.Parse(Console.ReadLine());
                Console.Write("wasPinned: ");
                bool wasPinned = bool.Parse(Console.ReadLine());
                
                Wrestling wrestling1 = new Wrestling(team, duration, location, playingSurface, penalties, pointsConceded, onePoint, twoPoint, fourPoint, fivePoint, pin, wasPinned);
                Console.WriteLine();
                wrestling1.DisplayAttributes();
            }
            else if (option == "8") // Exit
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