public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(
        string shortName,
        string description,
        int points,
        int target,
        int bonus)
        : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted += 1;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target; // condition
    }

    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }

    public override string GetDetailsString()
    {
        string check = IsComplete() ? "X" : " ";

        return $"[{check}] {GetGoalName()} ({_amountCompleted}/{_target} — {GetPoints()} puntos)";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal,{GetGoalName()},{GetDescription()},{GetPoints()},{_amountCompleted},{_target},{_bonus}";
    }
}