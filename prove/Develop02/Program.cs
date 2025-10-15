using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        // Declare Variables & New Objects
        int choice = 0;
        Menu menu = new Menu();
        List<Entry> journal = new List<Entry>();

        while (choice != 5)
        {
            choice = menu.DisplayMenu();

            // WRITE
            if (choice == 1)
            {
                Entry entry = new Entry();
                entry.ReceiveEntry();
                journal.Add(entry);

            }

            // DISPLAY
            else if (choice == 2)
            {
                foreach (Entry entry in journal)
                {
                    entry.Display();
                    Console.WriteLine();
                }
            }

            // LOAD
            else if (choice == 3)
            {
                // Code here
            }

            // SAVE
            else if (choice == 4)
            {
                // Code here                
            }

            // QUIT
            else
            {
                if (choice != 5)
                    Console.WriteLine("\n[Invalid Input] Please try again.\n");
            }
            
        }
            Console.WriteLine("\n[Program Quit]\n");

    }
}