using System;

public class SimpleGoal: Goal{

    private bool _isComplete;

    public SimpleGoal(string name, string description, string points) : base(name, description, points){
        _isComplete = false;
    }

    public override void RecordEvent() {
        _isComplete = true;
    }
    public override bool IsComplete(){
        return _isComplete;
    }
    public override string GetStringRepresentation(){
        string completionStatus = _isComplete ? "Complete" : "Incomplete";
        // return $"[{(IsComplete() ? 'X' : ' ')}] {_shortName} , {_description} - {points} points";
        return $"{base.GetStringRepresentation()}, {_isComplete}";
    }
}