//You have been assigned the implementation of a password system that runs in memory.
//Write a console program that does two things:
//
//it collects a plain text password from an individual user and stores the password in
//a string cipher, and it verifies a user by username and password.
//Your user interface should have three options:
//
//1. save a new password for a specific username,
//2. authenticate a specific username/password pair, or
//3. exit the application.
//On exit, all username/password pairs will be lost
//
//Passwords entered at the console prompt are to be in plain text. All password saved in memory are to be encoded. Imagine that someone else is writing a database module to afford persistent storage of usernamne/password pairs. You do not want anyone with access to the database to be able to read the plain text of passwords.
//
//You have three challenges in this exercise. First, you need to construct a user interface that presents the user with the three options listed above. Second, you need to discover how you can convert strings to unintelligible collections of random characters. Check the documentation — it’s your friend. Third, you need to define a data structure (collection) that can insert values and search values very rapidly.
//
//As always, work the problem out by hand first, then implement your natural language solution in C# code. The exercise has some challenges, but it is decidedly on the easy side. Solve the problem first in English, then rewrite it in the language that the machine understands.




using System;

namespace EX3ACSPasswordEncryptionAndAuthentication
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new Menu();
            
        }
    }
}
