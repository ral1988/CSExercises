using System;

namespace BisectionAlgorithm
{
    public static class BisectionMethod
    {
        public static int ComputerGuess(double a, double b)
        {
            var guessMath = Math.Round((a + b) / 2, 0, MidpointRounding.AwayFromZero);

            int guess = Convert.ToInt32(guessMath);

            return guess;

        }

        public static int NumberGen(int a, int b)
        {
           Random random = new Random();
           int number = random.Next(a, b);

           return number;
        }  
        
    }
}
