using System;
using System.Collections.Generic;
using System.Linq;
namespace ListsHW
{
    class Program
    {
        static void Main(string[] args)
        {   
            string answer;
            bool keepGoing = false;
            string firstName;
            List<string> myClass = new List<string> ();

            do
            {
                System.Console.Write("Please enter students first name: ");
                firstName = Console.ReadLine();
                myClass.Add(firstName);
                Console.Write("Do you have more students to be added? Yes --> continue.. ANY --> stop");
                answer = Console.ReadLine();
                if (answer.ToUpper() == "YES")
                {
                    keepGoing = true;
                }
                else
                {
                    keepGoing = false;
                }
            } while (keepGoing);
            Console.WriteLine($"There are {myClass.Count} students in this class.");
        }
    }
}
