class Swimming : Activity
{
    private int _numberOfLaps;
    
    public Swimming(string date, double length, int numberOfLaps) : base(date, length)
    {
        _name = "Swimming";
        _numberOfLaps = numberOfLaps;
    }

    public override double CalculateDistance()
    {
        return _numberOfLaps * 50.0 / 1000.0;
    }
    public override double CalculateSpeed()
    {
        return CalculateDistance() / _length * 60;
    }
    public override double CalculatePace()
    {
        return _length / CalculateDistance();
    }
}