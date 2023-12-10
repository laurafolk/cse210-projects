using System;
using System.Text;
class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public override string GetFullDetails()
    {
        StringBuilder sb = new StringBuilder(base.GetFullDetails());
        sb.AppendLine($"Type: Lecture");
        sb.AppendLine($"Speaker: {_speaker}");
        sb.AppendLine($"Capacity: {_capacity} attendees");
        return sb.ToString();
    }

    // public override string GetFullDetails()
    // {
    //     return $"{base.GetFullDetails()}\nType: Lecture\nSpeaker: {_speaker}\nCapacity: {_capacity} attendees";
    // }
}