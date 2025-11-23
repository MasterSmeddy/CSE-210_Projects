using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop05 World!");

        List<Goal> goals = new List<Goal>();

        Console.WriteLine("------ Eternal Quest Tracker ------\n");

        int pointTotal = 0;

        int input = 0;
        
        while (input != 6)
        {
            Console.WriteLine($"\nYou have {pointTotal} points");

            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit\n");

            Console.Write("Select a choice from the menu: ");
            string strInput = Console.ReadLine();
            input = int.Parse(strInput);

            if (input == 1)
            {
                Console.WriteLine("\nThe types of Goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");

                Console.Write("\nWhat type of goal would you like to create? ");
                string goalInput = Console.ReadLine();
                int goalChoice = int.Parse(goalInput);

                if (goalChoice == 1)
                {
                    Simple g = new Simple("", "", 0, false);
                    g.GetGoal();
                    goals.Add(g);
                }

                else if (goalChoice == 2)
                {
                    Eternal e = new Eternal("", "", 0);
                    e.GetGoal();
                    goals.Add(e);
                }

                else if (goalChoice == 3)
                {
                    Checklist c = new Checklist("", "", 0, 0, 0, 0, false);
                    c.GetGoal();
                    goals.Add(c);
                }
            }

            else if (input == 2)
            {
                for (int i = 0; i < goals.Count; i++)
                {
                    Console.Write($"{i + 1}.");
                    goals[i].DisplayGoal();
                }
            }

            else if (input == 3)
            {
                Console.Write("\nWhat is the filename for the goal file? ");
                string filename = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    outputFile.WriteLine(pointTotal);

                    foreach (Goal g in goals)
                    {
                        outputFile.WriteLine(g.GetStringRepresentation());
                    }
                }

                Console.WriteLine("[Goals Saved]");
            }

            else if (input == 4)
            {
                Console.Write("\nWhat is the filename for the goal file? ");
                string filename = Console.ReadLine();

                string[] lines = File.ReadAllLines(filename);

                pointTotal = int.Parse(lines[0]);

                goals.Clear();

                for (int i = 1; i < lines.Length; i++)
                {
                    string line = lines[i];

                    string[] parts = line.Split(":");
                    string goalType = parts[0];
                    string data = parts[1];

                    string[] fields = data.Split(",");

                    if (goalType == "Simple")
                    {
                        Simple s = new Simple(fields[0], fields[1], int.Parse(fields[2]), bool.Parse(fields[3]));
                        goals.Add(s);
                    }
                    else if (goalType == "Eternal")
                    {
                        Eternal e = new Eternal(fields[0], fields[1], int.Parse(fields[2]));
                        goals.Add(e);
                    }
                    else if (goalType == "Checklist")
                    {
                        Checklist c = new Checklist(fields[0], fields[1], int.Parse(fields[2]), int.Parse(fields[5]), int.Parse(fields[4]), int.Parse(fields[3]), bool.Parse(fields[6]));
                        goals.Add(c);
                    }

                }
            }

            else if (input == 5)
            {
                Console.Write("Which goal did you accomplish? ");
                int index = int.Parse(Console.ReadLine()) - 1;


                int earned = goals[index].RecordEvent();
                pointTotal += earned;

                Console.WriteLine($"Congratulations! You have now earned {earned}!");
                Console.WriteLine($"You now have {pointTotal} points.");
            }

            else if (input > 6 || input < 1)
            {
                Console.WriteLine("\nPlease enter a correlating integer");
                Thread.Sleep(1000);
            }

            else
            {
                Console.WriteLine("\nProgram Quit");
            } 
        }
    }
}