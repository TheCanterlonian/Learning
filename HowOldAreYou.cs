using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HowOldAreYou
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime nowTime = DateTime.Now;
            Console.WriteLine("The current date and time is: " + nowTime);
            Console.WriteLine();
            Console.WriteLine("When were you born?");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            TimeSpan elapsedTime = DateTime.Now.Subtract(birthDate);
            Console.WriteLine();
            Console.WriteLine("You are " + elapsedTime.Days + " days old.");
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
            Console.WriteLine();
        }
    }
}

