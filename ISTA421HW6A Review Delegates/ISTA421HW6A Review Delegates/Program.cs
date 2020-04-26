//Provide code for two event classes, each containing one event.
//Define the first with an old-style delegate using the delegate
//keyword and the second with a new-style delegate using
//Func/Action/Predicate.

using System;
using System.Net;

namespace ISTA421HW6A_Review_Delegates
{
    class Program
    {
        public static int AddTwoInts(int a, int b)
        {
            var c = a + b;

            return c;
        }

        public delegate double AddThings(int a, int b);


        public Func<int, int> AddFunc;

        static void Main(string[] args)
        {
            int a = 10;
            int b = 12;

            Console.WriteLine(AddTwoInts(a, b));
            Console.WriteLine();

        }
    }

    
}
