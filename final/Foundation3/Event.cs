using System.Diagnostics;
using System.Net.Sockets;

public abstract class Event 
{
    private string _eventType = "";
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }

    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    public string Date
    {
        get { return _date; }
        set { _date = value; }
    }

    public string Time
    {
        get { return _time; }
        set { _time = value; }
    }

    public Address Address
    {
        get { return _address; }
        set { _address = value; }
    }

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    protected void SetEventType(string EventType)
    {
        _eventType = EventType;
    }

    public string GetEventType()
    {
        return _eventType;
    }

    public void DisplayStandardDetails()
    {
        Console.WriteLine($"{_title}\n {_description}\n{_date}, {_time}\n{_address.GetDisplayableAddress()}");
    }

    public abstract void DisplayFullDetails();

    public void ShortDescription()
    {
        Console.WriteLine($"Event Type: {_eventType}");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Date: {_date}");
    }  

}