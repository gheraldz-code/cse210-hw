public class Resume
{
    // The C# convention is to start member variables with an underscore _
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"{_name}");
        Console.WriteLine("Jobs:");
        // Notice the use of the custom data type "Job" in this loop
        foreach (Job job in _jobs)
        {
            // This calls the Display method on each job
            job.Display();
        }
    }
}