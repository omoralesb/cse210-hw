using System;

class Program
{
    private List<Goal> _goals = new List<Goal>();
    private int _points = 0;
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }
    public void Run()
    {
        Menu menu = new Menu(); 
        bool running = true;
        bool createRunning = true;
        Console.Clear();

        while (running == true)
        {
            int menuChoice = menu.DisplayMenu(_points);
            switch(menuChoice)
            {
                case 1:
                    //Show 'create goal' menu
                    createRunning = true;
                    while (createRunning == true)
                    {
                        int createMenuChoice = menu.CreateMenu();
                        switch(createMenuChoice)
                        {
                            case 1:
                            // Add Simple Goal
                            SimpleGoal simpleGoal = new SimpleGoal();
                            Console.WriteLine("Enter name:");
                            simpleGoal._name = Console.ReadLine();
                            Console.WriteLine("Enter point value:");
                            simpleGoal._pointValue = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter description:");
                            simpleGoal._description = Console.ReadLine();
                            _goals.Add(simpleGoal);
                            Console.WriteLine("Goal created.");
                            createRunning = false;
                            
                                break;
                            case 2:
                            // Add Eternal Goal
                                EternalGoal eternalGoal = new EternalGoal();
                                Console.WriteLine("Enter name:");
                                eternalGoal._name = Console.ReadLine();
                                Console.WriteLine("Enter point value:");
                                eternalGoal._pointValue = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter description:");
                                eternalGoal._description = Console.ReadLine();
                                _goals.Add(eternalGoal);
                                Console.WriteLine("Goal created.");
                                createRunning = false;
                                
                                break;
                            case 3:
                            // Add Checklist Goal
                                ChecklistGoal checklistGoal = new ChecklistGoal();
                                Console.WriteLine("Enter name:");
                                checklistGoal._name = Console.ReadLine();
                                Console.WriteLine("Enter point value per completion:");
                                checklistGoal._pointValue = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter description:");
                                checklistGoal._description = Console.ReadLine();
                                Console.WriteLine("Enter number of required completions:");
                                checklistGoal._requiredCompletions = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter bonus point value:");
                                checklistGoal._bonusPoints = int.Parse(Console.ReadLine());
                                _goals.Add(checklistGoal);
                                Console.WriteLine("Goal created.");
                                createRunning = false;
                                
                                break;
                            case 4:
                            //Back to menu
                                createRunning = false;
                                break;
                            default:
                                Console.Clear();
                                continue;
                        }
                    }
                    break;
                case 2:
                //Console.Clear();
                    Console.Clear();
                    ShowGoals();
                    break;
                case 3:
                    //Save Goals
                    Console.Clear();
                    SaveGoals();
                    
                    break;
                case 4:
                    //Load Goals
                    Console.Clear();
                    LoadGoals();
                    break;
                case 5:
                    //Record Completed
                    Console.Clear();
                    RecordEvent();
                    break;
                case 6:
                    running = false;
                    Console.Clear();
                    Console.WriteLine("QUITTING");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid Input. Please try again.");
                    continue;
            }
        }
    }

    public void ShowGoals()
    {
        string goalCompletion;
        int numOfGoals = 0;
        foreach (Goal goal in _goals)
        {
            if (goal is not EternalGoal eternalGoal)
            {
                numOfGoals += 1;
                goalCompletion = $"{numOfGoals}. [{(goal._isComplete ? "√" : " ")}]";
                
            }
            else 
            {
                numOfGoals += 1;
                goalCompletion = $"{numOfGoals}. [∞]";  
            }
            Console.Write($"{goalCompletion} {goal._name}: {goal._description}");

            if (goal is ChecklistGoal checklistGoal)
            {
                Console.Write($" (Completed {checklistGoal._timesCompleted}/{checklistGoal._requiredCompletions} times)");
            }

            Console.WriteLine();
        }
    }

    private void RecordEvent()
    {
        ShowGoals();
        Console.WriteLine("Enter the number of the goal you completed:");
        int goalNum = Convert.ToInt32(Console.ReadLine()) - 1;

        Goal goal = _goals[goalNum];//.Find(g => g.Name == goalName);

        if (goal == null)
        {
            Console.WriteLine("Goal not found. Please try again.");
            return;
        }
        if (goal is ChecklistGoal checklistGoal)
        {
            checklistGoal._timesCompleted += 1;
            if (checklistGoal._timesCompleted >= checklistGoal._requiredCompletions)
            {
                goal._isComplete = true;
            }
        }
        else if (goal is SimpleGoal simpleGoal)
        {
            goal._isComplete = true;
        }

        
        _points += goal.GetPoints();

        Console.WriteLine("Event recorded.");
    }

    private void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_points);
            foreach (Goal goal in _goals)
            {
                string type = goal.GetType().Name;
                string name = goal._name;
                int pointValue = goal._pointValue;
                string description = goal._description;
                bool isComplete = goal._isComplete;

                switch (type)
                {
                    case "SimpleGoal":
                        writer.WriteLine($"SimpleGoal,{name},{pointValue},{description},{isComplete}");
                        break;
                    case "EternalGoal":
                        writer.WriteLine($"EternalGoal,{name},{pointValue},{description},{isComplete}");
                        break;
                    case "ChecklistGoal":
                        ChecklistGoal checklistGoal = (ChecklistGoal)goal;
                        int timesCompleted = checklistGoal._timesCompleted;
                        int requiredCompletions = checklistGoal._requiredCompletions;
                        int bonusPoints = checklistGoal._bonusPoints;
                        writer.WriteLine($"ChecklistGoal,{name},{pointValue},{description},{isComplete},{timesCompleted},{requiredCompletions},{bonusPoints}");
                        break;
                }
            }
        }

        Console.WriteLine("Goals saved.");
    }
    
    private void LoadGoals()
{
    Console.WriteLine("Loading goals...");

    try
    {
        using (StreamReader sr = new StreamReader("goals.txt"))
        {
            string line;
            _points = Convert.ToInt32(sr.ReadLine());
            while ((line = sr.ReadLine()) != null)
            {
                       
                string[] parts = line.Split(',');

                switch (parts[0])
                {
                    case "SimpleGoal":
                        SimpleGoal simpleGoal = new SimpleGoal();
                        simpleGoal._name = parts[1];
                        simpleGoal._pointValue = int.Parse(parts[2]);
                        simpleGoal._description = parts[3];
                        simpleGoal._isComplete = bool.Parse(parts[4]);
                        _goals.Add(simpleGoal);
                        break;
                    case "EternalGoal":
                        EternalGoal eternalGoal = new EternalGoal();
                        eternalGoal._name = parts[1];
                        eternalGoal._pointValue = int.Parse(parts[2]);
                        eternalGoal._description = parts[3];
                        eternalGoal._isComplete = bool.Parse(parts[4]);
                        _goals.Add(eternalGoal);
                        break;
                    case "ChecklistGoal":
                        ChecklistGoal checklistGoal = new ChecklistGoal();
                        checklistGoal._name = parts[1];
                        checklistGoal._pointValue = int.Parse(parts[2]);
                        checklistGoal._description = parts[3];
                        checklistGoal._isComplete = bool.Parse(parts[4]);
                        checklistGoal._timesCompleted = int.Parse(parts[5]);
                        checklistGoal._requiredCompletions = int.Parse(parts[6]);
                        checklistGoal._bonusPoints = int.Parse(parts[7]);
                        _goals.Add(checklistGoal);
                        break;
                }
            }

            Console.WriteLine("Goals loaded successfully.");
        }
    }
    catch (FileNotFoundException)
    {
        Console.WriteLine("Goals file not found.");
    }
    catch (Exception ex)
    {
        Console.WriteLine("An error occurred while loading goals: " + ex.Message);
    }
}
    
}