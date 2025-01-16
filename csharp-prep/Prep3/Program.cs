using System;

class Program
{
    static void Main(string[] args)
    {
        /**************************************
        // Requirement 1
        // If statements/ No loop
        Console.Write("What is the magic number?  ");
        string response = Console.ReadLine();
        int output = int.Parse(response);

        Console.Write("What is your guess?  ");
        string guessResponse = Console.ReadLine();
        int compare = int.Parse(guessResponse);

        if (output > compare)
        {
            Console.Write("Higher");
        }
        else if (output < compare)
        {
            Console.Write("Lower");
        }
        else if (output == compare)
        {
            Console.Write("You guessed it!");
        }
        **************************************/

        /*************************************
        // Requirement 2
        // While loop

        int response = 0;
        int compare = 0;

        Console.Write("What is the magic number? ");
        string user = Console.ReadLine();
        response = int.Parse(user);

        while (response != compare)
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            compare = int.Parse(guess);

            if (response > compare)
            {
                Console.WriteLine("Higher!");
            }
            else if (response < compare)
            {
                Console.WriteLine("Lower!");
            }
            else
            {
                Console.Write("You guessed it!");
            }

        }

        *************************************/


        Random randomGenerator = new Random();

        int magicNumber = randomGenerator.Next(1, 101);

        //int response = 0;
        int compare = 0;

        Console.WriteLine("Can you guess the magic number? ");


        while (magicNumber != compare)
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            compare = int.Parse(guess);

            if (magicNumber > compare)
            {
                Console.WriteLine("Higher!");
            }
            else if (magicNumber < compare)
            {
                Console.WriteLine("Lower!");
            }
            else
            {
                Console.Write("You guessed it!");
            }

        }


    }
}