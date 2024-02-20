using System;
using System.Collections.Generic;

public class ReceptionEvent : Event
{
    private List<string> _attendeeEmails = new List<string>();

    public ReceptionEvent(string title, string description, string date, string time, Address address, List<string> attendeeEmails) : base(title, description, date, time, address)
    {
        _attendeeEmails = attendeeEmails;
    }

    public override string GetFullDetails()
    {
        return "Reception Event: " + GetStandardDetails() + " Number of attendees: " + _attendeeEmails.Count;
    }

    public override string GetShortDescription()
    {
        string standardDetails = GetStandardDetails();
        string[] parts = standardDetails.Split(",");
        return "Reception Event: " + parts[0] + "," + parts[2];
    }

    public void AddRSVPAttendee(string email)
    {
        _attendeeEmails.Add(email);
    }
}