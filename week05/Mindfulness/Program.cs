using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Console.Clear();
        for (int i = 0; i > 0; i--)
        {
            Console.WriteLine("Take a deep breath in...");
            System.Threading.Thread.Sleep(2000); // Wait for 2 seconds
            Console.WriteLine("Now exhale slowly...");
            System.Threading.Thread.Sleep(2000); // Wait for 2 seconds
            Console.Clear();
        }
    }
}