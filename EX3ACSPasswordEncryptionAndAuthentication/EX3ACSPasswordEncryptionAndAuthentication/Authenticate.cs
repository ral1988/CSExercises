using System;
using System.Collections.Generic;
using System.Linq;

namespace EX3ACSPasswordEncryptionAndAuthentication
{
    public class Authenticate
    {
        public Authenticate()
        {
            Console.WriteLine("authenticate");
        }

       public void AuthenticatePage(Dictionary<string, string> dictionary)
        {
            Console.WriteLine("print something");
            dictionary.Select(i => $"UserName: {i.Key}, Password: {i.Value}").ToList().ForEach(Console.WriteLine);
            Console.ReadKey();
        }
    }
}