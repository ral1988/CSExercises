using System;

namespace EX3cCSManipulatingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int[] arrayA = new int[] { 0, 2, 4, 6, 8, 10 };
            int[] arrayB = new int[] { 1, 3, 5, 7, 9 };
            int[] arrayC = new int[] { 3, 1, 4, 5, 9, 2, 6, 5, 3, 5, 9 };


            Console.WriteLine("Information and applied methods on arrayA");
            ArrayInformation(arrayA);
            Reverse(arrayA);
            Rotating("left", 2, arrayA);
            Console.WriteLine();
            Console.WriteLine("Information and applied methods on arrayB");
            ArrayInformation(arrayB);
            Reverse(arrayB);
            Rotating("right", 2, arrayB);
            Console.WriteLine();
            Console.WriteLine("Information and applied methods on arrayC");
            ArrayInformation(arrayC);
            Reverse(arrayC);
            Rotating("left", 4, arrayC);
            Sorting(arrayC);
            
        }

        public static int ArrayInformation(int[] array)
        {

            Console.WriteLine($"Length of this array: {array.Length}");
            var sum = 0.0;
            for (int i = 0; i < array.Length; i++)
                sum += array[i];

            Console.WriteLine($"Sum of this array: {sum}");
            Console.WriteLine($"Average value of the array: {sum / array.Length}");
            return 0;
        }

        public static void Reverse(int[] array)
        {
            for (int i = 0; i < array.Length /2; i++)
            {
                int tmp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = tmp;
            }
           
            Console.WriteLine($"The reverse of the array: {String.Join(',', array)}");
        }
        private static void Rotating(string direction, int places, int[] array)
        {
            if (direction == "left")
            {
                int numberLength = array.Length;
                for (int i = 0; i < numberLength / 2; i++)
                {
                    int tmp                     = array[i];
                    array[i]                    = array[numberLength - i - 1];
                    array[numberLength - i - 1] = tmp;
                }
                Console.WriteLine($"Original array: {String.Join(',', array)}");
                for (int i = 0; i < places; i++)
                {
                    var temp = array[0];
                    for (int j = 1; j < numberLength; j++)
                    {
                        array[j - 1] = array[j];
                    }
                    array[numberLength - 1] = temp;
                }
            }

            if (direction == "right")
            {
                int numberLength = array.Length;
                for (int i = 0; i < numberLength /2; i++)
                {
                    var tmp                     = array[i];
                    array[i]                    = array[numberLength - i - 1];
                    array[numberLength - i - 1] = tmp;
                }
                Console.WriteLine($"Original array: {String.Join(',', array)}");
                for (int i = 0; i < places; i++)
                {
                    var temp = array[numberLength - 1];
                    for (var j = numberLength - 2; j >= 0; j--)
                    {
                        array[j + 1] = array[j];
                    }
                    array[0] = temp;
                }

            }

            Console.WriteLine($"Rotated the array to the {direction} {places} places: {String.Join(',', array)}");
        }
        public static void Sorting(int[] array)
        {
            int numberLength = array.Length;
            for (int i = (numberLength - 1); i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (array[j -1 ] > array[j])
                    {
                        int temp      = array[j - 1];
                        array[j - 1]  = array[j];
                        array[j]      = temp;
                    }
                }
            }
            Console.WriteLine($"Sorted array: {String.Join(',', array)}");

        }
    }
}
