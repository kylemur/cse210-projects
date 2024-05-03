using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
    
        // Console.Write("What is the magic number? ");
        // string numberStr = Console.ReadLine();
        // int number = int.Parse(numberStr);

        string again = "yes";
        while (again == "yes")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);

            int attempt = 0;

            string playing = "yes";
            while (playing == "yes")
            {
                Console.Write("What is your guess? ");
                string guessStr = Console.ReadLine();
                int guess = int.Parse(guessStr);

                if (guess == number)
                {
                    Console.WriteLine("You guessed it!");
                    playing = "no";
                }

                if (guess > number)
                {
                    Console.WriteLine("Guess lower");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Guess higher");
                }

                attempt++;
            }

            Console.WriteLine($"You took {attempt} attempts. ");

            Console.Write("Do you want to play again? ");
            again = Console.ReadLine();
        }
        Console.WriteLine("Goodbye");
    }
}