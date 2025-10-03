public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"\nName:\n\t{_name}\nJobs:");

        foreach (Job theJob in _jobs)
        {
            Console.Write("\t");
            theJob.DisplayJobInfo();
        }
    }
}