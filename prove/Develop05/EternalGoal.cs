using System;

public class EternalGoal: Goal{
    public EternalGoal(string name, string description, string points) : base(name, description, points){}
    public void RecordEvent(){}
    public bool IsComplete() => true;
    public string GetStringRepresentation(){
        return $"EternalGoal:{_shortName}, {_description} - {_points} points";
    }

}