public class Prompt
{
    public Random _random = new Random();
    
    // Prompt Questions List
    public List<string> _questions = new List<string>
    {
        "What song would be the theme song for today? Why?",
        "What happened today that I could call a spiritual experience?",
        "Who stood out to me the most today?",
        "What was my biggest accomplishment today?",
        "If I could change one thing that happened today, what would it be?",
        "What impacted me the most today?",
        "How am I doing today?"
    };

    // Generate Random Prompt from List
    public string ShowPrompt()
    {
        int promptNum = _random.Next(_questions.Count);

        return _questions[promptNum];
    }

    }

