public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _targetCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _timesCompleted = 0;
    }

    public override int RecordEvent()
    {
        _timesCompleted++;
        if (_timesCompleted >= _targetCount)
        {
            _isComplete = true;
            return _points + _bonusPoints;
        }
        return _points;
    }

    public override string GetDetailsString()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        return $"{status} {_name} ({_description}) -- Completed {_timesCompleted}/{_targetCount}";
    }

    public override string GetSaveString()
    {
        return $"{GetType().Name}:{_name}|{_description}|{_points}|{_isComplete}|{_timesCompleted}|{_targetCount}|{_bonusPoints}";
    }
}
