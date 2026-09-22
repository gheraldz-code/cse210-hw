using System;
    /*
            For extra points, 
            1) Was developed a new class called ScriptureGenerator.
            2) In the class Scripture, the method HideRandomWords only works with words unhidden.
    */
class Program
{
    static void Main(string[] args)
    {
        //Reference aReference = new Reference("Proverbs", 3, 5, 6);
        //string textScripture = "Trust in the Lord with all thine heart; and lean not unto thine own understanding; In all thy ways acknowledge him, and he shall direct thy paths.";
        //Scripture theScripture = new Scripture(aReference, textScripture);
        ScriptureGenerator theRandom = new ScriptureGenerator();
        Scripture theScripture = theRandom.GetRandomScripture();
        
        Console.Clear();
        Console.WriteLine($"\n{theScripture.GetDisplayText()}");
        
        // 1st Condition: control if the scripture is not hidden yet
        while (!theScripture.IsCompletelyHidden())
        {
            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish:");
            
            string input = Console.ReadLine();// to know if "quit" was typed
            
            // 2nd Condition: it means if the user type quit
            if (input != null && input.Trim().ToLower() == "quit") // .Trim() to avoid spaces .ToLower() no case sensitive
            {
                return; // finish the program
            }
            
            theScripture.HideRandomWords(3); // after press Enter (except if the user typed quit)
            
            Console.Clear();
            Console.WriteLine("\n" + theScripture.GetDisplayText()); //another way to concat strings
        }
        
        // at the end of the program
        if (theScripture.IsCompletelyHidden())
        {
            Console.WriteLine("\n¡The scripture is completely hidden!");
        }
    }
}