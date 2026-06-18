using System;
using System.Collections.Generic;

public abstract class Goal
{
    private bool _complete = false;
    private string _goalType;
    private int _gamePoints = 0;

    private string _shortName;
    private string _description;

    protected List<string> _goalsSet = new List<string>();

    public virtual void GoalQuery()
    {
        GoalQuestion();
    }

    public void GoalQuestion()
    {
        Console.Write("What is the name of your goal? ");
        _shortName = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        _gamePoints = int.Parse(Console.ReadLine());

        _goalsSet.Add($"{_shortName}, {_description}");
    }

    public string GetShortName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _gamePoints;
    }

    public bool GetGoalStatus()
    {
        return _complete;
    }

    public void SetGoalStatus(bool input)
    {
        _complete = input;
    }

    public virtual string GetDetailsString(string text)
    {
        string checkBox = IsComplete() ? "[X]" : "[ ]";

        return $"{checkBox} {GetShortName()} ({GetDescription()})";
    }

    public abstract string GetStringRepresentation(int index);

    public string GetStrings(int i)
    {
        return _goalsSet[i];
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public string GetGoalType()
    {
        return _goalType;
    }

    public void SetGoalType(string type)
    {
        _goalType = type;
    }

    public List<string> GetList()
    {
        return _goalsSet;
    }
}