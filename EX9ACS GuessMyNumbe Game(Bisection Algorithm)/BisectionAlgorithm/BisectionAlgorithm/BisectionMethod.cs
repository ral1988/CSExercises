using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BisectionAlgorithm
{
    public static class BisectionMethod
    {
        public static int ComputerGuess(int a, int b)
        {
            int min = a;
            int max = b;

            double guess = (min + max) * 0.5 ;

            double math = Math.Round(guess, 0, MidpointRounding.AwayFromZero);

            int computerGuess = Convert.ToInt32(math);


            return computerGuess;
        }

        public static int NumberTenGenerator()
        {
           Random random = new Random();
           int number = random.Next(1, 10);

           return number;
        }

        public static int NumberHundredGenerator()
        {
            Random random = new Random();
            int number = random.Next(1, 100);

            return number;
        }

        public static int NumberThousandGenerator()
        {
            Random random = new Random();
            int number = random.Next(1, 1000);

            return number;
        }


    }
}
