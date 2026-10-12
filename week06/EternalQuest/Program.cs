using System;

/*
Extra Points

I added a leveling system based on the player's tota score with a method in GoalManager.
*/

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        int option = 0;
        string filename = "goals.txt"; // by default
        string inputFilename;

        Console.Clear();

        while (option != 6)
        {
            Console.WriteLine("\nEternal Quest");
            Console.WriteLine("--------------------");
            manager.DisplayScore();
            manager.DisplayLevel();

            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out option))
            {
                switch (option)
                {
                    case 1:
                        manager.CreateGoal();
                        break;

                    case 2:
                        manager.DisplayGoals();
                        break;

                    case 3:
                        Console.Write("What is the filename for the goal file? ");
                        inputFilename = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(inputFilename))
                        {
                            filename = inputFilename;
                        }

                        manager.SaveGoals(filename);
                        break;

                    case 4:
                        Console.Write("What is the filename to load? ");
                        inputFilename = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(inputFilename))
                        {
                            filename = inputFilename;
                        }

                        manager.LoadGoals(filename);
                        break;

                    case 5:
                        manager.RecordGoalEvent();
                        break;

                    case 6:
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Please select an option from 1 to 6.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
                option = 0;
            }
        }
    }
}