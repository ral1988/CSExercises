using System;

namespace BisectionAlgorithm
{
    class CheckNumbers
    {
        static CheckNumbers()
        {

        }

       public int InbetweenNumbersCheck(int a, int b, string input)
        {
            int value = 0;
            int guess;
            string userInput = input;
            bool quickCheck = int.TryParse(userInput, out guess);


            if (quickCheck)
            {

                if (quickCheck)
                {
                    value = int.Parse(userInput);

                    if (value >= a && value <= b)
                    {
                        quickCheck = true;
                    }
                    else
                    {
                        Console.WriteLine("Numbers provided are out of range. Please provide different numbers: ");

                    }

                    return value;
                }
            }

            else 
            {

                Console.WriteLine($"{userInput} is not a valid input. Please try again and provide a integer number: ");
                
            }

            return value;

        }
    }
}
