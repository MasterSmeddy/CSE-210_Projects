public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;
    protected bool _timerFinished = false;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayActivityInfo()
    {
        Console.WriteLine($"\n---{_name}---\n{_description}\n");
    }

    public int GetBackgroundTimer()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        string strDuration = Console.ReadLine();
        _duration = int.Parse(strDuration);

        return _duration;
    }

    // I had AI help me with Thread and DateTime to make a timer, since
    // I don't know how to do it and Stack Overflow didn't appear to
    // have the answer. And Drop-In Lab was already finished.
    public void SetBackgroundTimer()
    {
        _timerFinished = false;
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        Thread timerThread = new Thread(() =>
        {
            while (DateTime.Now < endTime)
            {
                Thread.Sleep(1000);
            }

            _timerFinished = true;
            Console.WriteLine("\n\nTime's up!\n");
            Thread.Sleep(3000);
        });

        timerThread.Start();

    }

    public bool IsTimerFinished()
    {
        return _timerFinished;
    }
    
}