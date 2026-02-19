abstract class Activity
{
    private string _date;
    protected string _name;
    protected double _length;

    public Activity(string date, double length)
    {
        _date = date;
        _length = length;
    }

    abstract public double CalculateDistance();
    abstract public double CalculateSpeed();
    abstract public double CalculatePace();
    virtual public string GetSummary()
    {
        return $"{_date} {_name} ({_length} min): Distance {CalculateDistance()} km, Speed {CalculateSpeed()} kph, Pace: {CalculatePace()} min per km";
    }
}