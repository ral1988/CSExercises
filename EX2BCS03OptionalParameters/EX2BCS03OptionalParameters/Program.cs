//Syntactic Sugar is a syntax within the programming language 
//that allows the code to be easier to express and/or read. 
//I do not know if I understood this exercise completely. 

using System;

namespace EX2BCS03OptionalParameters
{
    class OverloadingFunctions
    {
       public void area(int number)
        {
            int square = number * number;
            Console.WriteLine($"The area of a square is {square}.");
        }

        public void area (int number1, int number2)
        {
            int rectangle = number1 * number2;
            Console.WriteLine($"The area of the rectangle is {rectangle}.");
        }
    }
    class Program 
    {    
        public static void Main(string[] args)
        {
            OverloadingFunctions whichFunction = new OverloadingFunctions();
            Console.WriteLine("We are going to determine the area of a rectangle or square depending on the numbers you provide.");
            Console.Write("Provide the first number: ");
            string number1 = Console.ReadLine();
            int num1 = int.Parse(number1);
            Console.Write("Provide the second number: ");
            string number2 = Console.ReadLine();
            int num2 = int.Parse(number2);
            bool numsAreEqual = (num1 == num2);

            if (numsAreEqual)
            {
                whichFunction.area(num1);
            }
            else
            {
                whichFunction.area(num1, num2);
            }

           Console.ReadLine();
        }
    }
}
 
