using System;

public class OutdoorGatheringEvent : Event
{
    private string _weather;

    public OutdoorGatheringEvent(string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
    {
        _weather = "Sunny";
    }

    public override string GetFullDetails()
    {
        return "Outdoor Gathering Event: " + GetStandardDetails() + " Weather: " + _weather;
    }

    public override string GetShortDescription()
    {
        string standardDetails = GetStandardDetails();
        string[] parts = standardDetails.Split(",");
        return "Outdoor Gathering Event: " + parts[0] + "," + parts[2];
    }

    public void GetCurrentWeather()
    {
        // Place holder for actual code that gets the current weather.
        _weather = "Cloudy";
    }
}