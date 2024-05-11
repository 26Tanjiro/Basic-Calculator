using System;
using System.Diagnostics;

namespace project_f
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;

            // BASIC CALCULATOR CODING //

            Console.Write("ENTER NUMBER:");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("ENTER NUMBER:");
            num2 = double.Parse(Console.ReadLine());

            // PUT NUMBER ONLY BASE TO THE SPECIFICATION TO EACH OPERATION //
            Console.WriteLine("| Addition 0 | \n | Subtraction 1 | \n | Multiplication 2 | \n | Division 3 |");
            Console.WriteLine("Chosse the Operation you want to use:");
            int operation = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case 0:
                    Console.WriteLine(num1 + num2);
                    break;

                case 1:
                    if (num1 > num2)
                    {
                        Console.WriteLine(num1 - num2);
                    }
                    else
                    {
                        Console.WriteLine("Syntax Error, the first number should be greater than to the second number");
                    }
                    break;
                    
                case 2:
                    Console.WriteLine(num1 * num2);
                    break;
                case 3:
                    if (num2 != 0)
                    {
                        Console.WriteLine(num1 / num2);
                    }
                    else
                    { 
                        Console.WriteLine("Syntax Error, the second number or the last number should not equal to zero");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break; 
            }
            


        }
    }
}
