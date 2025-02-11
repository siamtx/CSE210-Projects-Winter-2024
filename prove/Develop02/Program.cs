using System;
using System.ComponentModel.Design;
using System.Net;
using System.Net.Quic;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        do
        {        
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");
            string last = Console.ReadLine();
            int choice = int.Parse(last);

            Entry enter = new Entry();
            Journal journal1 = new Journal();
            Prompt greet = new Prompt();

            if (choice == 1)
            {             
             enter.Display();
            }

            else if (choice == 2)
            {

            }
            else if (choice == 3)
            {
                Console.WriteLine("What is the file name?");
                string filename = Console.ReadLine();
                Journal
            }
            else if (choice == 4)
            {
                journal1.fileRead();
            }
            else if (choice == 5)
            {
            
            }
        }while (choice != 5);


    }

   

}