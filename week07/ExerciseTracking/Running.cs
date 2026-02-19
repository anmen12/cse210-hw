class Running : Activity
{
    private double _distance;

    public Running(string date, double length, double distance) : base(date, length)
    {
        _name = "Running";
        _distance = distance;
    }

    public override double CalculateDistance()
    {
        return _distance;
    }
    public override double CalculateSpeed()
    {
        return _distance / _length * 60;
    }
    public override double CalculatePace()
    {
        return _length / _distance;
    }
}