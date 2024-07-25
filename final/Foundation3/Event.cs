class Event
{
    private string _eventName;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string eventName, string description, string date, string time, Address address)
    {
        _eventName = eventName;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public Event ()
    {
    }

public string Details()
{
    return $"Event name:{_eventName}: {_description}, date: {_date}, {_time}, {_address}.";

}
public virtual string FullDetails()
{
return Details();
}
public string ShortDescription()
{
return $"Event type{this.GetType().Name } Event name: {_eventName}-{_date}";
}

}