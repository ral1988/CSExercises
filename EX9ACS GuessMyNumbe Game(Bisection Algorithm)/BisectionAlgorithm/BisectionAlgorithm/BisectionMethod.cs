using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace BisectionAlgorithm
{
    public static class BisectionMethod
    {
        public static int ComputerGuess()
        {
            int maxValue = 100;
            int minValue = 1;

            Console.WriteLine("Think of a number between 1 and 100 that you want the computer to guess.");
            Console.WriteLine();

            int[] numbers = Enumerable.Range(minValue, maxValue).ToArray();

            bool guessed = true;

            int count = 0;

            int MinMin = 0;

            int MaxMax = maxValue - 1;

            while (guessed)
            {
                count++;
               // NumberGen() = numbers[(MinMin + MaxMax) / 2];
            }
        }

        public static int NumberGen(int a, int b)
        {
           Random random = new Random();
           int number = random.Next(a, b);

           return number;
        }  
        


    }
}
