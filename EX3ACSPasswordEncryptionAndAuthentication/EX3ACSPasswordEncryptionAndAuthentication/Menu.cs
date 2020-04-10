using System;
using System.Linq;
using System.Collections.Generic;
using System.Net.Mime;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Channels;

namespace EX3ACSPasswordEncryptionAndAuthentication
{
    public class Menu
    {
        public Menu()
        {
            while (true)
            {
                string dashes = string.Concat(Enumerable.Repeat('-', 60));
                Console.WriteLine(dashes);
                Console.Write("\r\n" +
                              "       PASSWORD AUTHENTICATION SYSTEM\r\n " +
                              "\r\n" +
                              "       Please select one option:\r\n" +
                              "       1. Establish an account\r\n" +
                              "       2. Authenticate a user\r\n" +
                              "       3. Exit the system\r\n" +
                              "\r\n");
                int x = Console.CursorTop;
                int y = Console.CursorLeft;
                Console.SetCursorPosition(0, 25);
                Console.WriteLine(dashes);
                Console.SetCursorPosition(y, x);
                Console.Write("       Enter selection: ");
            
                var keySelect = Console.ReadKey();

                while (keySelect.Key != ConsoleKey.D1 && keySelect.Key != ConsoleKey.D2 &&
                       keySelect.Key != ConsoleKey.D3)
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid input. Try Again.");
                    keySelect = Console.ReadKey();
                }

                switch (keySelect.Key)
                {
                    case ConsoleKey.D1:
                    {
                        Thread.Sleep(200);
                        Console.Clear();
                        var createAccount = new CreateAccount();
                        Console.ReadKey();
                        continue;
                    }
                    case ConsoleKey.D2:
                    {
                        Thread.Sleep(200);
                        Console.Clear();
                        var authenticate = new Authenticate();
                        continue;
                    }
                    case ConsoleKey.D3:
                        Thread.Sleep(200);
                        Console.Clear();
                        Console.WriteLine("Cleared all user information. Goodbye!");
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}