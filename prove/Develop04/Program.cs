using System;

class Program
{
    static void Main(string[] args)
    {
        LoadingSpinner s = new LoadingSpinner();

        Breathing breathing = new Breathing
        (
            "Breathing Activity", "This activity will help you relax by walking " +
            "your through breathing in and out slowly. Clear your mind and focus " +
            "on your breathing.",
            10
        );

        Reflection reflection = new Reflection
        (
            "Reflection Activity",
            "This activity will help you reflect on times in your life when you " +
            "have shown strength and resilience. This will help you recognize the " +
            "power you have and how you can use it in other aspects of your life.",
            10
        );

        Listing listing = new Listing
        (
            "Listing Activity",

            "This activity will help you reflect on the good things in your life " +
            "by having you list as many things as you can in a certain area.",
            10
        );

        Console.WriteLine("\n ----- Welcome to the Mindfulness Activity -----");

        int choice = 0;
        bool keepRunning = true;

        while (keepRunning)
        {
            // MENU
            Console.WriteLine("\nMenu Options: ");
            Console.WriteLine("\t1. Start Breathing Activity");
            Console.WriteLine("\t2. Start Reflection Activity");
            Console.WriteLine("\t3. Start Listing Activity");
            Console.WriteLine("\t4. Start 4th Activity");
            Console.WriteLine("\t5. Quit");
            Console.Write("\nSelect a choice from the menu: ");

            // Handle Invalid or Empty Datatype
            try
            {
                string result = Console.ReadLine();
                choice = int.Parse(result);
            }

            catch (FormatException ex)
            {
                Console.WriteLine("\n[Error: Invalid Format Detected]");
                Console.WriteLine($"Exception Message: {ex.Message}");
                continue;
            }


            /// CHOICES / ACTIVITY

            // BREATHING ACTIVITY
            if (choice == 1)
            {
                breathing.DisplayActivityInfo();
                breathing.GetBackgroundTimer();
                Console.WriteLine("Get ready...");
                s.Loading();
                breathing.SetBackgroundTimer();
                breathing.DisplayBreathe();
            }

            // REFLECTION ACTIVITY
            else if (choice == 2)
            {
                reflection.DisplayActivityInfo();
                reflection.GetBackgroundTimer();
                Console.WriteLine("Get ready...");
                s.Loading();
                reflection.SetBackgroundTimer();
            }

            // LISTING ACTIVITY
            else if (choice == 3)
            {
                listing.DisplayActivityInfo();
                listing.GetBackgroundTimer();
                Console.WriteLine("Get ready...");
                s.Loading();
                listing.SetBackgroundTimer();
            }

            // 4TH ACTIVITY
            else if (choice == 4)
            {
                Console.WriteLine("\n4th Activity");
            }

            // QUIT PROGRAM
            else if (choice == 5)
            {
                keepRunning = false;
            }

            else
            {
                Console.WriteLine("\nPlease enter a number between 1-5!");
            }
        }

        Console.WriteLine("\nProgram Quit\n");
    }

}