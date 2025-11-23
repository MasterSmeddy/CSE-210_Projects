public class Cat : Animal, IFeline
{
    public override string GetSound()
    {
        return "meow";
    }

    public void Scratch()
    {
        // Do something
    }

    public void Purr()
    {
        // Do something
    }
}