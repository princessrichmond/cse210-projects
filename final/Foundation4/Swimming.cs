using System;

public class Swimming: Activity{
    protected int _laps;

    public Swimming(DateTime date, string activityType, int durationMinutes, int laps)
        : base(date, activityType, durationMinutes)
    {
        _laps = laps;
    }

    public override double CalculateDistance()
    {
        return _laps * 50 / 1000;
    }

    public override double CalculateSpeed()
    {
        double distanceKm = CalculateDistance();
        double distanceMi = distanceKm * 0.62;
        return distanceMi / _durationMinutes * 60;
        
    }

    public override string CalculatePace()
    {
        double pace = _durationMinutes / CalculateDistance();
        TimeSpan paceTime = TimeSpan.FromMinutes(pace * 60);
        return $"{paceTime.Minutes:0} min {paceTime.Seconds:0} sec per mile";
    }

    public override string GetSummary()
    {
         return $"{_date:dd MMM yyyy} {_activityType} ({_durationMinutes:0.0} mins): Distance {CalculateDistance():0.0} miles, Speed {CalculateSpeed():0.0} mph, Pace: {CalculatePace()}";
    }
}