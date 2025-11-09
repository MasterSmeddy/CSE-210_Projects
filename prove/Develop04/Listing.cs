public class Listing : Activity
{
    private List<string> _listeningQuestions = new List<string>();
    private Random _random = new Random();
    private int _bufferDuration;

    public Listing(string name, string description, int duration) : base(name, description, duration)
    {

    }
    
    public void DisplayListingPrompt()
    {
        
    }
}