using System;
using System.ComponentModel;
/*
    For extra points:
    1) Added ShowActivityLog to show a summary of the activities
    2) There are no repeated questions or prompts
    3) Added a new option in the menu to show the summary
*/
class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        BreathingActivity breathing;
        ListingActivity listing;
        ReflectingActivity reflecting;
        string option;
        int theTime = 0;

        do {
            Console.Clear();
            
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Show activity log");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice from the menu: ");
            option = Console.ReadLine().ToString();

            if (option.Trim() == "1")
            {
                Console.Clear();

                Console.Write("How long, in seconds, would you like for your session? ");
                theTime = int.Parse(Console.ReadLine());

                breathing = new BreathingActivity(
                    "Breathing Activity",
                    "This activity will help you relax by guiding you through slow breathing.",
                    theTime
                );

                breathing.Run(theTime);

                breathing.DisplayEndingMessage();

                activities.Add(breathing);

                Console.WriteLine("Press Enter to return to the menu.");
                Console.ReadLine();
            }
            else if (option.Trim() == "2")
            {
                Console.Clear();

                Console.Write("How long, in seconds, would you like for your session? ");
                theTime = int.Parse(Console.ReadLine());

                reflecting = new ReflectingActivity(
                    "Reflecting Activity",
                    "This activity will help you reflect on times in your life when you have shown strength and resilience.",
                    theTime
                );

                reflecting.Run();

                reflecting.DisplayEndingMessage();

                activities.Add(reflecting);

                Console.WriteLine("Press Enter to return to the menu.");
                Console.ReadLine();
            }
            else if (option.Trim() == "3")
            {
                Console.Clear();

                Console.Write("How long, in seconds, would you like for your session? ");
                theTime = int.Parse(Console.ReadLine());

                listing = new ListingActivity(
                    "Listing Activity",
                    "This activity will help you reflect on the good things in your life by having you list as many things as you can.",
                    theTime,
                    0
                );

                listing.Run();

                listing.DisplayEndingMessage();

                activities.Add(listing);

                Console.WriteLine("Press Enter to return to the menu.");
                Console.ReadLine();
            }
            else if (option.Trim() == "4")
            {
                Console.Clear();

                ShowActivityLog(activities);

                Console.WriteLine();
                Console.WriteLine("Press Enter to return to the menu.");
                Console.ReadLine();
            }
            else if (option.Trim() == "5")
            {
                Console.Clear();

                ShowActivityLog(activities); // call the procedure

                Console.WriteLine();
                Console.WriteLine("See you soon!");
            }
            else
            {
                Console.WriteLine("Invalid option.");
                Console.WriteLine("Press Enter to continue.");
                Console.ReadLine();
            }
        } while (option.Trim() != "5");
    }

    static void ShowActivityLog(List<Activity> activities) // keep the count for activity
    {
        int breathingCount = 0;
        int reflectingCount = 0;
        int listingCount = 0;

        foreach (Activity activity in activities)
        {
            if (activity.GetName() == "Breathing Activity")
            {
                breathingCount++;
            }
            else if (activity.GetName() == "Reflecting Activity")
            {
                reflectingCount++;
            }
            else if (activity.GetName() == "Listing Activity")
            {
                listingCount++;
            }
        }
        // print the quantity for each activity
        Console.WriteLine("Activity Log:");
        Console.WriteLine($"Breathing Activity: {breathingCount} times");
        Console.WriteLine($"Reflecting Activity: {reflectingCount} times");
        Console.WriteLine($"Listing Activity: {listingCount} times");
        Console.WriteLine($"Total activities: {activities.Count}");
    }
}