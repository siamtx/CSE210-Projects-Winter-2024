using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);

        if (number >= 90)
        {
            Console.Write("A");
        }
        else if (number >= 80 && number < 90)
        {
            Console.Write("B");
        }
        else if (number >= 70 && number < 80)
        {
            Console.Write("C");
        }
        else if (number >= 60 && number < 70)
        {
            Console.Write("D");
        }
        else if (number < 60)
        {
            Console.Write("F");
        }

        if (!(D ||F))
        {
            Console.Write("Congratulations! You passed the course");
        }
        else
        {
            Console.Write("Keep trying! You will get it next time.");
        }




    }
}