using System.Runtime.CompilerServices;

public class LectureEvent : Event
{
    private string _speaker;
    private int _capacity;

    public LectureEvent(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        SetEventType("Lecture");
        _speaker = speaker;
        _capacity = capacity;
    }

    public override void DisplayFullDetails()
    {
        Console.WriteLine($"Event Type: {GetEventType()}\nTitle: {Title}");
        Console.WriteLine($"Speaker Name: {_speaker} Capacity: {_capacity}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Date: {Date} Time: {Time}");
        Console.WriteLine(Address.GetDisplayableAddress());
    }
}