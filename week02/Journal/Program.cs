using System;
using System.IO.Enumeration;
using System.Runtime.InteropServices;
/*
For extra points:
1) Added two methods to assure to save the journal when there are changes
*/
class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        Entry anEntry = new Entry();
        PromptGenerator thePrompt = new PromptGenerator();
        string option;
        string v_prompt;
        string v_filename;
        string answer = "n";
        do {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            option = Console.ReadLine();

            if (option.Trim() == "1")
            {
                DateTime theCurrentTime = DateTime.Now;
                v_prompt = thePrompt.GetRandomPrompt();
                Console.WriteLine(v_prompt);
                Console.Write("> ");
                anEntry._date = theCurrentTime.ToShortDateString();
                anEntry._promptText = v_prompt;
                anEntry._entryText = Console.ReadLine();
                theJournal.AddEntry(anEntry);
            }
            else if (option.Trim() == "2")
            {
                theJournal.DisplayAll();
            }
            else if (option.Trim() == "3")
            {
                Console.WriteLine("What is the filename?");
                v_filename = Console.ReadLine();
                theJournal.LoadFromFile(v_filename);
            }
            else if (option.Trim() == "4")
            {
                Console.WriteLine("Write a filename: ");
                v_filename = Console.ReadLine();
                theJournal.SaveToFile(v_filename);
            }
            else
            {
                Console.WriteLine("Write into your journal everyday!");
            }
        } while (option != "5");
        if (option == "5")
        {
            if (!theJournal.WasSaved() && theJournal.HasJournalData() == 1)
            {
                Console.WriteLine("You have no saved changes.");
                Console.Write("Do you want to save? (y/n): ");
                answer = Console.ReadLine().ToLower();
                if (answer == "y")
                {
                    Console.WriteLine("Write a filename: ");
                    v_filename = Console.ReadLine();
                    theJournal.SaveToFile(v_filename);
                }
                else
                {
                    Console.WriteLine("Good job by writing your journal today.");
                }
            }
            else
            {
                Console.WriteLine("You can write your jounal the next time.");
            }
            
        }
    }
}