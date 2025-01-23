using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Hildago Codes";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2012;
        job1._endYear = 2016;

        Job job2 = new Job();
        job2._company = "Coding is Fun";
        job2._jobTitle = "Senior Software Engineer";
        job2._startYear = 2016;
        job2._endYear = 2020;

        // Call to print function
        // job1.DisplayJobDetails();
        // job2.DisplayJobDetails();

        Resume myResume = new Resume();
        myResume._name = "Ricky Bobby";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}