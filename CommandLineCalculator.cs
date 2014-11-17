using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool doIContinue = true;
            while (doIContinue == true)
            {
                Console.WriteLine("Calculator");
                Console.WriteLine("Input number one");
                double numberOne = Double.Parse(Console.ReadLine());
                Console.WriteLine("Input opperation.");
                string opperating = Console.ReadLine();
                Console.WriteLine("Input number two");
                double numberTwo = Double.Parse(Console.ReadLine());
                double answer = 0;
                if (opperating == "-")
                    answer = subtraction(numberOne, numberTwo);
                else if (opperating == "+")
                    answer = addition(numberOne, numberTwo);
                else if (opperating == "*")
                    answer = multiply(numberOne, numberTwo);
                else if (opperating == "/")
                    answer = divide(numberOne, numberTwo);
                //TODO: Implement other opperations
                else
                    Console.WriteLine("That opperation hasn't been implemented.");
                Console.WriteLine("The answer is: " + answer);
                bool contSL = true;
                while (contSL == true)
                //DOC: Below will never throw an exception
                {
                    contSL = false;
                    Console.WriteLine("Continue [Y/N]?");
                    string continuation = Console.ReadLine();
                    if ((continuation == "n") || (continuation == "N"))
                        doIContinue = false;
                    else if ((continuation == "y") || (continuation == "Y"))
                        doIContinue = true;
                    else
                        contSL = true;
                }
            }
        }
        //DOC: Mathematical methods below
        static double divide(double InputOne, double InputTwo)
        {
            double outputOfDiv = InputOne / InputTwo;
            return outputOfDiv;
        }
        static double multiply(double InputOne, double InputTwo)
        {
            double outputOfMult = InputOne * InputTwo;
            return outputOfMult;
        }
        static double subtraction(double InputOne, double InputTwo)
        {
            double outputOfSub = InputOne - InputTwo;
            return outputOfSub;
        }
        static double addition(double InputOne, double InputTwo)
        {
            double outputOfAdd = InputOne + InputTwo;
            return outputOfAdd;
        }
    }
}
