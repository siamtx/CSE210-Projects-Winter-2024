

using System.ComponentModel.Design;
using System.Xml.Serialization;

public class Activity
{

    private float _time = 0;
    private float _duration = 0;
    private string _userSelection;


    // do while loop here to run the menu program
    do
    {



        public void StartMessagePrompt()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("\t 1. Start breathing activity");
        Console.WriteLine("\t 2. Start reflection activity");
        Console.WriteLine("\t 3. Start listing activity");
        Console.WriteLine("\t 4. Quit");
        Console.WriteLine("Select a choice from the menu: ");
        _userSelection = Console.ReadLine();
    }

    // Get the Activity from the user
    public string GetActivity()
    {
        return _userSelection;
    }

    public float GetDuration()
    {
        return _duration;
    }

    public void PauseTimer()
    {
        ;// pause for 5 seconds
    }

    public void GoodJobMessage()
    {
        Console.WriteLine("Good Job!");
        PauseTimer();
        Console.WriteLine($"You have completed {_userSelection}.");
        Console.WriteLine($"You have completed {_duration} time.");
    }



} while (userSelection < 4) ;




}