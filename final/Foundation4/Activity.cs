using System;

public class Activity{
    protected DateTime _date;
    protected string _activityType;
    protected int _durationMinutes;

    public Activity(DateTime date, string ActivityType, int durationMinutes){
        _date = date;
        _activityType = ActivityType;
        _durationMinutes = durationMinutes;
    }

    public virtual double CalculateDistance(){
        return 0.0;
    }
    public virtual double CalculateSpeed(){
        return 0.0;
    }
    public virtual string CalculatePace(){
        return "";
    }
    public virtual string GetSummary(){
        return "";
    }
}