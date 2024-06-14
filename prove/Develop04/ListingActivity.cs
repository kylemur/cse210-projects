public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private List<string> _responses = new();

    public ListingActivity() : base()
    {
        SetActivityName("Listing Activity");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        ShowStartMessage();

        Console.Write("\nHow long (in seconds) would you like for your session? ");
        int _activityDuration = int.Parse(Console.ReadLine());
        SetDuration(_activityDuration);

        Console.WriteLine("Get ready... ");
        SpinnerPause();
        Console.Clear();
    }

    public void ShowPrompt()
    {
        int i = CycleThroughList(_prompts, _cycles);
        Console.WriteLine(_prompts[i]);
    }
    public void AddResponse()
    {
        Console.Write("Item: "); 
        _responses.Add(Console.ReadLine());
    }
    public int CountResponses()
    {
        return _responses.Count;
    }
}