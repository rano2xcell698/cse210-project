namespace EternalQuest
{
    public abstract class Goal
    {
        private string _title;
        private int _points;
        public string Title { get => _title; set => _title = value; }
        public int Points { get => _points; protected set => _points = value; }
        public bool IsComplete { get; protected set; }
        public int CurrentStreak { get; protected set; }

        protected Goal(string title, int points)
        {
            _title = title;
            _points = points;
            IsComplete = false;
            CurrentStreak = 0;
        }

        public abstract int RecordEvent();
        public virtual string StatusString() => IsComplete ? "[X]" : "[ ]";
    }
}