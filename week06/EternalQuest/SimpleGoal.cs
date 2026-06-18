public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public override void GoalQuery()
    {
        SetGoalType("SimpleGoal");
        GoalQuestion();
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        SetGoalStatus(true);
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation(int index)
    {
        return $"{GetGoalType()}|{GetShortName()}|{GetDescription()}|{GetPoints()}|{_isComplete}";
    }
}