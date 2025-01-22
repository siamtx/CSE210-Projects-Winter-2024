using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();

        job1._company = "Hildago Codes";
        job1._jobTitle = "Software Engineer";

        Console.WriteLine(job1._company);
        Console.WriteLine(job1._jobTitle);

        Job job2 = new Job();

        job2._company = "Coding is Fun";
        job2._jobTitle = "Software Engineer Manager";

        Console.WriteLine(job2._company);
        Console.WriteLine(job2._jobTitle);
    }
}