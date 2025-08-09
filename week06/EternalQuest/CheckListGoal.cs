namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        private int _targetCount, _currentCount, _bonusPoints;
        public int TargetCount => _targetCount;
        public int CurrentCount => _currentCount;
        public int BonusPoints => _bonusPoints;
        public ChecklistGoal(string title, int points, int targetCount, int bonusPoints) : base(title, points)
        {
            _targetCount = targetCount;
            _currentCount = 0;
            _bonusPoints = bonusPoints;
        }
        public override int RecordEvent()
        {
            if (IsComplete) return 0;
            _currentCount++;
            CurrentStreak++;
            int gained = Points;
            if (_currentCount >= _targetCount)
            {
                IsComplete = true;
                gained += _bonusPoints;
            }
            return gained;
        }
        public override string StatusString() => IsComplete ? $"[X] (Checklist {CurrentCount}/{TargetCount})" : $"[ ] (Checklist {CurrentCount}/{TargetCount})";
    }
}
