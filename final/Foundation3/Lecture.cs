class Lecture : Event
{
    private string _speakerName;
    private int _capacity;

    public Lecture(string eventName, string description, string date, string time, Address eventAddress, string speakerName,int capacity)
        : base(eventName, description, date, time, eventAddress)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }


public override string FullDetails()
{
    return $"{base.FullDetails()}Speaker name: {_speakerName}, {_capacity}";
}

}