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
        Journal journal = new Journal();

        // MENU | Option Select
        while (choice != 5)
        {
            choice = menu.DisplayMenu();

            // WRITE
            if (choice == 1)
            {
                Entry entry = new Entry();
                entry.ReceiveEntry();
                journal.AddEntry(entry);
                Console.WriteLine();
            }

            // DISPLAY
            else if (choice == 2)
            {
                Console.WriteLine();
                journal.DisplayListOfEntries();
            }

            // LOAD
            else if (choice == 3)
            {
                journal.ReadFromFile();
            }

            // SAVE
            else if (choice == 4)
            {
                journal.SaveToFile();
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