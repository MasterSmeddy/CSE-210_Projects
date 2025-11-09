public class Breathing : Activity
{

    public Breathing(string name, string description, int duration) : base(name, description, duration)
    {
        
    }

    public void DisplayBreathe()
    {
        Console.WriteLine();

        while (_timerFinished == false)
        {
            Console.WriteLine("\n");

            for (int i = 4; i > 0; i--)
            {
                if (_timerFinished == true)
                {
                    break;
                }
                Console.Write($"\rBreathe in...{i}");
                Thread.Sleep(1000);
            }

            Console.WriteLine("\n");

            for (int i = 5; i > 0; i--)
            {
                if (_timerFinished == true)
                {
                    break;
                }
                Console.Write($"\rNow breathe out...{i}");
                Thread.Sleep(1000);
            }

            Console.Write("\r                      ");
        }
    }
}