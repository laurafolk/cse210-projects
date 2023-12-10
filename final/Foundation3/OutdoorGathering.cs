using System;
using System.Text;
class OutdoorGathering : Event
{
    private string _weatherStatement;

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weatherStatement)
        : base(title, description, date, time, address)
    {
        _weatherStatement = weatherStatement;
    }

    public override string GetFullDetails()
    {
        StringBuilder sb = new StringBuilder(base.GetFullDetails());
        sb.AppendLine($"Type: Outdoor Gathering");
        sb.AppendLine($"Weather: {_weatherStatement}");
        return sb.ToString();
        //return $"{base.GetFullDetails()}\nType: Outdoor Gathering\nWeather: {_weatherStatement}";
    }
}