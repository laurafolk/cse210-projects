using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    private List<Activity> goals;

    public Program()
    {
        goals = new List<Activity>();
    }

    public void Run()
    {
        int choice;

        do
        {
            Console.Clear();
            Console.WriteLine($"Your current score: {GetTotalScore()} points");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create new simple goal");
            Console.WriteLine("2. Create new checklist goal");
            Console.WriteLine("3. Create new eternal goal");
            Console.WriteLine("4. List goals");
            Console.WriteLine("5. Save goals");
            Console.WriteLine("6. Load goals");
            Console.WriteLine("7. Record event");
            Console.WriteLine("8. Quit");

            Console.Write("Enter your choice: ");
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 8)
            {
                Console.Write("Invalid input. Enter a number between 1 and 8: ");
            }

            switch (choice)
            {
                case 1:
                    CreateNewSimpleGoal();
                    break;
                case 2:
                    CreateNewChecklistGoal();
                    break;
                case 3:
                    CreateNewEternalGoal();
                    break;
                case 4:
                    ListGoals();
                    break;
                case 5:
                    SaveGoals();
                    break;
                case 6:
                    LoadGoals();
                    break;
                case 7:
                    RecordEvent();
                    break;
                case 8:
                    Console.WriteLine("Goodbye!");
                    break;
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        } while (choice != 8);
    }

    private void CreateNewSimpleGoal()
    {
        Console.Write("Enter simple goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter simple goal value: ");
        int value = int.Parse(Console.ReadLine());

        goals.Add(new SimpleGoal(name, value));
        Console.WriteLine("Simple goal created successfully!");
    }

    private void CreateNewChecklistGoal()
    {
        Console.Write("Enter checklist goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter checklist goal value: ");
        int value = int.Parse(Console.ReadLine());
        Console.Write("Enter target count for checklist goal: ");
        int targetCount = int.Parse(Console.ReadLine());

        goals.Add(new ChecklistGoal(name, value, targetCount));
        Console.WriteLine("Checklist goal created successfully!");
    }

    private void CreateNewEternalGoal()
    {
        Console.Write("Enter eternal goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter eternal goal value: ");
        int value = int.Parse(Console.ReadLine());

        goals.Add(new EternalGoal(name, value));
        Console.WriteLine("Eternal goal created successfully!");
    }

    private void ListGoals()
    {
        foreach (var goal in goals)
        {
            goal.DisplayStatus();
        }
    }

    private void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (var goal in goals)
            {
                writer.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.Value}");
            }
        }

        Console.WriteLine("Goals saved successfully!");
    }

    private void LoadGoals()
    {
        goals.Clear();

        try
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        string goalType = parts[0];
                        string name = parts[1];
                        int value = int.Parse(parts[2]);

                        Activity goal;

                        switch (goalType)
                        {
                            case "SimpleGoal":
                                goal = new SimpleGoal(name, value);
                                break;
                            case "EternalGoal":
                                goal = new EternalGoal(name, value);
                                break;
                            case "ChecklistGoal":
                                Console.Write("Enter target count for checklist goal: ");
                                int targetCount = int.Parse(Console.ReadLine());
                                goal = new ChecklistGoal(name, value, targetCount);
                                break;
                            default:
                                Console.WriteLine($"Invalid goal type: {goalType}");
                                continue;
                        }

                        goals.Add(goal);
                    }
                }
            }

            Console.WriteLine("Goals loaded successfully!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("No saved goals found.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }
    }

    private void RecordEvent()
    {
        Console.Write("Enter the name of the goal you accomplished: ");
        string goalName = Console.ReadLine();

        Activity goal = goals.Find(g => g.Name.Equals(goalName, StringComparison.OrdinalIgnoreCase));

        if (goal != null && goal is ChecklistGoal)
        {
            ((ChecklistGoal)goal).CompletedCount++;
            Console.WriteLine($"Event recorded for {goalName}!");
        }
        else if (goal != null)
        {
            Console.WriteLine($"Cannot record events for {goalName}. Only Checklist goals are supported.");
        }
        else
        {
            Console.WriteLine("Goal not found. Please check your goal name.");
        }
    }

    private int GetTotalScore()
    {
        return goals.Sum(goal => goal.Value);
    }

    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }
}
// class Program
// {
//     static void Main(string[] args)
//     {
//         User user = new User();
//         int choice;

//         do
//         {
//             Console.Clear();
//             Console.WriteLine($"Your current score: {user.GetTotalScore()} points");
//             Console.WriteLine("Menu:");
//             Console.WriteLine("1. Create new goal");
//             Console.WriteLine("2. List goals");
//             Console.WriteLine("3. Save goals");
//             Console.WriteLine("4. Load goals");
//             Console.WriteLine("5. Record event");
//             Console.WriteLine("6. Quit");

//             Console.Write("Enter your choice: ");
//             while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 6)
//             {
//                 Console.Write("Invalid input. Enter a number between 1 and 6: ");
//             }

//             switch (choice)
//             {
//                 case 1:
//                     user.CreateNewGoal();
//                     break;
//                 case 2:
//                     user.ListGoals();
//                     break;
//                 case 3:
//                     user.SaveGoals();
//                     break;
//                 case 4:
//                     user.LoadGoals();
//                     break;
//                 case 5:
//                     user.RecordEvent();
//                     break;
//                 case 6:
//                     Console.WriteLine("Goodbye!");
//                     break;
//             }

//             Console.WriteLine("Press any key to continue...");
//             Console.ReadKey();

//         } while (choice != 6);
//     }
// }