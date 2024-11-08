using Microsoft.Win32.SafeHandles;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        Name = "Breathing";
        Description = "This activity will help you relax by walking through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    // Method for the Breathing Activity functionality. Write a string to the console, play the countdown, and repeat. The loop exits when the alloted time has passed.
    public void Breathe()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
        Console.WriteLine("Breathe in...");
        CountdownAnimation(5);
        Console.WriteLine("Breathe out...");
        CountdownAnimation(5);
        Console.Write("\n");
        }
    }

    public void ExecuteBreathingActivity()
    {
        PrintStartMessage();
        Breathe();
        PrintEndMessage();
    }
}
