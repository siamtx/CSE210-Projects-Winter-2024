using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);

        /***********************************************
        if (number >= 90)
        {
            Console.WriteLine("A");
        }
        else if (number >= 80 && number < 90)
        {
            Console.WriteLine("B");
        }
        else if (number >= 70 && number < 80)
        {
            Console.WriteLine("C");
        }
        else if (number >= 60 && number < 70)
        {
            Console.WriteLine("D");
        }
        else if (number < 60)
        {
            Console.WriteLine("F");
        }

        if (number >= 70)
        {
            Console.Write("Congratulations! You passed the course");
        }
        else
        {
            Console.Write("Keep trying! You will get it next time.");
        }

        **/

        string letter ="";

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80 && number < 90)
        {
            letter = "B";
        }
        else if (number >= 70 && number < 80)
        {
            letter = "C";
        }
        else if (number >= 60 && number < 70)
        {
            letter = "D";
        }
        else if (number < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}.");

        if (number >= 70)
        {
            Console.Write("Congratulations! You passed the course");
        }
        else
        {
            Console.Write("Keep trying! You will get it next time.");
        }




    }
}