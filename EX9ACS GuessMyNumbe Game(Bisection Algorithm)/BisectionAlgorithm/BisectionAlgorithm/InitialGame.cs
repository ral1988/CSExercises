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
            
            Console.WriteLine("I am going to show you how I can guess your number using the bisection algorithm");
            Console.WriteLine("Enter a number between 1-10: ");
            int numberToGuess = BisectionMethod.NumberGen(1, 10);

            for (int i = 1; i < 10; i++)
            {
                string input = Console.ReadLine();
                check.InbetweenNumbersCheck(1, 10, input);

                int convertToInt = int.Parse(input);

                if (convertToInt > numberToGuess)
                {
                    Console.WriteLine("You guessed too high. Try again");
                }

                if (convertToInt < numberToGuess)
                {
                    Console.WriteLine("You guessed too low. Try again");
                }

                if (convertToInt == numberToGuess)
                {
                    Console.WriteLine("You guessed correctly!");
                    Console.WriteLine($"It took you {i} tries to guess {numberToGuess}!");
                    Console.WriteLine("Hit any key to continue");
                    Console.ReadKey();
                    
                    Console.Clear();
                    Menu.MenuOptions();
                }
            }

        }
    }
}
