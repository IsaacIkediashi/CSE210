public class Checklist : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;

    public int GetBonus()
    {
        return _bonus;
    }

    public override void GoalQuery()
    {
        SetGoalType("ChecklistGoal");
        GoalQuestion();

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _target = int.Parse(Console.ReadLine());

        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonus = int.Parse(Console.ReadLine());
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString(string text)
    {
        string checkBox = IsComplete() ? "[X]" : "[ ]";

        return $"{checkBox} {GetShortName()} ({GetDescription()}) -- Completed {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation(int index)
    {
        return $"{GetGoalType()}|{GetShortName()}|{GetDescription()}|{GetPoints()}|{_amountCompleted}|{_target}|{_bonus}";
    }
}