using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int theNumber = randomGenerator.Next(1, 101);
        int guessed;
        int attempts = 0;
        Console.WriteLine("What is the magic number? (you only have 6 attempts)");
        do
            {
                Console.Write("What is your guess? ");
                guessed = int.Parse(Console.ReadLine());
                attempts ++; // increase the counter +1
                if (guessed > theNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guessed < theNumber)
                {
                    Console.WriteLine("Higher");
                }
            } while (guessed != theNumber && attempts < 7);
        
        if (guessed == theNumber)
        {
            Console.WriteLine($"You guessed it in {attempts} attempts!");
        }
        else
        {
            Console.WriteLine($"Sorry, the number was {theNumber}, but you used up your {attempts} attempts!");
        }
    }
        
}