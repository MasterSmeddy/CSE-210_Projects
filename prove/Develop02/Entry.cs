public class Entry
{
    private string _entry;
    Prompt _prompt = new Prompt();
    
    public void ReceiveEntry()
    {
        Console.Write("Enter the current date: ");
        string date = Console.ReadLine();
        string question = _prompt.ShowPrompt();
        Console.WriteLine(question);
        _entry = Console.ReadLine();
        _entry = $"Date: {date} - Prompt: {question}\n{_entry}";




    }
    public void Display()
    {
    
        Console.WriteLine(_entry);

    }
    
}