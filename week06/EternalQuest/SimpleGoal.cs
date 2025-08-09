namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        private bool _awarded;
        public SimpleGoal(string title, int points) : base(title, points) { _awarded = false; }
        public override int RecordEvent()
        {
            if (_awarded) return 0;
            _awarded = true;
            IsComplete = true;
            CurrentStreak = 1;
            return Points;
        }
        public override string StatusString() => IsComplete ? "[X] (Simple)" : "[ ] (Simple)";
    }
}