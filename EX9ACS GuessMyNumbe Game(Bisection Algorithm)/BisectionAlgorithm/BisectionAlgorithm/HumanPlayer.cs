//Guess my number, human plays
//
//Implement a version of Guess My Number, where the computer randomly chooses a number between 1 and 1000, and the human guesses the number.
//In this case, the program should print a hint with each repetition, either <Your guess was too high>, <Your guess was too low>,
//or <You guessed the number>. The human should then input the next guess. Run this multiple times and compute the average number
//of repetitions necessary for you to guess the number.
//
//What is the maximum number of guesses you need to guess a number between 1 and 1000? Recall that log2 1000 = 9.966 and that 210 = 1024.
//

using System;

namespace BisectionAlgorithm
{
    class HumanPlayer
    {
        static HumanPlayer()
        {
            var check = new CheckNumbers();
            
            Console.WriteLine("I am going to show you how I can guess your number using the bisection algorithm");
            Console.WriteLine("Enter a number between 1-1000: ");
            int numberToGuess = BisectionMethod.NumberGen(1, 1000);

                for (int i = 1; i < 1000; i++) 
                {
                string input = Console.ReadLine();
                check.InbetweenNumbersCheck(1, 1000, input);

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
