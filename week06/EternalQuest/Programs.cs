namespace EternalQuest
{
    class Program
    {
        static void Main()
        {
            var manager = new GoalManager();
            manager.AddGoal(new SimpleGoal("Run a marathon", 1000));
            manager.AddGoal(new EternalGoal("Read scriptures", 100));
            manager.AddGoal(new ChecklistGoal("Attend temple", 50, 10, 500));
            manager.AddGoal(new ProgressGoal("Train for triathlon", 2000));

            while (true)
            {
                Console.WriteLine("1) Show goals\n2) Record goal\n3) Exit");
                var input = Console.ReadLine();
                if (input == "1") manager.ShowGoals();
                else if (input == "2")
                {
                    manager.ShowGoals();
                    Console.Write("Choose goal: ");
                    if (int.TryParse(Console.ReadLine(), out int idx)) manager.RecordEvent(idx - 1);
                }
                else if (input == "3") break;
            }
        }
    }
}
