using System;


namespace progex01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1
    
        startPart1: 
            Console.WriteLine("\nPart 1, circumference and area of a circle.");
            Console.Write("Enter an number for the radius (greater than 0): ");
            string strradius = Console.ReadLine();
            double radius = double.Parse(strradius);
            bool greaterThanZeroRadius = radius > 0;

            if (!greaterThanZeroRadius)
            {
                Console.WriteLine("You provided a number less than 0");
                goto startPart1;
            }   
           
            // Implementation for area here
           
            var circumference = 2 * Math.PI * radius;
            Console.WriteLine($"The circumference is {circumference}");
            var secondPowerRadius = radius * radius;
            var area = Math.PI * secondPowerRadius;
            Console.WriteLine($"The area is {area}");
           
            // Part 2
            Console.WriteLine("\nPart 2, volume of a hemisphere.");

        startPart2:
            // Implementation here

            Console.Write("Enter an number for the radius (greater than 0): ");
            string strHemRadius = Console.ReadLine();
            double hemRadius = double.Parse(strHemRadius);
            bool greaterThanZeroHemRadius = hemRadius > 0;

            if (!greaterThanZeroHemRadius)
            {
                Console.WriteLine("You provided a number less than 0");
                goto startPart2;
            }

            var thirdPowerRadius = hemRadius * hemRadius * hemRadius;
            var volume = (4.0/3.0) * Math.PI * thirdPowerRadius * 0.5;
            Console.WriteLine($"The volume is {volume}");
           
            // Part 3

            Console.WriteLine("\nPart 3, area of a triangle (Heron's formula).");
        
        startSideA:
            Console.Write("Please enter an number (greater than 0) for side a: ");
            string sideAInput = Console.ReadLine();
            var sideA = double.Parse(sideAInput);
            bool greaterThanZeroSideA = sideA > 0;

            if (!greaterThanZeroSideA)
            {
                Console.WriteLine("You provided a number less than 0");
                goto startSideA;
            }
        
        startSideB:
            Console.Write("Please enter an number (greater than 0) for side b: ");
            string sideBInput = Console.ReadLine();
            var sideB = double.Parse(sideBInput);
            bool greaterThanZeroSideB = sideB > 0;

            if (!greaterThanZeroSideB)
            {
                Console.WriteLine("You provided a number less than 0");
                goto startSideB;
            }

        startSideC:
            Console.Write("Please enter an number (greater than 0) for side c: ");
            string sideCInput = Console.ReadLine();
            var sideC = double.Parse(sideCInput);
            bool greaterThanZeroSideC = sideC > 0;

            if (!greaterThanZeroSideC)
            {
                Console.WriteLine("You provided a number less than 0");
                goto startSideC;
            }
            // Implementation here

            var perimeter = (sideA + sideB + sideC) * .5;
            var heronForm = Math.Sqrt(perimeter * (perimeter -sideA) * (perimeter - sideB) * (perimeter - sideC));

            Console.WriteLine($"The area of a triangle (via Heron's formula) is {heronForm}");

            // Part 4
            Console.WriteLine("\nPart 4, solving a quadratic equation.");
        startConstA:
            Console.Write("Please enter an number (greater than 0) for constant a: ");
            string constAInput = Console.ReadLine();
            var constA = double.Parse(constAInput);
            bool greaterThanZeroConstA = constA > 0;

            if (!greaterThanZeroConstA)
            {
                Console.WriteLine("You provided a number less than 0");
                goto startConstA;
            }

        startConstB:
            Console.Write("Please enter an number (greater than 0) for constant b: ");
            string constBInput = Console.ReadLine();
            var constB = double.Parse(constBInput);
            bool greaterThanZeroConstB = constB > 0;

            if (!greaterThanZeroConstB)
            {
                Console.WriteLine("You provided a number less than 0");
                goto startConstB;
            }

        startConstC:
            Console.Write("Please enter an number (greater than 0) for constant c: ");
            string constCInput = Console.ReadLine();
            var constC = double.Parse(constCInput);
            bool greaterThanZeroConstC = constC > 0;

            if (!greaterThanZeroConstC)
            {
                Console.WriteLine("You provided a number less than 0");
                goto startConstC;
            }

            // Implementation here
            var denominator = (2 * constA);
            var doubleConstB = (constB * constB);
            var fourAC = (4 * constA * constC);
            var thingsToBeSquaredRooted = (doubleConstB - fourAC);
            var positiveNum = (constB * -1) + Math.Sqrt(thingsToBeSquaredRooted);
            var negativeNum = (constB * -1) - Math.Sqrt(thingsToBeSquaredRooted);
            Console.WriteLine($"The positive solution is {positiveNum / denominator}");
            Console.WriteLine($"The negative solution is {negativeNum / denominator}");
        }
    }
}