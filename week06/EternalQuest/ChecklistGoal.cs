class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    public ChecklistGoal(string name, string description, string points, int target, int bonus, int amountCompleted) : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (!isComplete())
        {
            _amountCompleted++;
        }
    }
    public override bool isComplete()
    {
        if(_amountCompleted == _target)
        {
            return true;
        }
        return false;
    }
    public override string GetDetailsString()
    {
        if(isComplete())
        {
            return $"[X] {_shortName} ({_description}) -- Currently completed: {_target}/{_target}";
        }
        return $"[ ] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return $"{isComplete()}~|~ChecklistGoal~|~{_shortName}~|~{_description}~|~{_points}~|~{_target}~|~{_bonus}~|~{_amountCompleted}";
    }
    public override int PointsEarned()
    {
        int pointsEarned = int.Parse(_points);
        if(isComplete())
        {
            pointsEarned += _bonus;
        }
        return pointsEarned;
    }
}