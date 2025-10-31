using System;

class Program
{
    static void Main(string[] args)
    {
        // Variables
        Reference r1 = new Reference("Romans", 8, 37);
        Reference r2 = new Reference("Romans", 8, 37, 38);
        Reference r3 = new Reference("Romans", 8, 37, 39);

        string verseOne = "Nay, in all these things we are more than conquerors through him that loved us.";
        string verseTwo = "For I am persuaded, that neither death, nor life, nor angels, nor principalities, nor powers, nor things present, nor things to come,";
        string verseThree = "Nor height, nor depth, nor any other creature, shall be able to separate us from the love of God, which is in Christ Jesus our Lord.";

        Scripture s1 = new Scripture(r1, verseOne);
        Scripture s2 = new Scripture(r2, verseOne + " " + verseTwo + "...");
        Scripture s3 = new Scripture(r2, verseOne + " " + verseTwo + " " + verseThree);

        bool notDone = true;

        // Loop until finished
        while (notDone == true)
        {
            Console.WriteLine("Welcome to the Scripture Memorizer!\n");
            
            r1.DisplayReference();                            // Change
            s1.DisplayScripture();                           // These
            s1.SwitchRandomWords();                         // Variables

            Console.WriteLine();
            string enter = Console.ReadLine();
            Console.Clear();

            //// Handle Quitting Program
            // Manual Quit
            if (enter == "quit")
            {
                Console.WriteLine("Program Quit");
                notDone = false;
            }
            // If Scripture is Hidden ----> Quit
            else if (s1.CheckScripture())               // This one too!
            {
                Console.WriteLine("\nScripture Complete!\n");
                notDone = false;
            }
        }
    }
}