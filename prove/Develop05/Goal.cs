using System;

public class Goal{
    protected string _shortName;
    protected string _description;
    protected string _points;

    protected Goal (string name, string description, string points){ 
        _shortName = name;
        _description = description;
        _points = points;
    }
    public string ShortName{
        get { 
            return _shortName;
        }
        set{
            _shortName = value;
        }
    }
    public string Description{
        get {
            return _description;
        }
        set {
            _description = value;
        }
    }
    public string Points{
        get {
            return _points;
        }
        set{
            _points = value;
        }
    }
    public void RecordEvent(){
        Console.WriteLine($"Recorded for goal: {_shortName}");
    }
    public bool IsComplete(){
        return false;
    }
    public string GetDeatailsString(){
        return $"{_shortName}: {_description} - {_points} points";
    }
    public string GetStringRepresentation(){
        return $"Goal: {_shortName}, {_description}, {_points}";
    }

}