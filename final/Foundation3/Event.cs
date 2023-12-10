using System;
using System.Text;
class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private TimeSpan _time;
    private Address _address;

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Title: {_title}");
        sb.AppendLine($"Description: {_description}");
        sb.AppendLine($"Date: {_date.ToShortDateString()}");
        sb.AppendLine($"Time: {_time}");
        sb.AppendLine($"Address: {_address}");
        return sb.ToString();
    }
    public string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time}\nAddress: {_address}";
    }

    public virtual string GetFullDetails()
    {
        return ToString();
    }

    public string GetShortDescription()
    {
        return $"Type: Generic Event\nTitle: {_title}\nDate: {_date.ToShortDateString()}";
    }
}