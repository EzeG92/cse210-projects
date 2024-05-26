using System;

class ChecklistGoal : Goal
{
    public int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }
    
    public override int GetPoints()
    {
        return int.Parse(_points);
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;

            if (_amountCompleted < _target)
            {
                Console.WriteLine($"Congratulations! You have earned {_points} points!");
            }
            else if (_amountCompleted >= _target)
            {
                int totalWithBonus = int.Parse(_points) + _bonus;
                Console.WriteLine($"Congratulations! You have earned {totalWithBonus} points!");
                Console.WriteLine("The goal has already been completed in its entirety.");
                base.AddPoints(_bonus);
            }
        }
        else
        {
            Console.WriteLine();
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted == _target;
    }

    public override string GetDetailsString()
    {
        return base.GetDetailsString() +" - Currently completed: "+ _amountCompleted+"/"+_target;
    }

    public override string GetStringRepresentation() //details to save to a file
    {
        return $"ChecklistGoal,{base.GetStringRepresentation()},{_bonus},{_target},{_amountCompleted}";
    }
}