using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is your magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        int guesses = 0;

        while (guess != magicNumber)
        {
            guesses++;
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > magicNumber)
            {
                Console.WriteLine("Your guess is Higher than the magic number.");
            }

            else if (guess < magicNumber)
            {
                Console.WriteLine("Your guess is Lower than the magic number.");
            }

            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
        Console.WriteLine($"It took you {guesses} guesses.");
        
    }
}