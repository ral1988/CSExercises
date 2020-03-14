//Guess my number, computer plays
//
//Implement a version of Guess My Number, where the human chooses a number between 1 and 100, and the computer guesses the number.
//The human should be able to tell the computer whether the computer’s guess was too high, too low, or was the correct answer. Run
//this multiple times and compute the average number of repetitions necessary for the computer to guess the number. Have the program
//print the value, the guess, and the list on each repetition.
//
//Is the human as good as the computer in finding the number?
//

using System;

namespace BisectionAlgorithm
{
    class ComputerPlayer
    {
        static ComputerPlayer()
        {
            Console.Clear();
            Console.WriteLine("For this game, you will think of a number between 1 and 100");
            Console.WriteLine("The computer will print it's guess on the screen and you'll reply with");
            Console.WriteLine("L: Too low, H: Too high, C: correct number");
            Console.WriteLine("Hit any key when you are ready to play");
            Console.ReadKey();
            
            int[] arr = new int[2]{1, 100};

                for (int i = 1; i < 100; i++)
                {
                    

                    int guess = BisectionMethod.ComputerGuess(arr[0], arr[1]);

                    Console.WriteLine($"\nIs your number {guess}");

                         

                    var userInput = Console.ReadKey();

                    while (userInput.Key != ConsoleKey.L && userInput.Key != ConsoleKey.H && userInput.Key != ConsoleKey.C)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid input. Try Again.");
                        userInput = Console.ReadKey();
                    }

                    if (userInput.Key == ConsoleKey.L)
                    {
                        arr[0] = (arr[0] + arr[1]) / 2 + 1;
                    }

                    if (userInput.Key == ConsoleKey.H)
                    {
                        arr[1] = (arr[0] + arr[1]) / 2 - 1;
                    }

                    if (userInput.Key == ConsoleKey.C)
                    {
                        Console.WriteLine($"\nYay! I got the answer and it took me {i} tries.");
                        Console.WriteLine("Hit any key return to menu");
                        Console.ReadKey();

                        Console.Clear();
                        Menu.MenuOptions();
                    }

                
                }

         
        }
    }
}
