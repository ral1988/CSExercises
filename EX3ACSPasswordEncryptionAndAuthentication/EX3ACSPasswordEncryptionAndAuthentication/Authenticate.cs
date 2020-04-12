using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

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
            Dictionary<string, string> comparableDict = dictionary;
            Dictionary<string, string> authDict = new Dictionary<string, string>();

            using (MD5 MDHash = MD5.Create())
            {
                GetMd5Hash getMD5 = new GetMd5Hash();
                Console.Clear();

                Console.WriteLine("Authenticate your user and password information");
                Console.WriteLine("You'll be asked to provide your username and password");
                Console.Write("\nUsername: ");
                string userName = Console.ReadLine();
                string userNameAuthHash = getMD5.MakeMd5Hash(MDHash, userName);
                Console.Write("Password: ");
                string password = Console.ReadLine();
                string passwordAuthHash = getMD5.MakeMd5Hash(MDHash, password);

                authDict[userNameAuthHash] = passwordAuthHash;

                foreach (var keyPair in comparableDict)
                {
                    string value;
                    if (authDict.TryGetValue(keyPair.Key, out value))
                    {
                        if (value != keyPair.Value)
                        {
                            Console.WriteLine("Username and/or password is not correct");
                            Console.ReadKey();
                        }

                        Console.WriteLine("Authenticated");
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}