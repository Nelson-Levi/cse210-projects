public class OutdoorEvent : Event
{
    private string _weather = "";

    public OutdoorEvent(string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
    {
        SetEventType("Outdoor");
    }

    Random random = new Random();
    public void ChangeWeather()
    {
       List<string> weatherStrings = new List<string>{"Sunny", "Cloudy", "Rainy", "Windy"};
       int randomInt = random.Next(0, 4);
       string newWeather = weatherStrings[randomInt];
       _weather = newWeather;
    }

    public override void DisplayFullDetails()
    {
        ChangeWeather();
        Console.WriteLine($"Event Type: {GetEventType()}\nTitle: {Title}");
        Console.WriteLine($"Weather Forecast: {_weather}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Date: {Date} Time: {Time}");
        Console.WriteLine(Address.GetDisplayableAddress());
    }
}