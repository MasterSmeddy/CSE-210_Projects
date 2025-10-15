public class Entry
{
    public string _entry;
    Prompt _prompt = new Prompt();

    // Get Journal Entry;
    public void ReceiveEntry()
    {
        DateTime date = DateTime.Now;
        string question = _prompt.ShowPrompt();
        Console.WriteLine(question);
        Console.Write(">");
        _entry = Console.ReadLine();
        _entry = $"Date: {date} - Prompt: {question}\n>{_entry}";
    }
    // Display Entries
    public void Display()
    {
        Console.WriteLine(_entry);
    }
}