using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> listNumbers = new List<int>();
        int number = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (number != 0)
        {
            Console.Write("Enter number (0 to quit): ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                listNumbers.Add(number);
            }
        }
        int quantity = listNumbers.Count;
        int sum = 0;
        int maxPositive = 0;
        int minPositive = 999999;
        foreach (int num in listNumbers)
        {
            sum = sum + num;
            if (num > maxPositive)
            {
                maxPositive = num;
            }
            if (num < minPositive && num > 0)
            {
                minPositive = num;
            }
        }
        float avg = (float)sum / quantity; // it is necessary to convert at least one of the int numbers to float
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        if (maxPositive != 0 && minPositive != 999999) // to print only wheter exists positive numbers
        {
            Console.WriteLine($"The largest number is: {maxPositive}");
            Console.WriteLine($"The smallest positive number is: {minPositive}");
        }
        else
        {
            Console.WriteLine("There are no positive numbers in the list.");
        }
        listNumbers.Sort(); // sort the list
        Console.WriteLine("The sorted list is:");
        foreach (int num in listNumbers)
        {
            Console.WriteLine(num);
        }
    }
}