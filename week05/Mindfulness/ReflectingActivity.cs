public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    private List<string> _availablePrompts;
    private List<string> _availableQuestions;
    private Random _random = new Random();

    public ReflectingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
        _prompts = new List<string>
        {
            "Think of a time when you overcame a challenge.",
            "Recall a moment when you felt truly happy.",
            "Reflect on a time when you helped someone in need.",
            "Think about a personal achievement that made you proud."
        };

        _questions = new List<string>
        {
            "What did you learn from this experience?",
            "How did this experience shape who you are today?",
            "What emotions did you feel during this time?",
            "How can you apply the lessons learned to your future?"
        };

        _availablePrompts = new List<string>(_prompts);
        _availableQuestions = new List<string>(_questions);
    }

    public string GetRandomPrompt()
    {
        if (_availablePrompts.Count == 0)
        {
            _availablePrompts = new List<string>(_prompts);
        }

        int index = _random.Next(_availablePrompts.Count);

        string prompt = _availablePrompts[index];

        _availablePrompts.RemoveAt(index);

        return prompt;
    }

    public string GetRandomQuestion()
    {
        if (_availableQuestions.Count == 0)
        {
            _availableQuestions = new List<string>(_questions);
        }

        int index = _random.Next(_availableQuestions.Count);

        string question = _availableQuestions[index];

        _availableQuestions.RemoveAt(index);

        return question;
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
    }

    public void DisplayQuestion()
    {
        string question = GetRandomQuestion();
        Console.WriteLine($"Question: {question}");
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        Console.WriteLine();
        DisplayPrompt();

        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press Enter.");
        Console.ReadLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            DisplayQuestion();

            Console.WriteLine();
            Console.WriteLine("Press Enter when you are ready for the next question.");
            Console.ReadLine();
        }
    }
}