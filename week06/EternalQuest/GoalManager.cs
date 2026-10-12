using System;
using System.IO;
using System.Collections.Generic;

/*
For extra points

I added the method DisplayLevel() which will show the progress by earning points
*/

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public int GetScore()
    {
        return _score;
    }

    public void RecordEvent(int index)
    {
        Goal goal = _goals[index];

        // Avoid duplicating a completed goal
        if (goal.IsComplete())
        {
            Console.WriteLine("Esta meta ya está completa.");
            return;
        }

        // Cada tipo de meta ejecuta su propia implementación.
        goal.RecordEvent(); // each child class execute its own behavior

        _score += goal.GetPoints();

        if (goal is ChecklistGoal checklist && checklist.IsComplete())
        {
            _score += checklist.GetBonus();
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Your Goals:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        string choice = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        Goal goal = null;

        switch (choice)
        {
            case "1":
                goal = new SimpleGoal(name, description, points);
                break;

            case "2":
                goal = new EternalGoal(name, description, points);
                break;

            case "3":
                Console.Write("How many times does this goal need to be accomplished? ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it? ");
                int bonus = int.Parse(Console.ReadLine());

                goal = new ChecklistGoal(name, description, points, target, bonus);
                break;

            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        AddGoal(goal);

        Console.WriteLine("Goal created successfully!");
    }

    public void RecordGoalEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You don't have any goals yet.");
            return;
        }

        Console.WriteLine("\nThe goals are:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetGoalName()}");
        }

        Console.Write("Which goal did you accomplish? ");

        if (!int.TryParse(Console.ReadLine(), out int choice))
        {
            Console.WriteLine("Please enter a valid number.");
            return;
        }

        if (choice < 1 || choice > _goals.Count)
        {
            Console.WriteLine("That goal number does not exist.");
            return;
        }

        RecordEvent(choice - 1);

        Console.WriteLine("Event recorded!");
        DisplayScore();
    }
    
    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully!");
    }
    
    public void LoadGoals(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);

        if (lines.Length == 0 ||
            !int.TryParse(lines[0], out int savedScore))
        {
            Console.WriteLine("The file is empty or has an invalid score.");
            return;
        }

        _goals.Clear();
        _score = savedScore;

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(',');

            switch (parts[0])
            {
                case "SimpleGoal":
                    SimpleGoal simple = new SimpleGoal(
                        parts[1],
                        parts[2],
                        int.Parse(parts[3]));

                    simple.SetComplete(bool.Parse(parts[4]));
                    AddGoal(simple);
                    break;

                case "EternalGoal":
                    EternalGoal eternal = new EternalGoal(
                        parts[1],
                        parts[2],
                        int.Parse(parts[3]));

                    AddGoal(eternal);
                    break;

                case "ChecklistGoal":
                    ChecklistGoal checklist = new ChecklistGoal(
                        parts[1],
                        parts[2],
                        int.Parse(parts[3]),
                        int.Parse(parts[5]),
                        int.Parse(parts[6]));

                    checklist.SetAmountCompleted(int.Parse(parts[4]));
                    AddGoal(checklist);
                    break;

                default:
                    Console.WriteLine($"Unknown goal type on line {i + 1}.");
                    break;
            }
        }

        Console.WriteLine("Goals loaded successfully!");
    }
    
    public void DisplayLevel()
    {
        int level;
        string title;

        if (_score >= 2000)
        {
            level = 4;
            title = "Master of the Quest";
        }
        else if (_score >= 1000)
        {
            level = 3;
            title = "Champion";
        }
        else if (_score >= 500)
        {
            level = 2;
            title = "Adventurer";
        }
        else
        {
            level = 1;
            title = "Beginner";
        }

        Console.WriteLine($"Level: {level} - {title}");
    }
}