using System;


class GoalManager
{
    List<Goal> _goals = new List<Goal>();
    private int _score;
    private string _userName;

    public GoalManager()
    {
        _score = 0;
    }

    public GoalManager(string userName)
    {
        _userName = userName;
    }

    public void Start()
    {
        int choice = 1;

        while(choice >=0 || choice < 0)
        {
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit");
            Console.Write("Select a choice from the menu: ");

            string userInput = Console.ReadLine();
            choice = int.Parse(userInput);

            if (choice == 1)
            {
                CreateGoal();
            }
            else if (choice == 2)
            {
                ListGoalDetails();
            }
            else if (choice == 3)
            {
                SaveGoals();
            }
            else if (choice == 4)
            {
                LoadGoals();
            }
            else  if (choice == 5)
            {
                ListGoalNames();
                RecordEvent();
            }
            else if (choice == 6)
            {
                Console.WriteLine("Goodbye! Thank you for using the Goal Manager.");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                Console.WriteLine();
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"{_userName} you have {_score} points.\n");
    }

    public void ListGoalNames()
    {   
        int goalNumber = 1;
        Console.WriteLine();
        Console.WriteLine("The goals are:");

        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{goalNumber}. {goal.GetDetailsString().Split(' ')[1]}");
            goalNumber++;
        }

        Console.WriteLine();
    }

    public void ListGoalDetails()
    {
        int goalNumber = 1;
        Console.WriteLine();
        Console.WriteLine("The goals are:");

        foreach (Goal goal in _goals)
        {
            string list = $"{goalNumber}. {goal.GetDetailsString()}";

            if (goal.IsComplete())
            {
                list = list.Replace("[]","[X]");
            }

            Console.WriteLine(list);
            goalNumber++;
        }

        Console.WriteLine();
    }

    public void CreateGoal()
    {
        int choice = 1;
        while(choice >= 0 || choice < 0)
        {
            Console.WriteLine();
            Console.WriteLine("The types of Goal are:");
            Console.WriteLine("1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");

            string userInput = Console.ReadLine();
            choice = int.Parse(userInput);

            if(choice == 1)
            {
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();

                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                string points = Console.ReadLine();

                SimpleGoal goal = new SimpleGoal(name, description, points);
                _goals.Add(goal);

                Console.WriteLine();
                break;
            }
            else if(choice == 2)
            {
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();

                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                string points = Console.ReadLine();

                EternalGoal goal = new EternalGoal(name, description, points);
                _goals.Add(goal);

                Console.WriteLine();
                break;
            }
            else if (choice == 3)
            {
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();

                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                string points = Console.ReadLine();

                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                string input = Console.ReadLine();
                int target = int.Parse(input);

                Console.Write("What is the bonus for accomplishing it that many times? ");
                string input2 = Console.ReadLine();
                int bonus = int.Parse(input2);

                ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
                _goals.Add(goal);

                Console.WriteLine();
                break;
            }
        }
    }
    public void RecordEvent()
    {
        Console.Write("Which goal did you accomplish? ");
        int goalNumber = int.Parse(Console.ReadLine());

        if (goalNumber >= 1 && goalNumber <= _goals.Count)
        {
            Goal goal = _goals[goalNumber - 1];

            goal.RecordEvent();

            int points = goal.GetPoints();
            _score += points;


            Console.WriteLine($"You now have {_score} points.");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("Enter the filename: ");
        string filename = Console.ReadLine();

        string filePath = Path.Combine(Environment.CurrentDirectory, filename);

        using (StreamWriter file = new StreamWriter(filePath))
        {
            file.WriteLine(_score);

            foreach (Goal save in _goals)
            {
                file.WriteLine(save.GetStringRepresentation());
            }
        }
        Console.WriteLine("Saved successfully!");
        Console.WriteLine();
    }

    public void LoadGoals()
    {
        Console.Write("Enter the filename: ");
        string filename = Console.ReadLine();
        string filePath = Path.Combine(Environment.CurrentDirectory, filename);

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return;
        }

        using (StreamReader file = new StreamReader(filePath))
        {
            string lines = file.ReadLine();
            int scoreFromFile = int.Parse(lines);

            _score += scoreFromFile;

            string line;
            while ((line = file.ReadLine())!= null)
            {
                string[] parts = line.Split(',');
                string _shortName = parts[1];
                string _description = parts[2];
                string _points = parts[3];
                int _bonus = 0;
                int _target = 0;
                int _amountCompleted = 0;
                bool _isComplete = false;

                for (int i = 4; i < parts.Length; i++)
                {
                    if (int.TryParse(parts[i], out int value))
                    {
                        if (_bonus == 0)
                        {
                            _bonus = value;
                        }
                        else if (_target == 0)
                        {
                            _target = value;
                        }
                        else
                        {
                            _amountCompleted = value;
                        }
                    }
                    else if (bool.TryParse(parts[i], out bool boolValue))
                    {
                        _isComplete = boolValue;
                    }
                }

                Goal goal;
                if (_target > 0 && _bonus > 0)
                {
                    goal = new ChecklistGoal(_shortName, _description, _points, _target, _bonus);
                    ((ChecklistGoal)goal)._amountCompleted = _amountCompleted;
                }
                else if (_bonus > 0)
                {
                    goal = new EternalGoal(_shortName, _description, _points);
                }
                else
                {
                    goal = new SimpleGoal(_shortName, _description, _points);
                    if (_isComplete)
                    {
                        ((SimpleGoal)goal).SetComplete(true);
                    }
                }
                
                _goals.Add(goal);
            }
        }
        Console.WriteLine("Loaded successfully!");
        Console.WriteLine();
    }
}