using System;
using Microsoft.VisualBasic;

class Journal
{
    List<string> book = new List<string>();

    book.Add("poo");

    book.Save(book);

    book.Load(book);

    public void Display()
    {
        Console.WriteLine();
    }


}