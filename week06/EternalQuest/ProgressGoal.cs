namespace EternalQuest
{
    public class ProgressGoal : Goal
    {
        private double _progress;
        public ProgressGoal(string title, int totalPoints) : base(title, totalPoints) { _progress = 0.0; }
        public int RecordProgress(double fraction)
        {
            if (fraction <= 0) return 0;
            double previous = _progress;
            _progress = Math.Min(1.0, _progress + fraction);
            int gained = (int)((_progress - previous) * Points);
            if (_progress >= 1.0) IsComplete = true;
            CurrentStreak++;
            return gained;
        }
        public override int RecordEvent() => RecordProgress(0.1);
        public override string StatusString() => IsComplete ? $"[X] (Progress {Math.Round(_progress * 100)}%)" : $"[ ] (Progress {Math.Round(_progress * 100)}%)";
    }
}
