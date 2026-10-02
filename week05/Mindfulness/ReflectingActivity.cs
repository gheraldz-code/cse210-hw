public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description) : base(name, description)
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
    }

    public void Run(){

    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
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

    public void Start()
    {
        Console.WriteLine("Welcome to the Reflecting Activity!");
        Console.WriteLine("Take a moment to relax and focus on your breathing.");
        Console.WriteLine("When you're ready, press Enter to continue...");
        Console.ReadLine();

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine($"\nPrompt: {prompt}");
        Console.WriteLine("Take a few moments to reflect on this prompt. Press Enter when you're ready for questions...");
        Console.ReadLine();

        foreach (string question in _questions)
        {
            Console.WriteLine($"\nQuestion: {question}");
            Console.WriteLine("Take your time to think about your answer. Press Enter when you're ready for the next question...");
            Console.ReadLine();
        }

        Console.WriteLine("\nThank you for participating in the Reflecting Activity!");
    }
}