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
            double elapsedYears = elapsedTime.TotalDays / 365.2425;
            double elapsedYearsRemainder = elapsedTime.TotalDays % 365.2425;
            elapsedYears = (int)elapsedYears;
            double elapsedYearsRemainderDaysRemainder = (int)elapsedYearsRemainder % 30;
            elapsedYearsRemainder = (int)elapsedYearsRemainder/ 30;
            Console.WriteLine();
            Console.WriteLine("You are " + elapsedTime.Days + " days, " + elapsedTime.Hours + " hours, and " + elapsedTime.Minutes + " minutes old.");
            Console.WriteLine();
            Console.WriteLine("You are " + elapsedYears + " years, " + elapsedYearsRemainder + " Stellaris months, and " + elapsedYearsRemainderDaysRemainder + " days old.");
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
            Console.WriteLine();
        }
    }
}
