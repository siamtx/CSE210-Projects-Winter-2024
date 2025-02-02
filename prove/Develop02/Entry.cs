using System;

class Entry
{
    string _userinput = " ";
    string _dateTime = " ";

    public void Display()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        //Console.WriteLine("_dateTime");
    }

}