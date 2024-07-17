class Activity {
    string _activityName;
    int _time;
    string _activityDescription;
    List<string> _spinnerAnimations = new List<string> {"-", "\\", "|", "/"};

    public Activity(string activityName, string activityDescription) {
        _activityName = activityName;
        _activityDescription = activityDescription;
    }

    protected DateTime WelcomeMessage() {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} activity");
        Thread.Sleep(1000);
        Console.WriteLine(_activityDescription);
        _time = GetTime();
        Thread.Sleep(1000);
        Console.WriteLine("Get ready");
        Spinner();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_time);
        return endTime;
    }

     private int GetTime() {
        Console.Write("How many seconds do you want the activity to last for?");
        _time = int.Parse(Console.ReadLine());
        return _time;
    }

    protected void CompletionMessage() {
        Console.Clear();
        Console.WriteLine("Activity done");
        Thread.Sleep(500);
        Console.WriteLine($"Your {_activityName} session lasted {_time} seconds");
        Spinner();
    }

    protected void Countdown(int countdownTime) {
        for (int i = countdownTime; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    protected void Spinner() {
        for (int i = 0; i < 3; i++) {
            foreach (string animation in _spinnerAnimations) {
                Console.Write(animation);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }
    }
}