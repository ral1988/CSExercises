using NUnit.Framework;
using System;

namespace EX3ACSCAlculatingAverages
{
    }
    class Program
    {
        static void Main(string[] args)
        {
        double sum = 0;
        double input = 1;
        double numbers = 0.0d;
        double sumGrade = 0.0d;
        double avgGrade = 0.0d;
        int iteration = 1;


        Console.WriteLine("Welcome to the Calculating place");
        Console.WriteLine("Where your number dreams will come true!");
        HitAnyKey();
        Console.WriteLine("We are going to find the sum of 10 numbers");
        Console.Write("Input 10 numbers (between 0 and 100) \n");

        do
        {
            Console.Write($"Number {input}: ");
            numbers = double.Parse(Console.ReadLine());
            if ((numbers < 0) || (numbers > 100))
            {
                Console.WriteLine("Please provide a number that is greater than 0 and less than 100");
                continue;
            }

            else

                sum += numbers;
            ++input;
        } while (input < 11);

        
        Console.WriteLine($"The sum of 10 numbers is : {sum}");
        HitAnyKey();

        Console.Write("Input 10 test grades (between 0 and 100) \n");

        sum = 0;
        input = 1;
        numbers = 0.0d;
        sumGrade = 0.0d;
        avgGrade = 0.0d;
        iteration = 1;

        do
        {
            Console.Write($"Test Grade {input}: ");
            numbers = double.Parse(Console.ReadLine());
            if ((numbers < 0) || (numbers > 100))
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

        GradeAverage(avgGrade);
        HitAnyKey();

        sum = 0;
        input = 1;
        numbers = 0.0d;
        sumGrade = 0.0d;
        avgGrade = 0.0d;
        iteration = 1;

        Console.Write("How many tests are you entering in?: ");
        var testCount = Console.ReadLine();
        int testNumber = int.Parse(testCount);

        Console.Write("Input grade values (between 0 and 100) \n");

        do
        {
            Console.Write($"Test Grade-{iteration}: ");
            numbers = Convert.ToDouble(Console.ReadLine());
            if ((numbers < 0) || (numbers > 100))
            {
                Console.WriteLine("Please provide a number that is greater than 0 and less than 100");
                continue;
            }
            else

                sumGrade += numbers;
            ++iteration;
        } while (iteration < (testNumber + 1));

        avgGrade = sumGrade / testNumber;

        Console.WriteLine($"The average numberical grade: {avgGrade}\n");
        GradeAverage(avgGrade);
        HitAnyKey();

        Console.Write("Input grade values (between 0 and 100) \n");
        Console.WriteLine("To quit, type 'quit'");

        sum = 0;
        numbers = 0.0d;
        sumGrade = 0.0d;
        avgGrade = 0.0d;
        iteration = 1;
        do
        {
            Console.Write($"Test Grade-{iteration}: ");
            string nums = Console.ReadLine();
            if (nums == "quit")
            {
                break;
            }
            numbers = double.Parse(nums);
            if ((numbers < 0) || (numbers > 100))
            {
                Console.WriteLine("Please provide a number that is greater than 0 and less than 100");
                continue;
            }
            else

            sumGrade += numbers;
            ++iteration;
        } while (iteration > 1);

        avgGrade = sumGrade / (iteration - 1);

        Console.WriteLine($"The average numberical grade: {avgGrade}\n");

        GradeAverage(avgGrade);
        HitAnyKey();
    }

    private static void HitAnyKey()
    {
        Console.WriteLine("Hit any key to continue");
        Console.ReadKey();
        Console.Clear();
    }

    private static void GradeAverage(double avgGrade)
    {
        if ((avgGrade >= 95) && (avgGrade <= 100))
        {
            Console.WriteLine("Average letter grade is A");
        }
        if ((avgGrade >= 90) && (avgGrade < 95))
        {
            Console.WriteLine("Average letter grade is A-");
        }
        if ((avgGrade >= 85) && (avgGrade < 90))
        {
            Console.WriteLine("Average letter grade is B");
        }
        if ((avgGrade >= 80) && (avgGrade < 85))
        {
            Console.WriteLine("Average letter grade is B-");
        }
        if ((avgGrade >= 75) && (avgGrade < 80))
        {
            Console.WriteLine("Average letter grade is C");
        }
        if ((avgGrade >= 70) && (avgGrade < 75))
        {
            Console.WriteLine("Average letter grade is C-");
        }
        if ((avgGrade >= 65) && (avgGrade < 70))
        {
            Console.WriteLine("Average letter grade is D");
        }
        if ((avgGrade >= 60) && (avgGrade < 65))
        {
            Console.WriteLine("Average letter grade is D-");
        }
        if (avgGrade < 60)
        {
            Console.WriteLine("Students are failing");
        }
    }
    
}



