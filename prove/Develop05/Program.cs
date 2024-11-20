// I used the following websites for help: 
// https://stackoverflow.com/questions/11982164/inline-if-statement-in-c-sharp
// https://stackoverflow.com/questions/9126580/can-abstract-classes-have-implementation-in-c
// https://stackoverflow.com/questions/3427602/c-sharp-modulus-operator

// For my stretch challenge, I added a level system, which increases the user's level for every 100 points they earn.

using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Eternal Quest program! ");
        Console.WriteLine("Every 100 points you earn, you will gain another level. Try to reach as many levels as you can! ");
        User user = new User();
        int userMenuSelection = 0;

        while (userMenuSelection != 6)
        {
            user.DisplayStatus();
            Console.WriteLine("Menu Options\n 1. Create New Goal\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record Event\n 6. Quit");
            Console.Write("Select a choice from the menu: ");
            string menuInput = Console.ReadLine();

            if (int.TryParse(menuInput, out userMenuSelection))
            {
                // Switch case for menu selection
                switch (userMenuSelection)
                {
                    // Create New Goal
                    case 1:
                        Console.Clear();
                        Console.WriteLine("The types of Goals are:\n 1. Simple Goal\n 2. Eternal Goal\n 3. Checklist Goal");
                        Console.Write("Which type of goal would you like to create? ");
                        string goalInput = Console.ReadLine();

                        if (int.TryParse(goalInput, out int goalType))
                        {
                            Console.Write("Enter the goal name: ");
                            string name = Console.ReadLine();

                            Console.Write("Enter a description for the goal: ");
                            string description = Console.ReadLine();

                            Console.Write("Enter the point value for the goal: ");
                            if (double.TryParse(Console.ReadLine(), out double pointAmount))
                            {
                                Goal newGoal = null;

                                switch (goalType)
                                {
                                    // Simple Goal
                                    case 1:
                                        newGoal = new SimpleGoal(name, description, pointAmount);
                                        break;

                                    // Eternal Goal
                                    case 2:
                                        newGoal = new EternalGoal(name, description, pointAmount);
                                        break;

                                    // Checklist Goal
                                    case 3:
                                        Console.Write("Enter the amount of times the goal should be completed: ");
                                        if (int.TryParse(Console.ReadLine(), out int goalTimes))
                                        {
                                            Console.Write("What is the bonus for accomplishing it that many times? ");
                                            if (double.TryParse(Console.ReadLine(), out double bonusPoints))
                                            {
                                                newGoal = new ChecklistGoal(name, description, pointAmount, goalTimes, bonusPoints);
                                            }
                                        }
                                        break;
                                }
                            user.AddGoal(newGoal);
                            Console.WriteLine("Goal created.");
                            }
                        }
                        break;

                    // List Goals
                    case 2:
                    Console.Clear();
                    foreach (Goal goal in user.Goals)
                    {
                        goal.DisplayGoal();
                    }
                    break;

                    // Save Goals
                    case 3:
                    Console.Clear();
                    Console.Write("Enter a filename to save goals to: ");
                    string saveFile = Console.ReadLine();
                    user.SaveGoals(saveFile);
                    break;

                    // Load Goals
                    case 4:
                    Console.Clear();
                    Console.Write("Enter a file to load goals from: ");
                    string loadFile = Console.ReadLine();
                    user.LoadGoals(loadFile);
                    break;

                    // Record Event
                    case 5:
                    Console.Clear();
                    Console.WriteLine("Which goal did you complete? ");
                    // I start with 1 because its easier to read
                    int displayIndex = 1;
                    foreach (Goal goal in user.Goals)
                    {
                        Console.WriteLine($"{displayIndex}. {goal.Name}");
                        displayIndex++;
                    }
                    string recordInput = Console.ReadLine();
                    // Don't forget to subtract 1 here!
                    user.Goals[int.Parse(recordInput) - 1].CompleteGoal(user);
                    break;
                }
            }
        }
    }
}