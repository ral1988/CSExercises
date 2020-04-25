using System;
using System.Transactions;

namespace ISTA421EX4A_Encrypting_and_Decrypting_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            string plainText = Util.GetPlainText();
            string singleKey = Util.GetSingleKey();
            string multiKey = Util.GetMultiJKey();

            Console.WriteLine($"You entered [{plainText}] as plain text");
            Console.WriteLine($"You entered [{singleKey}] as your single key");
            Console.WriteLine($"You entered [{multiKey}]as your multi key");
            Console.WriteLine();

            int[] cleanText = Util.Clean(plainText);
            int[] cleanSKey = Util.Clean(singleKey);
            int[] cleanMKey = Util.Clean(multiKey);

            string encSingle = Util.SingleEnc(cleanText, cleanSKey);
            string encMulti = Util.MultiEnc(cleanText, cleanMKey);
            string encConti = Util.ContiEnc(cleanText, cleanMKey);

            Console.WriteLine($"Encrypted message with single key is [{encSingle}]");
            Console.WriteLine($"Encrypted message with multi key is [{encMulti}]");
            Console.WriteLine($"Encrypted message with continuous key is [{encConti}]");
            Console.WriteLine();

            string decSingle = Util.SingleDec(encSingle, cleanSKey);
            string decMulti = Util.MultiDec(encMulti, cleanMKey);
            string decConti = Util.ContiDec(encConti, cleanMKey);

            Console.WriteLine($"Decrypted message with single key is [{decSingle}]");
            Console.WriteLine($"Decrypted message with multi key is [{decMulti}]");
            Console.WriteLine($"Decrypted message with continuous key is [{decConti}]");
            Console.WriteLine();
        }
    }

    internal static class Util
    {
        public static string GetPlainText()
        {
            Console.Write("Enter plain text: ");
            var plainText = Console.ReadLine();
            return plainText;
        }

        public static string GetSingleKey()
        {
            Console.Write("Enter your single key as an alpha character: ");
            var singleKey = Console.ReadLine();
            return singleKey;
        }

        public static string GetMultiJKey()
        {
            Console.Write("Enter your multi key as alpha characters: ");
            var multiKey = Console.ReadLine();
            return multiKey;
        }

        public static string ContiEnc(int[] cleanText, int[] cleanMKey)
        {
            throw new NotImplementedException();
        }

        public static string MultiEnc(int[] cleanText, int[] cleanMKey)
        {
            throw new NotImplementedException();
        }

        public static string SingleEnc(int[] cleanText, int[] cleanSKey)
        {
            throw new NotImplementedException();
        }

        public static int[] Clean(string stringInput)
        {
            throw new NotImplementedException();
        }

        public static string SingleDec(string encSingle, int[] cleanSKey)
        {
            throw new NotImplementedException();
        }

        public static string MultiDec(string encMulti, int[] cleanMKey)
        {
            throw new NotImplementedException();
        }

        public static string ContiDec(string encConti, int[] cleanMKey)
        {
            throw new NotImplementedException();
        }
    }
}
