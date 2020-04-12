using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Generic_Collections
{
    public class VariousGenericTypes<T>
    {
        //List<T>
        public static void ListValues()
        {
            List<string> tubas = new List<string>();
            foreach (string tuba in new string[5] {"Yamaha", "King", "Conn", "York", "Miraphone"})
            {
                tubas.Add(tuba);
                Console.WriteLine(tuba);
            }
        }
        //LinkedList<T>
        public static void LinkedListValues()
        {
            LinkedList<string> tubaPlayers = new LinkedList<string>();
            foreach (string player in new string[5]
                {"Øystein Baadsvik", "Roger Bobo", "John Fletcher", "Gene Pokorny", "Arnold Jacobs"})
            {
                tubaPlayers.AddFirst(player);
                Console.WriteLine(player);
            }
        }

        //Queue<T>
        public static void QueueValues()
        {
            Queue<int> valveCombinations = new Queue<int>();
            foreach (int listNumber in new int[5]{0, 1, 2, 3, 4})
            {
                valveCombinations.Enqueue(listNumber);
                Console.WriteLine(listNumber);
            }

        }

        //Stack<T>
        public static void StackValues()
        {
            Stack<string> busRoutes = new Stack<string>();
            foreach (string busName in new string[5]{"Blue", "Red", "Green", "Black", "Orange"})
            {
                busRoutes.Push(busName);
                Console.WriteLine(busName);
            }
        }

        //Dictionary<TKey, TValue>
        public static void DictionaryValues()
        {
            Dictionary<string, string> userAccount = new Dictionary<string, string>();
            userAccount.Add("user1", "password1");
            userAccount.Add("user2", "password2");
            userAccount.Add("user3", "password3");
            userAccount.Add("user4", "password4");
            userAccount.Add("user5", "password5");
            foreach (var userPassword in userAccount)
            {
                Console.WriteLine(userPassword);
            }

        }

        //SortedList<TKey, TValue>
        public static void SortedListValues()
        {
            SortedList<int, string> address = new SortedList<int, string>();
            address.Add(1, "Cougar Blvd");
            address.Add(2, "Cougar Blvd");
            address.Add(3, "Cougar Blvd");
            address.Add(4, "Cougar Blvd");
            address.Add(5, "Cougar Blvd");
            foreach (var houseNumber in address)
            {
                Console.WriteLine(houseNumber);
            }
        }

        //HashSet<T>
        public HashSet<T> HashSet;
        public static void HashSetValues()
        {
            HashSet<int> numbers = new HashSet<int>();
            foreach (int number in new int[5]{1, 2, 3, 4, 5})
            {
                numbers.Add(number);
                Console.WriteLine(number);
            }

        }
    }
}