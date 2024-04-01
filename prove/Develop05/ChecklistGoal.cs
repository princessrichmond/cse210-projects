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

    public override void RecordEvent(){
        _amountCompleted++;
        // if (_amountCompleted >= _target){
        //     _points += _bonus;
        // }
    }
    
    public override bool IsComplete(){
        return _amountCompleted >= _target;
    }
    public override string GetDetailsString(){
        // return $"{_shortName}: {_description} - {_points} points, Target: {_target}, {Completed}: {_amountCompleted}";
            return $"{base.GetDetailsString()} - Currently completed: {_amountCompleted} / {_target}";
    }
    public override string GetStringRepresentation(){
        // return $"ChecklistGoal{_shortName}, {_description}, {_points} points, Target: {_target}, Bonus: {_bonus}, Completed: {_amountCompleted}";
            return $"{base.GetStringRepresentation()}, {_amountCompleted}, {_target}, {_bonus}";
    }
}