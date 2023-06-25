// SimpleGoal.cs
public class SimpleGoal : Goal
{
    public override int GetPoints()
    {
        return _isComplete ? _pointValue : 0;
    }
}