public class Prompt
{
    public Random _random = new Random();
    public List<string> _questions = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
    };

    public string ShowPrompt()
    {
        int promptNum = _random.Next(_questions.Count);

        return _questions[promptNum];
    }

    }

