using System;
using System.Collections.Generic;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        // Create numbers list and prompts user
        List<int> numbers = new List<int>();
        int numberAdded = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // User input gets appended/added to numbers list
        while (numberAdded != 0)
        {
            Console.Write("Enter number: ");
            numberAdded = int.Parse(Console.ReadLine());

            if (numberAdded != 0)
            {
                numbers.Add(numberAdded);
            }

        }

        // Handle Sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum of the list is: {sum}");

        // Handle Average
        float avg = ((float)sum) / numbers.Count;

        Console.WriteLine($"The average of the list is: {avg}");

        // Max Number
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max number is: {max}");
    }
}