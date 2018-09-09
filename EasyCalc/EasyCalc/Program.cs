using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    double first, second, result = 0;
                    String operation;

                    Console.WriteLine("Input first variable");
                    first = GetNumber();

                    Console.WriteLine("Input second variable");
                    second = GetNumber();

                    Console.WriteLine("Input operation");
                    operation = Console.ReadLine();

                    if (operation == "+")
                    {
                        result = addition(first, second);
                    }
                    else if (operation == "-")
                    {
                        result = subtraction(first, second);
                    }
                    else if (operation == "*")
                    {
                        result = multiplication(first, second);
                    }
                    else if (operation == "/")
                    {
                        result = division(first, second);
                    }
                    else
                    {
                        Console.WriteLine("Wrong operation");
                    }

                    Console.WriteLine("Result: " + result + " \n====================");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Something comes wrong. Let's just continue.");
                }
            }



        }

        public static double GetNumber()
        {
            double number;
            String numberAsString = Console.ReadLine();

            number = Convert.ToDouble(numberAsString);

            return number;
        }

        public static double addition(double a, double b)
        {
            return a + b;
        }

        public static double subtraction(double a, double b)
        {
            return a - b;
        }

        public static double division(double a, double b)
        {
            return a / b;
        }

        public static double multiplication(double a, double b)
        {
            return a * b;
        }
    }
}
