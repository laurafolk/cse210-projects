using System;
using System.Text;
class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }
    public override string GetFullDetails()
    {
        StringBuilder sb = new StringBuilder(base.GetFullDetails());
        sb.AppendLine($"Type: Reception");
        sb.AppendLine($"RSVP Email: {_rsvpEmail}");
        return sb.ToString();
    }

    // public override string GetFullDetails()
    // {
    //     return $"{base.GetFullDetails()}\nType: Reception\nRSVP Email: {_rsvpEmail}";
    // }
}