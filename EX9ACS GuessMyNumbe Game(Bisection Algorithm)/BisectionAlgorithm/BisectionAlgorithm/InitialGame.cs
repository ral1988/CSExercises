//Implement bisection algorithm

//Write a console application implementing the bisection algorithm. As the initial
//list, use an integer array from 1 to 10,
//like this: int[] list = 1,2,3,4,5,6,7,8,9,10;.
//As input, have the user select a number from 1 to 10.
//Have the application print each step. Use appropriate exception handling to guard
//against invalid input from the user.
//


using System;
using System.Collections.Generic;
using System.Text;

namespace BisectionAlgorithm
{
    class InitialGame
    {
        static InitialGame()
        {
            var check = new CheckNumbers();
            List<int> tenInts = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            Console.WriteLine("I am going to show you how I can guess your number using the bisection algorithm");
            Console.WriteLine("Enter a number between 1-10: ");
            check.InbetweenNumbersCheck(1, 10);


            foreach (var i in tenInts){}
            {
                Console.WriteLine(tenInts);
            }


            
        }
    }
}
