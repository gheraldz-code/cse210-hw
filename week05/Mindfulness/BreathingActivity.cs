// a class that inherits from Activity
public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
    }

    public void Run(int seconds)
    {
        Console.WriteLine("Get ready...");
        ShowCountdown(3);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            ShowCountdown(4);

            Console.WriteLine();

            Console.Write("Breathe out...");
            ShowCountdown(6);

            Console.WriteLine();
        }
    }
}