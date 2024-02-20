using System;

public class LectureEvent : Event
{
    private string _speakerName;
    private int _capacity;

    public LectureEvent(string title, string description, string date, string time, Address address, string speakerName, int capacity) : base(title, description, date, time, address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return "Lecture Event: " + GetStandardDetails() + " Speaker: " + _speakerName + " Capacity: " + _capacity.ToString();
    }

    public override string GetShortDescription()
    {
        string standardDetails = GetStandardDetails();
        string[] parts = standardDetails.Split(",");
        return "Lecture Event: " + parts[0] + "," + parts[2];
    }
}