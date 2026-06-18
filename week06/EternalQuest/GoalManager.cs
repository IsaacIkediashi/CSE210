using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void SetScore(int score)
    {
        _score = score;
    }

    public int GetScore()
    {
        return _score;
    }

    public void AddScore(int points)
    {
        _score += points;
    }

    public List<Goal> GetGoals()
    {
        return _goals;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
}