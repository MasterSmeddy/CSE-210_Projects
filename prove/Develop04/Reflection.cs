public class Reflection : Activity
{
    private Random _random = new Random();
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        "Think of a time when you were really happy."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What did you learn about yourself?",
        "How can you use this experience in the future?"
    };


    public Reflection(string name, string description) : base(name, description)
    {
        
    }

    public void Run()
    {
        StartActivity();

        Console.WriteLine();
        Console.WriteLine(">> " + _prompts[_random.Next(_prompts.Count)]);
        Pause(5);

        // Copy questions into separate list
        List<string> remainingQuestions = new List<string>(_questions);

        DateTime endTime = GetEndTime();

        while (DateTime.Now < endTime)
        {
            // All questions done? Reset list index
            if (remainingQuestions.Count == 0)
            {
                remainingQuestions = new List<string>(_questions);
            }

            // Pick random question from remaining ones
            int index = _random.Next(remainingQuestions.Count);
            string question = remainingQuestions[index];

            Console.WriteLine("> " + question);

            // Remove question from list
            remainingQuestions.RemoveAt(index);

            Pause(5);
        }

        EndMessage();
    }
}
