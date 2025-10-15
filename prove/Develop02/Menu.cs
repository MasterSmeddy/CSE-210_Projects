public class Menu
{
    public int DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        Console.Write("What would you like to do? ");
        string choiceStr = Console.ReadLine();
        int choiceNum = int.Parse(choiceStr);

        return choiceNum;
    }
}