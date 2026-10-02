public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void Start()
    {
        Console.WriteLine($"Starting {_name} for {_duration} seconds.");
        Console.WriteLine(_description);
        System.Threading.Thread.Sleep(_duration * 1000); // Wait for the specified duration
        Console.WriteLine($"Finished {_name}.");
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine(_description);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Thank you for participating in the {_name}.");
    }

    public void ShowSpinner(int seconds){

    }

    public void ShowCountdown(int seconds){

    }
}