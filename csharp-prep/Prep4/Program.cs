using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int givenNumber = -1;
        while (givenNumber != 0)
        {
            Console.Write("Enter number: ");
            string response = Console.ReadLine();
            givenNumber = int.Parse(response);

            if (givenNumber != 0)
            {
                numbers.Add(givenNumber);
            }

        }

        // Compute the sum.
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The total is {sum}.");

        // Compute the average.
        float average = ((float)sum) / numbers.Count;

        Console.WriteLine($"The average is: {average}.");

        // Determine the hightest number.
        int highest = 0;

        foreach (int number in numbers)
        {
            highest;
        }




    }
}