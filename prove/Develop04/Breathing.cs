public class Breathing : Activity
{
    public Breathing(string name, string description) : base(name, description)
    {
        
    }

    public void Run()
    {
        StartActivity();

        DateTime endTime = GetEndTime();

        // Start breathing
        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in... ");
            Countdown(4);

            // Time up? Kill timer
            if (DateTime.Now >= endTime)
            {
                break;
            }

            Console.Write("\nNow breathe out... ");
            Countdown(5);
        }

        EndMessage();
    }
}
