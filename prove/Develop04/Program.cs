using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        while (choice != 4)
        {
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
                breathingActivity1.SpinnerPause();

                DateTime startTime = DateTime.Now;
                DateTime endTime = startTime.AddSeconds(breathingActivity1.GetDuration());
                while (DateTime.Now < endTime)
                {
                    breathingActivity1.DisplayMessages();
                    breathingActivity1.TimerPause();
                }

                breathingActivity1.ShowEndMessage();
                Console.Clear();
            }

            else if (choice == 2)
            {
                ReflectionActivity reflectionActivity1 = new();
                reflectionActivity1.SpinnerPause();
                reflectionActivity1.ShowPrompt();

                reflectionActivity1.ShowQuestion();

                reflectionActivity1.ShowEndMessage();
                Console.Clear();
            }

            else if (choice == 3)
            {
                ListingActivity listingActivity1 = new();
                listingActivity1.SpinnerPause();
                listingActivity1.ShowPrompt();

                // response.Add(_responses);

                int numberResponses = listingActivity1.CountResponses();
                Console.WriteLine($"You wrote {numberResponses} items. ");

                listingActivity1.ShowEndMessage();
                Console.Clear();
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