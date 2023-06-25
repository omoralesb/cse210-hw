public class ChecklistGoal : Goal
{
    public int _timesCompleted { get; set; }
    public int _requiredCompletions { get; set; }
    public int _bonusPoints { get; set; }

    public override int GetPoints()
    {
        if (_timesCompleted >= _requiredCompletions)
        {
            
            return _bonusPoints;
        }
        else
        {
            
            return _pointValue;
        }
    }
}