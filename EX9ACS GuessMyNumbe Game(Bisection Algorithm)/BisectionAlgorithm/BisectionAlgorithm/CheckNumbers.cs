﻿using System;

namespace BisectionAlgorithm
{
    class CheckNumbers
    {
        static CheckNumbers()
        {

        }

        public int IntCheck(string a)
        {
            //check for valid input and prompt end user with correction
            int value = 0;
            bool returnError = false;

            do
            {
                string userInput = a;
                bool quickCheck = int.TryParse(userInput, out _);

                if (quickCheck == true)
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Not a valid input. Please try again and provide a integer number: ");
                }
            } while (returnError == false);

            return value;

        }

        public int InbetweenNumbersCheck(int a, int b, string input)
        {
            int value = 0;
            bool returnError = false;

            string userInput = input;

            IntCheck(userInput);

            do
            {
                bool quickCheck = int.TryParse(userInput, out _);

                if (quickCheck == true)
                {
                    value = int.Parse(userInput);

                    if (value >= a && value <= b)
                    {
                        returnError = true;
                    }
                    else
                    {
                        Console.WriteLine("Numbers provided are out of range. Please provide different numbers: ");
                    }
                    return value;
                }
                else
                {
                    Console.WriteLine("Not a valid input. Please try again and provide a integer number: ");
                }
            } while (returnError == false);

            return value;

        
        }
    }
}
