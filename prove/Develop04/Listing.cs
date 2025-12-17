public class Listing : Activity
{
    private Random _random = new Random();
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who have you helped recently?",
        "Who are some of your personal heroes?",
        "What activity brings you the most joy?"
    };

    public Listing(string name, string description) : base(name, description)
    {
        
    }

    public void Run()
    {
        StartActivity();

        Console.WriteLine();
        Console.WriteLine(_prompts[_random.Next(_prompts.Count)]);
        Console.WriteLine("\nYou may begin listing items in: ");
        Countdown(5);

        DateTime endTime = GetEndTime();
        List<string> items = new List<string>();

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");

        EndMessage();
    }
}
