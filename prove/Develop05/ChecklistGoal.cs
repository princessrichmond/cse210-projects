using System;

public class ChecklistGoal: Goal{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus): base(name, description, points){
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public void RecordEvent(){
        _amountCompleted++;
        if (_amountCompleted >= _target){
            _points += _bonus;
        }
    }
    public bool IsComplete() => _amountCompleted >= _target;
    public string GetDeatailsString() => $"{_shortName}: {_description} - {_points} points, Target: {_target}, {Completed}: {_amountCompleted}";
    public string GetStringRepresentation() => $"{_shortName}. {_description}, {points},{ target}, {bonus} - Completed: {_amountCompleted} / {_target}";
}