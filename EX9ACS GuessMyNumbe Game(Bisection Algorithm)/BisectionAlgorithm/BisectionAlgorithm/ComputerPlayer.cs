﻿//Guess my number, computer plays
//
//Implement a version of Guess My Number, where the human chooses a number between 1 and 100, and the computer guesses the number.
//The human should be able to tell the computer whether the computer’s guess was too high, too low, or was the correct answer. Run
//this multiple times and compute the average number of repetitions necessary for the computer to guess the number. Have the program
//print the value, the guess, and the list on each repetition.
//
//Is the human as good as the computer in finding the number?
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BisectionAlgorithm
{
    class ComputerPlayer
    {
        static ComputerPlayer()
        {
            Console.WriteLine("For this game, you will think of a number between 1 and 100");
            Console.WriteLine("The computer will print it's guess on the screen and you'll reply with");
            Console.WriteLine("L: Too low, H: Too high, C: correct number");
            Console.WriteLine("Hit any key when you are ready to play");
            Console.ReadKey();

            int max = 100;
            int min = 1;  

            int[] arr = new int[2]{min, max};

                for (int i = 0; i < 100; i++)
                {
                    

                    int guess = BisectionMethod.ComputerGuess(arr[0], arr[1]);

                    Console.WriteLine($"Is your number {guess}");

                         

                    var userInput = Console.ReadKey();

                    while (userInput.Key != ConsoleKey.L && userInput.Key != ConsoleKey.H && userInput.Key != ConsoleKey.C)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid input. Try Again.");
                        userInput = Console.ReadKey();
                    }

                    if (userInput.Key == ConsoleKey.L)
                    {
                        
                    }

                    if (userInput.Key == ConsoleKey.H)
                    {
                       
                    }

                    if (userInput.Key == ConsoleKey.C)
                    {
                        Console.WriteLine($"Yay! I got the answer and it took me {i} tries.");
                        break;
                    }

                
                }

         
        }
    }
}
