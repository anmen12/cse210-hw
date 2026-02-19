class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        ;
    }
    public SimpleGoal(string name, string description, string points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }
    public override bool isComplete()
    {
        return _isComplete;
    }
    public override string GetDetailsString()
    {
        if(_isComplete)
        {
            return $"[X] {_shortName} ({_description})";
        }
        return $"[ ] {_shortName} ({_description})";
    }
    public override string GetStringRepresentation()
    {
        return $"{_isComplete}~|~SimpleGoal~|~{_shortName}~|~{_description}~|~{_points}";
    }
    public override int PointsEarned()
    {
        return int.Parse(_points);
    }
}