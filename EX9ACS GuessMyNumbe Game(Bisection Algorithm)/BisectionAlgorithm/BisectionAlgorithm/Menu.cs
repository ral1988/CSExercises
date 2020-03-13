using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace BisectionAlgorithm
{
    class Menu
    {
        public Menu()
        {
            MenuOptions();
        }

        public void MenuOptions()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;   
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Welcome to the Guessing Game");
            Console.WriteLine();
            Console.WriteLine("Which game would you like to play?");
            Console.WriteLine("1. Guess a number between 1 - 10");
            Console.WriteLine("2. Guess a number between 1 - 1000");
            Console.WriteLine("3. Have the computer guess a number between 1 - 1000");
            Console.WriteLine("Q. Quit application");
            Console.WriteLine("Selection: ");
            var userInput = Console.ReadKey();
            

            while (userInput.Key != ConsoleKey.D1 && userInput.Key != ConsoleKey.D2 && userInput.Key != ConsoleKey.D3 && userInput.Key != ConsoleKey.Q)
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input. Try Again.");
                userInput = Console.ReadKey();
            }

            if (userInput.Key == ConsoleKey.D1)
            {
                new InitialGame();
            }

            if (userInput.Key == ConsoleKey.D2)
            {
                new HumanPlayer();
            }

            if (userInput.Key == ConsoleKey.D3)
            {
                new ComputerPlayer();
            }
            if (userInput.Key == ConsoleKey.Q)
            {
                Environment.Exit(0);
            }

        }
    }
}
