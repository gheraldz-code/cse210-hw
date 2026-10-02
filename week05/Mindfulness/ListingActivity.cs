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
    public ListingActivity(string name, string description, int duration, int count) : base(name, description, duration)
    {
        _count = count;
    }

}