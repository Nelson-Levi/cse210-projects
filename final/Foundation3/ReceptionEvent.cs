public class ReceptionEvent : Event
{
    private string _email;

    public ReceptionEvent(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
    {
        SetEventType("Reception");
        _email = email;
    }

    public override void DisplayFullDetails()
    {
        Console.WriteLine($"Event Type: {GetEventType()}\nTitle: {Title}");
        Console.WriteLine($"RVSP: {_email}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Date: {Date} Time: {Time}");
        Console.WriteLine(Address.GetDisplayableAddress());
    }
}