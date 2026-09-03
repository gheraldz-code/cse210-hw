using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("Write your grade percentage: ");
        string answer = Console.ReadLine();
        int gradePercent = int.Parse(answer);
        string letter = "";

        if (gradePercent >= 90)
        {
            letter = "A";
        }
        else if (gradePercent >= 80)
        {
            letter = "B";
        }
        else if (gradePercent >= 70)
        {
            letter = "C";
        }
        else if (gradePercent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        string sign = "";
        int unit = gradePercent % 10;
        if (unit >= 7 && unit <= 9 && letter != "A" && letter != "F")
        {
            sign = "+";
        }
        else if (unit >= 0 && unit <= 2 && gradePercent != 100 && letter != "F")
        {
            sign = "-";
        }
        Console.WriteLine($"Your grade is {letter}{sign}");

        if (gradePercent > 70)
        {
            Console.WriteLine("Congrats, you passed!");
        }
        else
        {
            Console.WriteLine("Try again the next period!");
        }
    }
}