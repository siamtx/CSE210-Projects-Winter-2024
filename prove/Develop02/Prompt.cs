using System;

class Prompt
{
    // Atributes
    string _greeting = " ";


    List<String> prompts = new List<String>()
        {
            "Who was the most interesting person you spoke to today?";
            "Where did you go today?";
            "What do you have to be thankful for today?";
            "What was the strongest emotion you felt today?";
            "If I had one thing I could do over today, what would it be?";
            "What was the best part of my day?";
            "How did you feel when you saw the sun toady?";
        }

    public getPompt()
    {
        string selection = Console.ReadLine("");
    }


}

