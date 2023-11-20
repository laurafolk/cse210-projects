// class User
// {
//     private List<Activity> goals;

//     public User()
//     {
//         goals = new List<Activity>();
//     }

//     public void CreateNewGoal()
//     {
//         Console.Write("Enter goal name: ");
//         string name = Console.ReadLine();
//         Console.Write("Enter goal type (1. Simple, 2. Eternal, 3. Checklist): ");
//         int type = int.Parse(Console.ReadLine());
//         Console.Write("Enter goal value: ");
//         int value = int.Parse(Console.ReadLine());

//         Activity goal;

//         switch (type)
//         {
//             case 1:
//                 goal = new SimpleGoal(name, value);
//                 break;
//             case 2:
//                 goal = new EternalGoal(name, value);
//                 break;
//             case 3:
//                 Console.Write("Enter target count for checklist goal: ");
//                 int targetCount = int.Parse(Console.ReadLine());
//                 goal = new ChecklistGoal(name, value, targetCount);
//                 break;
//             default:
//                 Console.WriteLine("Invalid goal type");
//                 return;
//         }

//         goals.Add(goal);
//         Console.WriteLine("Goal created successfully!");
//     }

//     public void ListGoals()
//     {
//         foreach (var goal in goals)
//         {
//             goal.DisplayStatus();
//         }
//     }

//     public void SaveGoals()
//     {
//         using (StreamWriter writer = new StreamWriter("goals.txt"))
//         {
//             foreach (var goal in goals)
//             {
//                 writer.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.Value}");
//             }
//         }

//         Console.WriteLine("Goals saved successfully!");
//     }

//     public void LoadGoals()
//     {
//         goals.Clear();

//         try
//         {
//             using (StreamReader reader = new StreamReader("goals.txt"))
//             {
//                 string line;
//                 while ((line = reader.ReadLine()) != null)
//                 {
//                     string[] parts = line.Split(',');
//                     if (parts.Length == 3)
//                     {
//                         string goalType = parts[0];
//                         string name = parts[1];
//                         int value = int.Parse(parts[2]);

//                         Activity goal;

//                         switch (goalType)
//                         {
//                             case "SimpleGoal":
//                                 goal = new SimpleGoal(name, value);
//                                 break;
//                             case "EternalGoal":
//                                 goal = new EternalGoal(name, value);
//                                 break;
//                             case "ChecklistGoal":
//                                 Console.Write("Enter target count for checklist goal: ");
//                                 int targetCount = int.Parse(Console.ReadLine());
//                                 goal = new ChecklistGoal(name, value, targetCount);
//                                 break;
//                             default:
//                                 Console.WriteLine($"Invalid goal type: {goalType}");
//                                 continue;
//                         }

//                         goals.Add(goal);
//                     }
//                 }
//             }

//             Console.WriteLine("Goals loaded successfully!");
//         }
//         catch (FileNotFoundException)
//         {
//             Console.WriteLine("No saved goals found.");
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine($"Error loading goals: {ex.Message}");
//         }
//     }

//     public void RecordEvent()
//     {
//         Console.Write("Enter the name of the goal you accomplished: ");
//         string goalName = Console.ReadLine();

//         Activity goal = goals.Find(g => g.Name.Equals(goalName, StringComparison.OrdinalIgnoreCase));

//         if (goal != null)
//         {
//             if (goal is SimpleGoal)
//             {
//                 ((SimpleGoal)goal).IsComplete = true;
//             }
//             else if (goal is ChecklistGoal)
//             {
//                 ((ChecklistGoal)goal).CompletedCount++;
//             }

//             Console.WriteLine($"Event recorded for {goalName}!");
//         }
//         else
//         {
//             Console.WriteLine("Goal not found. Please check your goal name.");
//         }
//     }

//     public int GetTotalScore()
//     {
//         return goals.Sum(goal => goal.Value);
//     }
// }