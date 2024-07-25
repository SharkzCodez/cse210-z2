class Reception : Event
{
    private string rsvpEmail;

    public Reception(string eventName, string description, string date, string time, Address eventAddress, string rsvpEmail)
        : base(eventName, description, date, time, eventAddress)
    {
        this.rsvpEmail = rsvpEmail;
    }
public override string FullDetails()
{
    return $"{base.FullDetails()} RSVP email:{rsvpEmail}";
}
}