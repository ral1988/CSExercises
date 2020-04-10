using System;
using System.Collections.Generic;
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
            Dictionary<string, string> accountInfoDict = new Dictionary<string, string>();
            Console.WriteLine("Welcome to the account creation page");
            Console.WriteLine("Enter your username: ");
            var userName = Console.ReadLine();
            if (userName == null)
            {

            }
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

            accountInfoDict[userName] = password;
            return accountInfoDict;

        }
    }
}