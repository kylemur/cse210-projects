// I made sure no prompts/questions are selected until they have all been used at least once in that session.

using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        while (choice != 4)
        {
            Console.Clear();

            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Start breathing activity ");
            Console.WriteLine("  2. Start reflecting activity ");
            Console.WriteLine("  3. Start listing activity ");
            Console.WriteLine("  4. Quit ");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            Console.Clear();


            if (choice == 1)
            {
                BreathingActivity breathingActivity1 = new BreathingActivity();

                DateTime startTime = DateTime.Now;
                DateTime endTime = startTime.AddSeconds(breathingActivity1.GetDuration());
                while (DateTime.Now < endTime)
                {
                    breathingActivity1.DisplayMessages();
                    breathingActivity1.TimerPause();
                }

                breathingActivity1.ShowEndMessage();
            }

            else if (choice == 2)
            {
                ReflectionActivity reflectionActivity1 = new();
                Console.WriteLine("Consider the following prompt: \n");
                reflectionActivity1.ShowPrompt();
                
                Console.Write("\nWhen you have something in mind, press enter to continue. ");
                string cont = Console.ReadLine();

                Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience. ");
                Console.Write("You may begin in: ");
                reflectionActivity1.TimerPause();

                DateTime startTime = DateTime.Now;
                DateTime endTime = startTime.AddSeconds(reflectionActivity1.GetDuration());
                while (DateTime.Now < endTime)
                {
                    reflectionActivity1.ShowQuestion();
                    reflectionActivity1.SpinnerPause(10);
                }

                reflectionActivity1.ShowEndMessage();
            }

            else if (choice == 3)
            {
                ListingActivity listingActivity1 = new();

                listingActivity1.ShowPrompt();
                DateTime startTime = DateTime.Now;
                DateTime endTime = startTime.AddSeconds(listingActivity1.GetDuration());
                while (DateTime.Now < endTime)
                {
                    listingActivity1.AddResponse();
                }

                int numberResponses = listingActivity1.CountResponses();
                Console.WriteLine($"\nYou wrote {numberResponses} items. ");

                listingActivity1.ShowEndMessage();
            }

            else if (choice == 4)
            {
                Console.WriteLine("Goodbye. \n");
            }

            else
            {
                Console.WriteLine("Invalid input. \n");
            }
        }
    }
}