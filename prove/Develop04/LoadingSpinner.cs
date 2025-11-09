public class LoadingSpinner
{
    public void Loading()
    {
        int i = 3;
        while (i != 0)
        {
            Console.Write("\\");
            Thread.Sleep(200);
            Console.Write("\b \b");

            Console.Write("|");
            Thread.Sleep(200);
            Console.Write("\b \b");

            Console.Write("/");
            Thread.Sleep(200);
            Console.Write("\b \b");
            
            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b \b");

            i -= 1;
        }
    }
}