using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double num1, num2;


                Console.WriteLine("What would you like to calculate? (+/-/*/div)");
                string Math = Console.ReadLine();

                if (Math == "+")
                {
                    Console.WriteLine("Write two numbers you would like to add.");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{num1} + ?");
                    num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{num1} + {num2}");
                    Console.WriteLine("This is the sum of your input:");

                    Addition add = new Addition
                    {
                        Number = num1
                    };

                    double resultA = add.Add(num2);
                    Console.WriteLine($"The result is {resultA}.");
                }

                else if (Math == "-")
                {
                    Console.WriteLine("Write two numbers you would like to subtract.");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{num1} - ?");
                    num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("This is the difference of your input:");
                    Subtraction sub = new Subtraction
                    {
                        Number = num1
                    };

                    double resultS = sub.Subtract(num2);
                    Console.WriteLine($"The result is {resultS}.");
                }

                else if (Math == "*")
                {
                    Console.WriteLine("Write two numbers you would like to multiply.");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{num1} * ?");
                    num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("This is the product of your input:");
                    Multiplication multi = new Multiplication
                    {
                        Number = num1
                    };

                    double resultM = multi.Multiply(num2);
                    Console.WriteLine($"The result is {resultM}.");
                }

                else if (Math == "div")
                {
                    Console.WriteLine("Write two numbers you would like to divide.");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{num1} / ?");
                    num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("This is the quotient of your input:");
                    Division div = new Division
                    {
                        Number = num1
                    };

                    double resultD = div.Divide(num2);
                    Console.WriteLine($"The result is {resultD}.");
                }

                Console.ReadLine();
            }
        }
    }
}
