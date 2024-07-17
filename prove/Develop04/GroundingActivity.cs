class GroundingActivity : Activity {
    List<string> _senses = new List<string> {
        "Name five things you can see",
        "Name four things you can hear",
        "Name three things you can touch",
        "Name two things you can smell",
        "Name one thing you can taste"
    };
    public GroundingActivity(string activityName, string activityDescription) : base(activityName, activityDescription) {

    }
    public void RunActivity() {
        DateTime endTime = WelcomeMessage();
        DateTime startTime = DateTime.Now;
        while (startTime < endTime) {
            Console.Clear();
            while (startTime < endTime) {
                foreach (string sense in _senses) {
                    Console.Clear();
                    Console.WriteLine($"-- {sense} --");
                    for (int i = 0; i < 2; i++) {
                        Spinner();
                    }
                    startTime = DateTime.Now;
                    if (startTime > endTime) {
                        break;
                    }
                }
            }
        }
        CompletionMessage();
    }
}