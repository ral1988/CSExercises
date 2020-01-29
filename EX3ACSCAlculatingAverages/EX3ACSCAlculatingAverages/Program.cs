using NUnit.Framework;
using System;

namespace EX3ACSCAlculatingAverages
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sum of numbers
            double sum = 0, input = 1, numbers = 0.0d;
            double avg = 0.0d;

            Console.Write("Input 10 numbers (between 0 and 100) \n");

            do
            {
                Console.Write($"Number {input}: ");
                numbers = double.Parse(Console.ReadLine());
                if (numbers < 0)
                {
                    Console.WriteLine("Please provide a number that is greater than 0 and less than 100" );
                    continue;
                }
                if (numbers > 100)
                {
                    Console.WriteLine("Please provide a number that is greater than 0 and less than 100");
                    continue;
                }
                else

                sum += numbers;
                ++input;
            } while (input < 11);


            Console.WriteLine($"The sum of 10 numbers is : {sum}");

            //Average Test Score
            double sumGrade = 0.0d;
            input = 1;
            numbers = 0.0d;
            double avgGrade = 0.0d;

            Console.Write("Input 10 test grades (between 0 and 100) \n");

            do
            {
                Console.Write($"Test Grade {input}: ");
                numbers = double.Parse(Console.ReadLine());
                if (numbers < 0)
                {
                    Console.WriteLine("Please provide a number that is greater than 0 and less than 100");
                    continue;
                }
                if (numbers > 100)
                {
                    Console.WriteLine("Please provide a number that is greater than 0 and less than 100");
                    continue;
                }
                else

                    sumGrade += numbers;
                ++input;
            } while (input < 11);

            avgGrade = sumGrade / 10.0;

            Console.WriteLine($"The average numberical grade: {avgGrade}\n");

            if ((avgGrade >= 95) && (avgGrade <= 100))
            {
                Console.WriteLine("Average letter grade is A");
                return;
            }
            if ((avgGrade >= 90) && (avgGrade < 95))
            {
                Console.WriteLine("Average letter grade is A-");
                return;
            }
            if ((avgGrade >= 85) && (avgGrade < 90))
            {
                Console.WriteLine("Average letter grade is B");
                return;
            }
            if ((avgGrade >= 80) &&(avgGrade < 85))
            {
                Console.WriteLine("Average letter grade is B-");
                return;
            }
            if ((avgGrade >= 75) && (avgGrade < 80))
            {
                Console.WriteLine("Average letter grade is C");
                return;
            }
            if ((avgGrade >= 70) && (avgGrade < 75))
            {
                Console.WriteLine("Average letter grade is C-");
                return;
            }
            if ((avgGrade >= 65) && (avgGrade < 70))
            {
                Console.WriteLine("Average letter grade is D");
                return;
            }
            if ((avgGrade >= 60) && (avgGrade < 65))
            {
                Console.WriteLine("Average letter grade is D-");
                return;
            }
            else
            {
                Console.WriteLine("Students are failing");
                return;
            }

            //Average a specific number of scores
            //The teacher will input how many tests, and then the scores. 
            //Output will show the average numerical and letter grade. 
            //double sumGrade = 0.0d;
            //iteration = 1;
            //numbers = 0.0d;
            //double avgGrade = 0.0d;
            //Console.Writline("How many tests are you entering in?: ");
            //
            //Console.Write("Input 10 numbers (between 0 and 100) \n");

            //do
            //{
            //start:
            //    Console.Write($"Test Grade-{iteration}: ");
            //    numbers = Convert.ToInt32(Console.ReadLine());
            //    if (numbers < 0)
            //    {
            //        Console.WriteLine("Please provide a number that is greater than 0 and less than 100");
            //        goto start;
            //    }
            //    if (numbers > 100)
            //    {
            //        Console.WriteLine("Please provide a number that is greater than 0 and less than 100");
            //        goto start;
            //    }
            //    else

            //        sumGrade += numbers;
            //    ++input;
            //} while (iteration < 11);

            //avgGrade = sumGrade / 10.0;

            //Console.WriteLine($"The average numberical grade: {avgGrade}\n");

            //if (avgGrade > 95)
            //{
            //    Console.WriteLine("Average letter grade is A");
            //    return;
            //}
            //if (avgGrade > 90)
            //{
            //    Console.WriteLine("Average letter grade is A-");
            //    return;
            //}
            //if (avgGrade > 85)
            //{
            //    Console.WriteLine("Average letter grade is B");
            //    return;
            //}
            //if (avgGrade > 80)
            //{
            //    Console.WriteLine("Average letter grade is B-");
            //    return;
            //}
            //if (avgGrade > 75)
            //{
            //    Console.WriteLine("Average letter grade is C");
            //    return;
            //}
            //if (avgGrade > 70)
            //{
            //    Console.WriteLine("Average letter grade is C-");
            //    return;
            //}
            //if (avgGrade > 65)
            //{
            //    Console.WriteLine("Average letter grade is D");
            //    return;
            //}
            //if (avgGrade > 60)
            //{
            //    Console.WriteLine("Average letter grade is D-");
            //    return;
            //}
            //else
            //{
            //    Console.WriteLine("Students are failing");
            //    return;
            //}





        }
    }
}



