namespace EternalQuest
{
    public class GoalManager
    {
        private List<Goal> _goals = new List<Goal>();
        public int Score { get; private set; }
        public IReadOnlyList<Goal> Goals => _goals.AsReadOnly();
        public void AddGoal(Goal g) => _goals.Add(g);
        public void ShowGoals()
        {
            if (!_goals.Any()) { Console.WriteLine("No goals yet."); return; }
            for (int i = 0; i < _goals.Count; i++)
                Console.WriteLine($"{i + 1}. { _goals[i].StatusString()} {_goals[i].Title} (Streak: {_goals[i].CurrentStreak})");
        }
        public void RecordEvent(int index)
        {
            if (index < 0 || index >= _goals.Count) return;
            int earned = _goals[index].RecordEvent();
            Score += earned;
            Console.WriteLine($"You earned {earned} points! Total: {Score}");
        }
    }
}