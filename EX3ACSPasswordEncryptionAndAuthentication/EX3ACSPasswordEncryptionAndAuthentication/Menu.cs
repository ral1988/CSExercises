using System;
using System.Net.Mime;
using System.Security.Cryptography;
using System.Threading.Channels;

namespace EX3ACSPasswordEncryptionAndAuthentication
{
    public class Menu
    {

        public Menu()
        {
            var key = Console.ReadLine();


            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("               PASSWORD AUTHENTICATION SYSTEM ");
            Console.WriteLine("               Please select one option:" +
                              "               \n1. Establish an account " +
                              "               \n2. Authenticate a user " +
                              "               \n3. Exit the system " +
                              $"               \n\n Enter Selection: ");

            Console.WriteLine("--------------------------------------------------------------------");


            Console.Clear();

            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("               PASSWORD AUTHENTICATION SYSTEM ");
            Console.WriteLine("               Please select one option:" +
                              "               \n1. Establish an account " +
                              "               \n2. Authenticate a user " +
                              "               \n3. Exit the system " +
                              $"               \n\n Enter Selection: {key}");

            Console.WriteLine("--------------------------------------------------------------------");
            


            switch (key)
            {
                case "1":
                    CreateAccount();
                    break;
                case "2":
                    Authenticate();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Sorry, invalid input. Please pick option 1, 2, or 3");
                    break;
            }
        }
    }
}