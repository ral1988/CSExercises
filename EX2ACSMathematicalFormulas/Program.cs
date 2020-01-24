using System;


namespace progex01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1
            // Partially worked example
            Console.WriteLine("\nPart 1, circumference and area of a circle.");
            Console.Write("Enter an integer for the radius (will be used for part 1 & 2): ");
            string strradius = Console.ReadLine();
            int intradius = int.Parse(strradius);
            var circumference = 2 * Math.PI * intradius;
            Console.WriteLine($"The circumference is {circumference}");

            // Implementation for area here
            var secondPowerRadius = intradius * intradius;
            var area = Math.PI * secondPowerRadius;
            Console.WriteLine($"The area is {area}");




            // Part 2
            Console.WriteLine("\nPart 2, volume of a hemisphere.");

            // Implementation here
            var thirdPowerRadius = intradius * intradius * intradius;
            var volume = (4.0/3.0) * Math.PI * thirdPowerRadius * 0.5;
            Console.WriteLine($"The volume is {volume}");
            
           
            // Part 3

            Console.WriteLine("\nPart 3, area of a triangle (Heron's formula).");
            Console.Write("Please enter an integer (greater than 0) for side a: ");
            string sideAInput = Console.ReadLine();
            var sideA = int.Parse(sideAInput);
            Console.Write("Please enter an integer (greater than 0) for side b: ");
            string sideBInput = Console.ReadLine();
            var sideB = int.Parse(sideBInput);
            Console.Write("Please enter an integer (greater than 0) for side c: ");
            string sideCInput = Console.ReadLine();
            var sideC = int.Parse(sideCInput);
            // Implementation here

            var perimeter = (sideA + sideB + sideC) * .5;
            var heronForm = Math.Sqrt(perimeter * (perimeter -sideA) * (perimeter - sideB) * (perimeter - sideC));

            Console.WriteLine($"The area of a triangle (via Heron's formula) is {heronForm}");

            // Part 4
            Console.WriteLine("\nPart 4, solving a quadratic equation.");
            Console.Write("Please enter an integer (greater than 0) for constant a: ");
            string constAInput = Console.ReadLine();
            var constA = int.Parse(constAInput);
            Console.Write("Please enter an integer (greater than 0) for constant b: ");
            string constBInput = Console.ReadLine();
            var constB = int.Parse(constBInput) * -1;
            Console.Write("Please enter an integer (greater than 0) for constant c: ");
            string constCInput = Console.ReadLine();
            var constC = int.Parse(constCInput);

            // Implementation here
            var denominator = (2 * constA);
            var doubleConstB = (constB * constB);
            var fourAC = (4 * constA * constC);
            var thingsToBeSquaredRooted = (doubleConstB - fourAC);
            var positiveNum = constB + Math.Sqrt(thingsToBeSquaredRooted);
            var negativeNum = constB - Math.Sqrt(thingsToBeSquaredRooted);
            Console.WriteLine($"The positive solution is {positiveNum / denominator}");
            Console.WriteLine($"The negative solution is {negativeNum / denominator}");
        }
    }
}