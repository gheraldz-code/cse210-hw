public class Job
{
    // The C# convention is to start member variables with an underscore _
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}"); //, for example: "Software Engineer (Microsoft) 2019-2022"
    }
}