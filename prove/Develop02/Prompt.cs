// Holds just one prompt. In Program.cs, 
// I will make a different object for each prompt and add it to _prompts list.
using System;
using System.Collections.Generic;

public class Prompt
{
    private List<string> _prompts;

    public Prompt()
    {
        // Initialize the list
        _prompts = new List<string>();

        // Add items to the list
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");

    }
    
    public string ChoosePrompt()
    {
         // Initialize the Random object
        Random random = new Random();

        // Generate a random index
        int randomIndex = random.Next(_prompts.Count);

        // Retrieve the random prompt from the list
        string randomPrompt = _prompts[randomIndex];
        return randomPrompt;
    }
    public void Display()
        {
            string _randomPrompt = ChoosePrompt();
            Console.WriteLine(_randomPrompt);
        }
}