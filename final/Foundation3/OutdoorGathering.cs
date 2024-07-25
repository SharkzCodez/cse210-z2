class Outdoorgathering :Event
{
private string _weather;

    public Outdoorgathering(string eventName, string description, string date, string time, Address eventAddress, string weather)
        : base(eventName, description, date, time, eventAddress)
    {
        _weather = weather;
    }
public override string FullDetails()
{
    return $"{base.FullDetails()} predicted forcast:{_weather}";
}
}