// a class that inherits from Activity
public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "List as many things as you can that you are grateful for.",
        "List as many personal strengths as you can.",
        "List as many people who have positively influenced your life.",
        "List as many accomplishments as you can.",
        "List as many things that make you happy."
    };
    private List<string> _availablePrompts; // additional list
    private Random _random = new Random();

    public ListingActivity(string name, string description, int duration, int count)
        : base(name, description, duration)
    {
        _count = count;
        _availablePrompts = new List<string>(_prompts); // copy from _prompts
    }

    public string GetRandomPrompt() // random the list
    {
        if (_availablePrompts.Count == 0) // if the list is empty
        {
            _availablePrompts = new List<string>(_prompts); // copy again from _prompts
        }

        int index = _random.Next(_availablePrompts.Count);

        string prompt = _availablePrompts[index];

        _availablePrompts.RemoveAt(index); // to avoid repetition

        return prompt;
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        string prompt = GetRandomPrompt();

        Console.WriteLine();
        Console.WriteLine($"Prompt: {prompt}");

        Console.WriteLine();
        Console.Write("You may begin in: ");
        ShowCountdown(5);

        Console.WriteLine();
        Console.WriteLine("Start listing:");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        _count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string answer = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(answer))
            {
                _count++;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {_count} items.");
    }
}