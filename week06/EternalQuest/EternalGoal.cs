namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string title, int points) : base(title, points) { }
        public override int RecordEvent()
        {
            CurrentStreak++;
            int bonus = (CurrentStreak % 7 == 0) ? Points / 2 : 0;
            return Points + bonus;
        }
        public override string StatusString() => "[ ] (Eternal)";
    }
}