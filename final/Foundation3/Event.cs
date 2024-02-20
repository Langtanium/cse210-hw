using System;

public abstract class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return _title + ", " + _description + ", " + _date + ", " + _time + " <" + _address.GetDisplayText() + ">";
    }

    public abstract string GetFullDetails();

    public abstract string GetShortDescription();
}