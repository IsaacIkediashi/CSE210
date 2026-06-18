public class EternalGoal : Goal
{
    public override void GoalQuery()
    {
        SetGoalType("EternalGoal");
        GoalQuestion();
    }

    public override void RecordEvent()
    {
        // Eternal goals never finish
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation(int index)
    {
        return $"{GetGoalType()}|{GetShortName()}|{GetDescription()}|{GetPoints()}";
    }
}