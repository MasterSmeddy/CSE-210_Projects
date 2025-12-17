using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // Introduction/Start Activity
    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"--- {_name} ---\n");
        Console.WriteLine(_description);
        _duration = UI.ReadInt("\nHow long, in seconds, would you like for your session? ");

        Console.WriteLine("\nGet ready...");
        Pause(3);
    }

    // Closing Message
    public void EndMessage()
    {
        Console.WriteLine("\n--- Time's up! ---");
        Pause(3);
        Console.WriteLine($"You have completed the {_name} for {_duration} seconds.");
        Pause(3);
    }

    protected DateTime GetEndTime()
    {
        return DateTime.Now.AddSeconds(_duration);
    }

    protected void Pause(int seconds)
    {
        string[] spinner = { "/", "-", "\\", "|" };
        int index = 0;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[index]);
            Thread.Sleep(250);
            Console.Write("\b \b");

            index = (index + 1) % spinner.Length;
        }
    }

    protected void Countdown(int seconds)
    {
        int remainingSeconds = seconds;

        while (remainingSeconds > 0)
        {
            Console.Write(remainingSeconds);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            remainingSeconds--;
        }
    }

}
