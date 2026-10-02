// a class that inherits from Activity
public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
    }

    public void Run()
    {
        Console.WriteLine("Get ready to start the breathing exercise...");
        System.Threading.Thread.Sleep(2000); // Wait for 2 seconds
        Start();
    }
}