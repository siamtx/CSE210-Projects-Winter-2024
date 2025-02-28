

public class Breathe : Activity
{
    private string _BreatheDescription = "This activity will help you relax by walking you through breathing in and out slowly.  Clear your mind and focus on your breathing.";

    // constructor to call base class
    public StartMessagePrompt(string userSelection) : base(userSelection)
    {
        userSelection;
    }

    // for loop for countdown
    public Countdown(float _duration)
    {
        for (int i = 0; i < _duration; i++)
        {
            Console.WriteLine("Breathe in");
            // countdown
            Console.WriteLine("Breathe out");
        }
    }
}