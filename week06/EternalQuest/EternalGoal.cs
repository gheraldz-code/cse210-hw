public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points)
        : base(shortName, description, points)
    {
    }

    public override void RecordEvent()
    {
        // at the moment, it is not necessary
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"{GetGoalName()} ({GetPoints()} points)";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal,{GetGoalName()},{GetDescription()},{GetPoints()}";
    }
}