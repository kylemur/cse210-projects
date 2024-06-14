public class BreathingActivity : Activity
{
    private List<string> _messages = new List<string>();

    public BreathingActivity() : base()
    {
        SetActivityName("Breathing Activity");
        SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");

        ShowStartMessage();
        Console.Write("\nHow long (in seconds) would you like for your session? ");
        int _activityDuration = int.Parse(Console.ReadLine());
        SetDuration(_activityDuration);

        _messages.Add("Breathe in...");
        _messages.Add("Breathe out...");
    }

    public void DisplayMessages()
    {
        int i = CycleThroughList(_messages, _cycles);
        Console.WriteLine(_messages[i]);
    }
}