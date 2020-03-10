using System;

namespace BisectionAlgorithm
{
    class Program
    {
        public double c;
        public double Func(double x)
        {
            double function = x * x * x - 2 * x * x + 3;
            return function;
        }
        public void bisection(double a, double b, double e)
        {
            Program func = new Program();
            if (func.Func(a) * func.Func(b) >= 0)
            {
                Console.WriteLine("Incorrect a and b");
                return;
            }
            c = a;
            while ((b - a) >= e)
            {
                c = (a + b) / 2;
                if (func.Func(c) == 0.0)
                {
                    Console.WriteLine("Root = " + c);
                    break;
                }
                else if (func.Func(c) * func.Func(a) < 0)
                {
                    Console.WriteLine("Root = " + c);
                    b = c;
                }
                else
                {
                    Console.WriteLine("Root = " + c);
                    a = c;
                }
            }
        }
        public static void Main(string[] args)
        {
            double a, b, e;
            Console.WriteLine("Enter the desired accuracy:");
            e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the lower limit:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the upper limit:");
            b = Convert.ToDouble(Console.ReadLine());
            Program bisec = new Program();
            bisec.bisection(a, b, e);
        }
    }
}