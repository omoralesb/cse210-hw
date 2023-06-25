public class Goal
{
    public string _name { get; set; }
    public int _pointValue { get; set; }
    public string _description { get; set; }
    public bool _isComplete { get; set; }

    public virtual int GetPoints()
    {
        return _isComplete ? _pointValue : 0;
    }
}