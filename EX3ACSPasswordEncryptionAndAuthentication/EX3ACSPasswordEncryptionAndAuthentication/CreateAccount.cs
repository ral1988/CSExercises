using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Transactions;

namespace EX3ACSPasswordEncryptionAndAuthentication
{
    public class CreateAccount 
    {
        public CreateAccount()
        {

        }

        public Dictionary<string, string> CreateAccountPage()
        {
            using (MD5 MD5Hash = MD5.Create())
            {
                GetMd5Hash getMD5 = new GetMd5Hash();
                Console.Clear();

                Dictionary<string, string> accountInfoDict = new Dictionary<string, string>();
                Console.WriteLine("Welcome to the account creation page");
                Console.Write("\nEnter your username: ");
                string userName = Console.ReadLine();
                if (userName == null)
                {

                }

                string userHash = getMD5.MakeMd5Hash(MD5Hash, userName);

                passwordSection:
                Console.WriteLine("Enter your password: ");
                var password = Console.ReadLine();
                Console.WriteLine("Please confirm your password: ");
                var passwordCheck = Console.ReadLine();

                if (password != passwordCheck)
                {
                    Console.WriteLine("Your passwords do not match.");
                    goto passwordSection;
                }

                string passwordHash = getMD5.MakeMd5Hash(MD5Hash, password);

                accountInfoDict[userHash] = passwordHash;
                return accountInfoDict;
            }
            

        }
    }
}