public class Cycling : Activity
{
    private double _speed; // in kilometers per hour

    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        // distance = speed * (minutes / 60)
        return _speed * (Minutes / 60.0);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        // pace = minutes per kilometer
        double distance = GetDistance();
        return Minutes / distance;
    }
}
