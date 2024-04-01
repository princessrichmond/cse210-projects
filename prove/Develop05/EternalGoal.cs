using System;

public class EternalGoal: Goal{
    public EternalGoal(string name, string description, string points) : base(name, description, points){}
    public override void RecordEvent(){
        Console.WriteLine($"Recorded for goal: {_shortName}");
    }
    public override bool IsComplete(){
        return false;
        // _isComplete = true;
    }
    public override string GetStringRepresentation(){
        return $"EternalGoal:{_shortName}, {_description} - {_points} points";
    }

}