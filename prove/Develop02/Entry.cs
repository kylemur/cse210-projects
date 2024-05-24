public class Entry
{
    //private string _prompt;

    public string _date;
    public string _prompt;
    public string _response;


    public Entry()
    {
        _prompt = new Prompt().ChoosePrompt();
        // Console.WriteLine(_prompt);
        // _response = Console.ReadLine();
        // _date = DateTime.Now.ToShortDateString();
    }

    public string GetPrompt()
    {
        return _prompt = new Prompt().ChoosePrompt();
    }
    public string GetDate()
    {
        return _date = DateTime.Now.ToShortDateString();
    }
    public void Display()
    {
        Console.WriteLine($"{_date} - {_prompt} \n{_response}");
    }
}