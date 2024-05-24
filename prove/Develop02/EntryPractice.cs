// // Chooses a random prompt, allows the user to enter a response, 
// // and adds the date as part of the entry.

// public class Entry
// {
//     private List<string> _entries;

//     public Entry()
//     {
//         // Initialize the list
//         _entries = new List<string>();

//         _entries.Add(_entry);
//     }
//     Prompt _prompt = new Prompt();
//     string _promptQuestion = _prompt.ChoosePrompt();

//     public string _response;
//     // _response = Console.ReadLine();


//     public DateTime theCurrentTime = DateTime.Now;
//     public string dateText = theCurrentTime.ToShortDateString();
    

//     // _date = string GetDate();

//     public string _entry = $"Date: {dateText} - Prompt: {_promptQuestion} \n{_response}";


//     // public string GetDate()
//     // {
//     //     DateTime theCurrentTime = DateTime.Now;
//     //     string dateText = theCurrentTime.ToShortDateString();
//     //     return dateText;
//     // }

//     // public void Display()
//     // {
//     //     Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
//     //     Console.WriteLine(_response);
//     // }
//     public void Display()
//     {
//         Console.WriteLine($"{_entry}");
//     }

// }