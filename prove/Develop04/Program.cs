using System;

class Program
{
    static void Main(string[] args)
    {
        // Create activities
        Breathing breathing = new Breathing(
            "Breathing Activity",
            "This activity will help you relax by walking you through breathing " +
            "in and out slowly. Clear your mind and focus on your breathing."
        );

        Reflection reflection = new Reflection(
            "Reflection Activity",
            "This activity will help you reflect on times in your life when you " +
            "have shown strength and resilience. This will help you recognize the " +
            "power you have and how you can use it in other aspects of your life."
        );

        Listing listing = new Listing(
            "Listing Activity",
            "This activity will help you reflect on the good things in your life " +
            "by having you list as many things as you can in a certain area."
        );

        bool keepRunning = true;

        Console.WriteLine("\n----- Welcome to the Mindfulness Program -----");

        while (keepRunning)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflection Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");

            int input = UI.ReadInt("\nSelect a choice from the menu: ");
            Console.Clear();

            switch (input)
            {
                case 1:
                    breathing.Run();
                    break;

                case 2:
                    reflection.Run();
                    break;

                case 3:
                    listing.Run();
                    break;

                case 4:
                    keepRunning = false;
                    break;

                default:
                    Console.WriteLine("Please enter a number between 1 and 4.");
                    break;
            }
        }

        Console.WriteLine("\nThank you for using the Mindfulness Program. Goodbye!\n");
    }

}

public static class UI
{
    public static int ReadInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);

            if (int.TryParse(Console.ReadLine(), out int value))
            {
                return value;
            }
            
            Console.WriteLine("\n-- Invalid Input: [Please enter an integer] --");
        }
    }
}
