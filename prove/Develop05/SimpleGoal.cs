using System;

public class SimpleGoal: Goal{

    private bool _isComplete =  false;
    public SimpleGoal(string name, string description, string points) : base(name, description, points){}

    public void RecordEvent() => _isComplete = true;
    public bool IsComplete() => _isComplete;
    public string GetStringRepresentation(){
        return $"[{(IsComplete() ? 'X' : ' ')}] {_shortName} - {_description}";
    }

}