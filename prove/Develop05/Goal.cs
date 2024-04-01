using System;

public class Goal{
    public string _shortName;
    public string _description;
    public string _points;

    public Goal(string name, string description, string points){ 
        _shortName = name;
        _description = description;
        _points = points;
    }
    public string ShortName {
        get { return _shortName; }
        set { _shortName = value; }
    }

    public string Description {
        get { return _description; }
        set { _description = value; }
    }

    public string Points {
        get { return _points; }
        set { _points = value; }
    }
    
    public virtual void RecordEvent(){
        Console.WriteLine($"Recorded for goal: {_shortName}");
    }
    public virtual bool IsComplete(){
        return false;
    }
    public virtual string GetDetailsString(){
        return $"{_shortName} ({_description})";
    }
    public virtual string GetStringRepresentation(){
        return $"{GetType().Name}: {_shortName}, {_description}, {_points}";
    }
}