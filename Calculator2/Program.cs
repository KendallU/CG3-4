using System;

namespace Calculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kendall's Calculator!");
            /* variables
             
            int firstNumber;
            int secondNumber;
            int answer;
            string operation;
            */

            /*gather user information
             */

            Console.WriteLine("What is your first number?");
            Console.Write("Type number here:");
            string firstNumber;
            firstNumber = Console.ReadLine();

            Console.WriteLine("What is your second number?");
            Console.Write("Type number here:");
            string secondNumber;
            secondNumber = Console.ReadLine();

            int firstNumb = int.Parse(firstNumber);
            int secondNumb = int.Parse(secondNumber);
            int answer;

            /*user operations
             */

            Console.WriteLine("What do you want to do? Add, Subtract, Multipy, or Divide?");
            string operation;
            operation = Console.ReadLine();

            if (operation == "Add")
            {
                answer = firstNumb + secondNumb;
                Console.WriteLine(firstNumb + "+" + secondNumb + "=" + answer);
                Console.ReadLine();
            }
            else if (operation == "Subtract")
            {
                answer = firstNumb - secondNumb;
                Console.WriteLine(firstNumb + "-" + secondNumb + "=" + answer);
                Console.ReadLine();
            }
            else if (operation == "Multiply")
            {
                answer = firstNumb * secondNumb;
                Console.WriteLine(firstNumb + "*" + secondNumb + "=" + answer);
                Console.ReadLine();
            }
            else if (operation == "Divide")
            {
                answer = firstNumb / secondNumb;
                Console.WriteLine(firstNumb + "/" + secondNumb + "=" + answer);
                Console.ReadLine();
            }
            else
                    {
                Console.Write("Sorry I don't understand!");
                Console.ReadLine();
            }
            }
        }
    }
