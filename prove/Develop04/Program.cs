using System;

class Program
{
    static void Main(string[] args)
    {

        int userChoice = 0;
        do {
            Console.Clear();
            Console.WriteLine("\nPlease pick your activity:\n\n1. Breathing activity\n2. Listing activity\n3. Reflection activity\n4. Grounding Activity\n5. Quit");
            try {
                userChoice = int.Parse(Console.ReadLine());
            }
            catch {
                Console.WriteLine("Input must be a number between 1 and 5.");
                Thread.Sleep(1000);
            }
            if (userChoice == 1) {
                BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This breathing activity is made to help you relax by encouraging deep, slow breathing.");
                breathingActivity.RunActivity();
            }
            else if (userChoice == 2) {
                ListingActivity listingActivity = new ListingActivity("Listing", "This activity will help you reflect by listing good things in your life.");
                listingActivity.RunActivity();
            }
            else if (userChoice == 3) {
                ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection", "This activity will help you reflect on when you have shown strength and resilience. No writing is necessary");
                reflectionActivity.RunActivity();
            }
            else if (userChoice == 4) {
                GroundingActivity groundingActivity = new GroundingActivity("Grounding", "This grounding excersize helps you focus on the things around you to calm you down.");
                groundingActivity.RunActivity();
            }
        } while (userChoice != 5);

    }
}