using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation4 World!");

        RunningActivity running = new RunningActivity("18 Nov 2022", 30, 3);
        CyclingActivity cycling = new CyclingActivity("7 Jul 2024", 60, 5);
        SwimmingActivity swimming = new SwimmingActivity("9 Jun 2023", 45, 100);

        List<Activity> activitiesList = new List<Activity> { running, cycling, swimming};
        foreach (Activity activity in activitiesList)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}