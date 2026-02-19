abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _shortName;
    }

    public abstract void RecordEvent();
    public abstract bool isComplete();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();
    public abstract int PointsEarned();
}