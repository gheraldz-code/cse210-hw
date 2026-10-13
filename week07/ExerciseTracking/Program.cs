using System;

class Program
{
    
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.\n");
        
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("13 Oct 2026", 20, 5.0));
        activities.Add(new Cycling("13 Oct 2026", 30, 20.0));
        activities.Add(new Swimming("13 Oct 2026", 30, 40));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
        Console.WriteLine();
    }
}