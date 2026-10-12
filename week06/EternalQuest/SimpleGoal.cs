public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string shortName, string description, int points)
        : base(shortName, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public void SetComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }

    public override string GetDetailsString()
    {
        string check = IsComplete() ? "X" : " "; // ? : condition

        return $"[{check}] {GetGoalName()} ({GetPoints()} points)";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal,{GetGoalName()},{GetDescription()},{GetPoints()},{IsComplete()}";
    }
}