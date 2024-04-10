using System;

public class Running: Activity{
    protected double _distance;

    public Running(DateTime date, string activityType, int durationMinutes, double distance)
        :base(date, activityType, durationMinutes){
            _distance = distance;
        }
    public override double CalculateDistance(){
        return _distance;
    }
    public override double CalculateSpeed(){
        return (_distance / _durationMinutes) * 60;
    }
    public override string CalculatePace(){
        double pace = _durationMinutes / _distance / 60.0;
        TimeSpan paceTime = TimeSpan.FromMinutes(pace * 60);
        return $"{paceTime.Minutes} min per mile";
    }

    public override string GetSummary(){
        double speed = CalculateSpeed();
        return $"{_date:dd MMM yyyy} {_activityType} ({_durationMinutes} mins)- Distance {_distance:0.0} miles, Speed {CalculateSpeed():0.0} mph, Pace: {CalculatePace()}";
    }
}