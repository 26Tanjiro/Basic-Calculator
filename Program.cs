using System;
using System.ComponentModel;
using System.Diagnostics;

namespace project_f
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;

            // User input //

            Console.Write("ENTER NUMBER:");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("ENTER NUMBER:");
            num2 = double.Parse(Console.ReadLine());
            
            // INPUT NUMBER ONLY BASE TO THE SPECIFICATION TO EACH OPERATION //
            Console.WriteLine("| Addition 0 | \n| Subtraction 1 | \n| Multiplication 2 | \n| Division 3 |");
            Console.WriteLine("Choose the Operation you want to use:");
            int operation = int.Parse(Console.ReadLine());

            //process
            string results= Calculate(operation,num1,num2);
            Console.WriteLine(results);
        }
        public static string Calculate(int operation, double num1, double num2)
        {
            string answer = "";
            switch (operation)
            {
                case 0:
                    answer = $"The answer is {Add(num1, num2)}";
                    Console.WriteLine(num1 + "add to" + num2);

                    break;

                case 1:
                    answer = $"The answer is {Sub(num1, num2)}";
                    break;

                case 2:
                    answer = $"The answer is {Multiply(num1, num2)}";
                    break;
                case 3:
                   answer=$"The answer is  {Divide(num1, num2)}";
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
            return answer;
        }
        public static double Add(double num1, double num2 )
        {
            Console.WriteLine("Adding...");
            double answer=num1 + num2;
            return answer;
            
        }
        public static double Sub(double num1, double num2)
        {
            Console.WriteLine("Subtracting....");
            if (num1 > num2)
            {
                double results=num1 - num2;
                return results;
            }
           
            else
            {
                double answer= num2 - num1;
                Console.WriteLine("-" + answer);
                return answer;
            }

        }

        public static double Multiply(double num1, double num2)
        {
            Console.WriteLine("Multiplying......");
            double answer=num1 * num2;
            return answer;
        }
        public static double Divide(double num1, double num2)
        {
            Console.WriteLine("Dividing....");
            if (num2 != 0)
            {
               double results=num1 / num2;
               return results;
            }
            else
            {
                Console.WriteLine("Syntax Error, the second number or the last number should not equal to zero");
                return 0;

            }
        }

       
    }
}
