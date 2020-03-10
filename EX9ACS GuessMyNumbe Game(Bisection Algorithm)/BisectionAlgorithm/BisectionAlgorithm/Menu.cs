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
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;   
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Welcome to the Guessing Game");
            Console.WriteLine();
            Console.WriteLine("Which game would you like to play?");
            Console.WriteLine("1. Guess a number between 1 - 10");
            Console.WriteLine("2. Guess a number between 1 - 1000");
            Console.WriteLine("3. Have the computer guess a number between 1 - 1000");
            Console.WriteLine("Selection: ");
            var userInput = Console.ReadLine();


        }
    }
}
