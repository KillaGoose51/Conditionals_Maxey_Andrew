using System;

namespace Conditionals_Maxey_Andrew
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks user for whole numver and assigns to integer variable
            Console.WriteLine("Enter a whole number, please!");
            int myWholeNum = Convert.ToInt32(Console.ReadLine());

            // Checks if positive or negative
            if (myWholeNum >= 0)
            {
                Console.WriteLine($"{myWholeNum} is a positive number!");
            }
            else
            {
                Console.WriteLine($"{myWholeNum} is a negative number!");
            }

            // Checks if even or odd
            if(myWholeNum % 2 == 0)
            {
                Console.WriteLine($"{myWholeNum} is a even number!");
            }
            else
            {
                Console.WriteLine($"{myWholeNum} is a odd number!");
            }

            // Creates two more integer numbers
            int num1 = 6;
            int num2 = 99;

            // Gets first max
            int firstMax = Math.Max(myWholeNum, num1);
            // Gets maxiumum number
            int max = Math.Max(firstMax, num2);

            // Prints max to console
            Console.WriteLine($"The maxium number of {myWholeNum}, {num1}, and {num2}, is {max}!");

            // Asks user to enter a grade and assigns it to a char variable, grade
            Console.WriteLine("Enter a grade (A, B, C, D, F)!");
            char grade = Console.ReadKey().KeyChar;

            // Prints desciption based on grade value 
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("\nSuperior");
                    break;
                case 'B':
                    Console.WriteLine("\nVery Good");
                    break;
                case 'C':
                    Console.WriteLine("\nAverage");
                    break;
                case 'D':
                    Console.WriteLine("\nBelow Average");
                    break;
                case 'F':
                    Console.WriteLine("\nFail");
                    break;
                default:
                    Console.WriteLine("\nYou did not enter a valid grade!");
                    break;
            }
        }
    }
}
