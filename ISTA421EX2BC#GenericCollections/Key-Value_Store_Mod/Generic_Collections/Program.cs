using System;


namespace Generic_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T>
            Console.WriteLine("List Values:");
            VariousGenericTypes<object>.ListValues();

            //LinkedList<T>
            Console.WriteLine("\n\nLinked List Values:");
            VariousGenericTypes<object>.LinkedListValues();

            //Queue<T>
            Console.WriteLine("\n\nQueue Values:");
            VariousGenericTypes<object>.QueueValues();

            //Stack<T>
            Console.WriteLine("\n\nStack Values:");
            VariousGenericTypes<object>.StackValues();

            //Dictionary<TKey, TValue>
            Console.WriteLine("\n\nDictionary Values:");
            VariousGenericTypes<object>.DictionaryValues();

            //SortedList<TKey, TValue>
            Console.WriteLine("\n\nSorted List Values:");
            VariousGenericTypes<object>.SortedListValues();

            //HashSet<T>
            Console.WriteLine("\n\nHash Set Values:");
            VariousGenericTypes<object>.HashSetValues();
        }
    }
}
