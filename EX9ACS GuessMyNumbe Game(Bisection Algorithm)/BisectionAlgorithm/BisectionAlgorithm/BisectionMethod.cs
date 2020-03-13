using System;
using System.Collections.Generic;
using System.Text;

namespace BisectionAlgorithm
{
    public static class BisectionMethod
    {
        public static double Calc(double a)
        {
            double input = a;

            double bisection = Math.Pow(input, 2) + input - 2; //is this the true bisection method

            return bisection;
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
