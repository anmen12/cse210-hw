class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private List<Goal> _completedGoals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        ;
    }

    public void Start()
    {
        string answer = "";
        while(answer != "6")
        {
            DisplayPlayerInfo();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Quit");
            Console.Write("Select a choice from the menu: ");
            answer = Console.ReadLine();

            switch(answer)
            {
                case "1":
                    //Create Goal
                    CreateGoal();
                    break;
                case "2":
                    //List Goals
                    ListGoalDetials();
                    break;
                case "3":
                    //Save Goals
                    SaveGoals();
                    break;
                case "4":
                    //Load Goals
                    LoadGoals();
                    break;
                case "5":
                    //Record Event
                    RecordEvent();
                    break;
                default:
                    break;
            }
        }
    }
    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.\n");
    }
    private void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        int i = 1;
        foreach(Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetName()}");
            i++;
        }
    }
    private void ListGoalDetials()
    {
        Console.WriteLine("The goals are:");
        int i = 1;
        foreach(Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
            i++;
        }

        Console.WriteLine("The completed goals are:");
        i = 1;
        foreach(Goal goal in _completedGoals)
        {
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
            i++;
        }
    }
    private void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("   1. Simple Goal");
        Console.WriteLine("   2. Eternal Goal");
        Console.WriteLine("   3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string answer = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();

        switch(answer)
        {
            case "1":
                //Simple Goal
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                //Eternal Goal
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                //Checklist Goal
                Console.Write("How many times does this goal need to be accomplished for a bonus?  ");
                string bonus = Console.ReadLine();
                Console.Write("What is the bonus for accomplishing it that many times? ");
                string target = Console.ReadLine();
                _goals.Add(new ChecklistGoal(name, description, points, int.Parse(bonus), int.Parse(target)));
                break;
            default:
                break;
        }
    }
    private void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        string answer = Console.ReadLine();

        Goal goal = _goals[int.Parse(answer) - 1];
        goal.RecordEvent();
        _score += goal.PointsEarned();

        Console.WriteLine($"Congratulations! You have earned {goal.PointsEarned()} points!");
        Console.WriteLine($"You now have {_score} points.");

        if(goal.isComplete())
        {
            _completedGoals.Add(goal);
            _goals.Remove(goal);
        }
    }
    private void SaveGoals()
    {
        Console.WriteLine("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using(StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);

            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
            foreach(Goal goal in _completedGoals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    private void LoadGoals()
    {
        Console.WriteLine("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        _goals.Clear();
        _completedGoals.Clear();

        string[] lines = System.IO.File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);

        for(int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("~|~");

            bool isComplete = bool.Parse(parts[0]);
            string goalType = parts[1];
            switch(goalType)
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(parts[2], parts[3], parts[4], bool.Parse(parts[0])));
                    break;
                case "EternalGoal":
                    _goals.Add(new EternalGoal(parts[2], parts[3], parts[4]));
                    break;
                case "ChecklistGoal":
                    _goals.Add(new ChecklistGoal(parts[2], parts[3], parts[4], int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7])));
                    break;
            }

            if(isComplete)
            {
                _completedGoals.Add(_goals[_goals.Count() - 1]);
                _goals.Remove(_goals[_goals.Count() - 1]);
            }
        }
    }
}